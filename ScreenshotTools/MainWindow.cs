using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using ScreenCaptureTools;

namespace ScreenshotTools
{
   public partial class MainWindow : Form
   {

      public MainWindow()
      {
         InitializeComponent();
         ResetImages();
         ToolStrip1.BackColor = Control.DefaultBackColor;
         UpdateCaptureSizeFromControl();
      }

      List<Bitmap> capturedImages = new List<Bitmap>();
      Size captureSize;

      void UpdateCaptureSizeFromControl()
      {
         int width = CaptureArea.Size.Width - 2;
         int height = CaptureArea.Size.Height - 2;
         captureSize = new Size(width, height);
      }

      delegate void UpdateFrameTextCallback(string text);

      void UpdateFrameText(string text)
      {
         ImagesCount.Text = text;
      }

      delegate Point GetCaptureLocationCallback();

      Point GetCaptureLocation()
      {
         return CaptureArea.PointToScreen(Point.Empty);
      }

      void ResetImages()
      {
         capturedImages.Clear();
         UpdateFrameText("0");
         Edit.Enabled = false;
         Save.Enabled = false;
      }

      private void CaptureBitmap()
      {
         var location = (Point)this.Invoke(new GetCaptureLocationCallback(GetCaptureLocation));
         Bitmap bmp = ScreenCapture.Capture(new Rectangle(location, captureSize), CaptureCursor.Checked, HighlightCursor.Checked);
         capturedImages.Add(bmp);
         this.Invoke(new UpdateFrameTextCallback(UpdateFrameText), new object[] { string.Format("{0}", capturedImages.Count) });
      }

      enum StorageMode
      {
         ImageSeries,
         HorizontalStitched,
         VerticalStitched
      }

      private string NextAvailableFilename(string filePath)
      {
         FileInfo fi = new FileInfo(filePath);
         string fileName = Path.GetFileNameWithoutExtension(filePath);
         //add increasing suffix like _01 for existing files 
         int i = 1;
         while (File.Exists(filePath))
         {
            filePath = fi.DirectoryName + "\\" + fileName + "_" + string.Format("{0:00}", i) + fi.Extension;
            i++;
         }
         return filePath;
      }

      private void StoreImageSeries(string filePath)
      {
         FileInfo fi = new FileInfo(filePath);
         string imageSeriesDirectory = fi.DirectoryName + "\\" + Path.GetFileNameWithoutExtension(filePath);
         Directory.CreateDirectory(imageSeriesDirectory);
         int number = 1;
         foreach (var b in capturedImages)
         {
            b.Save(imageSeriesDirectory + string.Format("\\Image_{0:000}.png", number++));
         }
      }

      private void StoreHorizontalStitchedImage(string filePath)
      {
         int maxHeight = 0;
         int accumulatedWidth = 0;
         foreach (var b in capturedImages)
         {
            var size = b.Size;
            if (maxHeight < size.Height)
            {
               maxHeight = size.Height;
            }
            accumulatedWidth += size.Width;
         }
         Bitmap resultBitmap = new Bitmap(accumulatedWidth, maxHeight);
         using (Graphics g = Graphics.FromImage(resultBitmap))
         {
            int nextPos = 0;
            foreach (var b in capturedImages)
            {
               g.DrawImage(b, nextPos, 0);
               nextPos += b.Size.Width;
            }
         }
         resultBitmap.Save(filePath);
      }

      private void StoreVerticalStitchedImage(string filePath)
      {
         int maxWidth = 0;
         int accumulatedHeight = 0;
         foreach (var b in capturedImages)
         {
            var size = b.Size;
            if (maxWidth < size.Width)
            {
               maxWidth = size.Width;
            }
            accumulatedHeight += size.Height;
         }
         Bitmap resultBitmap = new Bitmap(maxWidth, accumulatedHeight);
         using (Graphics g = Graphics.FromImage(resultBitmap))
         {
            int nextPos = 0;
            foreach (var b in capturedImages)
            {
               g.DrawImage(b, 0, nextPos);
               nextPos += b.Size.Height;
            }
         }
         resultBitmap.Save(filePath);
      }

