using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Timers;
using Accord.Video.FFMPEG;
using ScreenCaptureTools;

namespace ScreenCam
{
   public partial class MainWindow : Form
   {
      System.Timers.Timer recordingTimer = new System.Timers.Timer();

      public MainWindow()
      {
         InitializeComponent();
         recordingTimer.Interval = 1000.0 / 30.0;
         recordingTimer.Elapsed += RecordingTimer_Elapsed;
         recordingTimer.AutoReset = true;
         Edit.Enabled = false;
         Save.Enabled = false;
         ToolStrip1.BackColor = Control.DefaultBackColor;
      }

      int fps = 30;
      List<Bitmap> frames = new List<Bitmap>();
      bool isRecording = false;
      Size captureSize;

      void UpdateCaptureSizeFromControl()
      {
         int width = CaptureArea.Size.Width - 2;
         int height = CaptureArea.Size.Height - 2;
         captureSize = new Size(width, height);
      }

      void UpdateFPS()
      {
         if (Fps30.Checked == true)
         {
            Fps30.Checked = true;
            Fps60.Checked = false;
            this.fps = 30;
            recordingTimer.Interval = 1000.0 / 30.0;
         }
         else if (Fps60.Checked == true)
         {
            Fps30.Checked = false;
            Fps60.Checked = true;
            this.fps = 60;
            recordingTimer.Interval = 1000.0 / 60.0;
         }
      }

      delegate void UpdateFrameTextCallback(string text);

      void UpdateFrameText(string text)
      {
         FrameCount.Text = text;
      }

      delegate Point GetCaptureLocationCallback();

      Point GetCaptureLocation()
      {
         return CaptureArea.PointToScreen(Point.Empty);
      }

      private void CaptureBitmap()
      {
         var location = (Point)this.Invoke(new GetCaptureLocationCallback(GetCaptureLocation));
         Bitmap bmp = ScreenCapture.Capture(new Rectangle(location, captureSize), CaptureCursor.Checked, HighlightCursor.Checked);
         frames.Add(bmp);
         this.Invoke(new UpdateFrameTextCallback(UpdateFrameText), new object[] { string.Format("{0}", frames.Count) });
      }

      private void StartRecording()
      {
         frames.Clear();
         MaximumSize = Size;
         MinimumSize = Size;
         MinimizeBox = false;
         Edit.Enabled = false;
         Save.Enabled = false;
         Record.DropDownButtonWidth = 0;
         UpdateCaptureSizeFromControl();
         isRecording = true;
         Record.Image = Properties.Resources.StopRecording;
         recordingTimer.Start();
      }

      private void FinishRecording()
      {
         isRecording = false;
         Edit.Enabled = true;
         Save.Enabled = true;
         Record.DropDownButtonWidth = 11;
         MaximumSize = new Size(0, 0);
         MinimumSize = new Size(0, 0);
         MinimizeBox = true;
         Record.Image = Properties.Resources.StartRecording;
         recordingTimer.Stop();
      }

      private void StoreRecording()
      {
         var saveFileDialog = new SaveFileDialog
         {
            Filter = "Video (*.mp4)|*.mp4",
            FilterIndex = 0,
            InitialDirectory = Properties.Settings.Default.LastStorageLocation,
            OverwritePrompt = false,
            RestoreDirectory = true,
            FileName = string.Format("ScreenRecording_{0}", DateTime.Now.ToString("yyyy-MM-dd_HH-mm-ss"))
         };

         if (saveFileDialog.ShowDialog() == DialogResult.OK)
         {
            try
            {
               string filePath = saveFileDialog.FileName;
               string fileName = Path.GetFileNameWithoutExtension(saveFileDialog.FileName);
               FileInfo fi = new FileInfo(saveFileDialog.FileName);
               Cursor.Current = Cursors.WaitCursor;
               Properties.Settings.Default.LastStorageLocation = fi.DirectoryName;
               //add increasing suffix like _01 for existing files 
               int i = 1;
               while (File.Exists(filePath))
               {
                  filePath = fi.DirectoryName + "\\" + fileName + "_" + string.Format("{0:00}", i) + fi.Extension;
                  i++;
               }
               using (VideoFileWriter vfw = new VideoFileWriter())
               {
                  vfw.Open(filePath, captureSize.Width, captureSize.Height, fps, VideoCodec.H264, 8000000);
                  foreach (var bmp in frames)
                  {
                     vfw.WriteVideoFrame(bmp);
                  }
                  vfw.Close();
               }
               Edit.Enabled = false;
               Save.Enabled = false;
               FrameCount.Text = "0";
               Cursor.Current = Cursors.Default;
            }
            catch (Exception ex)
            {
               MessageBox.Show("Cannot save video:\n\n" + ex.Message, "Error");
            }
         }
      }

      private void Edit_Click(object sender, EventArgs e)
      {
         TopMost = false;
         Editor ed = new Editor(frames);
         ed.ShowDialog();
         FrameCount.Text = string.Format("{0}", frames.Count);
         TopMost = true;
         if (frames.Count == 0)
         {
            Edit.Enabled = false;
            Save.Enabled = false;
         }
      }

      private void Record_Click(object sender, EventArgs e)
      {
         if (isRecording)
         {
            FinishRecording();
         }
         else
         {
            StartRecording();
         }
      }

      private void Save_Click(object sender, EventArgs e)
      {
         StoreRecording();
      }

      private void RecordingTimer_Elapsed(Object source, System.Timers.ElapsedEventArgs e)
      {
         CaptureBitmap();
      }

      private void MainWindow_Resize(object sender, EventArgs e)
      {
         //ensure the capture size is a multiple of 2 in width and height
         UpdateCaptureSizeFromControl();
         if (captureSize.Width % 2 != 0)
         {
            Width += 1;
         }
         if (captureSize.Height % 2 != 0)
         {
            Height += 1;
         }
      }

      private void MainWindow_Load(object sender, EventArgs e)
      {
         if (Properties.Settings.Default.MainWindowLocation != null)
         {
            Location = Properties.Settings.Default.MainWindowLocation;
         }

         if (Properties.Settings.Default.MainWindowSize != null)
         {
            Size = Properties.Settings.Default.MainWindowSize;
         }

         if (Properties.Settings.Default.LastStorageLocation == "")
         {
            Properties.Settings.Default.LastStorageLocation = Environment.GetFolderPath(Environment.SpecialFolder.MyVideos);
         }
         CaptureCursor.Checked = Properties.Settings.Default.CaptureCursor;
         HighlightCursor.Checked = Properties.Settings.Default.HighlightCursor;
         byte fps = Properties.Settings.Default.FPS;
         Fps30.Checked = fps != 60;
         Fps60.Checked = fps == 60;
         ToolStripManager.LoadSettings(this);
         UpdateFPS();
      }

      private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
      {
         Properties.Settings.Default.MainWindowLocation = Location;

         if (WindowState == FormWindowState.Normal)
         {
            Properties.Settings.Default.MainWindowSize = Size;
         }
         else
         {
            Properties.Settings.Default.MainWindowSize = RestoreBounds.Size;
         }

         Properties.Settings.Default.CaptureCursor = CaptureCursor.Checked;
         Properties.Settings.Default.HighlightCursor = HighlightCursor.Checked;
         Properties.Settings.Default.FPS = Fps60.Checked ? (byte)60 : (byte)30;
         ToolStripManager.SaveSettings(this);
         Properties.Settings.Default.Save();
      }

      private void Fps30_Click(object sender, EventArgs e)
      {
         UpdateFPS();
      }

      private void Fps60_Click(object sender, EventArgs e)
      {
         UpdateFPS();
      }
   }
}
