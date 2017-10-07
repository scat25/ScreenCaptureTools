using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ScreenCam
{
   public partial class Editor : Form
   {
      List<Bitmap> frames;

      void UpdateUI()
      {
         if (frames.Count != 0)
         {
            scrollBar.Maximum = frames.Count - 1;
            currentFrame.Image = frames[scrollBar.Value];
            frameCount.Text = string.Format("Frame: {0}/{1}", scrollBar.Value + 1, scrollBar.Maximum + 1);
         }
         else
         {
            currentFrame.Image = new Bitmap(1, 1);
            frameCount.Text = string.Format("Frame: {0}/{1}", 0, 0);
         }
      }

      public Editor(List<Bitmap> f)
      {
         InitializeComponent();
         frames = f;
         UpdateUI();
      }

      private void RemoveStartToThis_Click(object sender, EventArgs e)
      {
         int l = scrollBar.Value;
         for (int i = 0; i <= l && frames.Count > 0; i++)
         {
            frames.RemoveAt(0);
         }
         UpdateUI();
      }

      private void RemoveFrame_Click(object sender, EventArgs e)
      {
			if (frames.Count > 0)
			{
				frames.RemoveAt(scrollBar.Value);
			}
         UpdateUI();
      }

      private void RemoveThisToEnd_Click(object sender, EventArgs e)
      {
			int l = frames.Count - scrollBar.Value;
         for (int i = 0; i <= l && frames.Count > 0; i++)
         {
            frames.RemoveAt(frames.Count - 1);
         }
         UpdateUI();
      }

      private void ScrollBar_Scroll(object sender, ScrollEventArgs e)
      {
         currentFrame.Image = frames[scrollBar.Value];
         frameCount.Text = string.Format("Frame: {0}/{1}", scrollBar.Value + 1, scrollBar.Maximum + 1);
      }

		private void Editor_Load(object sender, EventArgs e)
		{
			if (Properties.Settings.Default.EditorWindowLocation != null)
			{
				Location = Properties.Settings.Default.EditorWindowLocation;
			}

			if (Properties.Settings.Default.EditorWindowSize != null)
			{
				Size = Properties.Settings.Default.EditorWindowSize;
			}
		}

		private void Editor_FormClosing(object sender, FormClosingEventArgs e)
		{
			Properties.Settings.Default.EditorWindowLocation = Location;

			if (WindowState == FormWindowState.Normal)
			{
				Properties.Settings.Default.EditorWindowSize = Size;
			}
			else
			{
				Properties.Settings.Default.EditorWindowSize = RestoreBounds.Size;
			}

			Properties.Settings.Default.Save();
		}
	}
}