      private void StoreScreenshots(string defaultName, StorageMode mode)
      {
         SaveFileDialog saveFileDialog = new SaveFileDialog
         {
            Filter = "Image (*.png)|*.png",
            FilterIndex = 0,
            InitialDirectory = Properties.Settings.Default.LastStorageLocation,
            OverwritePrompt = false,
            RestoreDirectory = true,
            FileName = string.Format("{0}_{1}", defaultName, DateTime.Now.ToString("yyyy-MM-dd_HH-mm-ss"))
         };

         if (saveFileDialog.ShowDialog() == DialogResult.OK)
         {
            try
            {
               Cursor.Current = Cursors.WaitCursor;
               string filePath = NextAvailableFilename(saveFileDialog.FileName);
               FileInfo fi = new FileInfo(filePath);
               Properties.Settings.Default.LastStorageLocation = fi.DirectoryName;
               switch (mode)
               {
                  case StorageMode.ImageSeries:
                     StoreImageSeries(filePath);
                     break;
                  case StorageMode.HorizontalStitched:
                     StoreHorizontalStitchedImage(filePath);
                     break;
                  case StorageMode.VerticalStitched:
                     StoreVerticalStitchedImage(filePath);
                     break;
                  default:
                     break;
               }
               ResetImages();
               Cursor.Current = Cursors.Default;
            }
            catch (Exception ex)
            {
               MessageBox.Show("Cannot save image:\n\n" + ex.Message, "Error");
            }
         }
      }

      private void TakeScreenshot_Click(object sender, EventArgs e)
      {
         int delay = 0;
         if (delay1Second.Checked) delay = 1;
         if (delay3Seconds.Checked) delay = 3;
         if (delay5Seconds.Checked) delay = 5;
         Edit.Enabled = false;
         Save.Enabled = false;
         TakeScreenshot.Enabled = false;
         timer1.Interval = Math.Max(delay * 1000, 1);
         timer1.Enabled = true;
      }

      private void Save_Click(object sender, EventArgs e)
      {
         StoreScreenshots("ImageSeries", StorageMode.ImageSeries);
      }

      private void StoreHorizontalStitchedImageToolStripMenuItem_Click(object sender, EventArgs e)
      {
         StoreScreenshots("HorizontalStitchedImage", StorageMode.HorizontalStitched);
      }

      private void StoreVerticalStitchedImageToolStripMenuItem_Click(object sender, EventArgs e)
      {
         StoreScreenshots("VerticalStitchedImage", StorageMode.VerticalStitched);
      }

      private void MainWindow_Resize(object sender, EventArgs e)
      {
         UpdateCaptureSizeFromControl();
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
            Properties.Settings.Default.LastStorageLocation = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
         }
         CaptureCursor.Checked = Properties.Settings.Default.CaptureCursor;
         HighlightCursor.Checked = Properties.Settings.Default.HighlightCursor;
         ToolStripManager.LoadSettings(this);
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
         ToolStripManager.SaveSettings(this);
         Properties.Settings.Default.Save();
      }

      private void NewScreenshotSeries_Click(object sender, EventArgs e)
      {
         ResetImages();
      }

      private void Edit_Click(object sender, EventArgs e)
      {
         TopMost = false;
         Editor ed = new Editor(capturedImages);
         ed.ShowDialog();
         ImagesCount.Text = string.Format("{0}", capturedImages.Count);
         TopMost = true;
         if (capturedImages.Count == 0)
         {
            Edit.Enabled = false;
            Save.Enabled = false;
         }
      }

      private void delay1Second_CheckedChanged(object sender, EventArgs e)
      {
         if (delay1Second.Checked)
         {
            delay3Seconds.Checked = false;
            delay5Seconds.Checked = false;
         }
      }

      private void delay3Seconds_CheckedChanged(object sender, EventArgs e)
      {
         if (delay3Seconds.Checked)
         {
            delay1Second.Checked = false;
            delay5Seconds.Checked = false;
         }
      }

      private void delay5Seconds_CheckedChanged(object sender, EventArgs e)
      {
         if (delay5Seconds.Checked)
         {
            delay1Second.Checked = false;
            delay3Seconds.Checked = false;
         }
      }

      private void timer1_Tick(object sender, EventArgs e)
      {
         timer1.Enabled = false;
         CaptureBitmap();
         Edit.Enabled = true;
         Save.Enabled = true;
         TakeScreenshot.Enabled = true;
      }
   }
}
