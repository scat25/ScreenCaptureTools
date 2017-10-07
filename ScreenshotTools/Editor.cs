using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ScreenshotTools
{
   public partial class Editor : Form
   {
      List<Bitmap> bitmaps;

      void UpdateUI()
      {
         if (bitmaps.Count != 0)
         {
            scrollBar.Maximum = bitmaps.Count - 1;
            currentFrame.Image = bitmaps[scrollBar.Value];
            frameCount.Text = string.Format("Image: {0}/{1}", scrollBar.Value + 1, scrollBar.Maximum + 1);
         }
         else
         {
            currentFrame.Image = new Bitmap(1, 1);
            frameCount.Text = string.Format("Image: {0}/{1}", 0, 0);
         }
      }

      public Editor(List<Bitmap> b)
      {
         InitializeComponent();
         bitmaps = b;
         UpdateUI();
      }

      private void RemoveStartToThis_Click(object sender, EventArgs e)
      {
         int l = scrollBar.Value;
         for (int i = 0; i <= l && bitmaps.Count > 0; i++)
         {
            bitmaps.RemoveAt(0);
         }
         UpdateUI();
      }

      private void RemoveFrame_Click(object sender, EventArgs e)
      {
			if (bitmaps.Count > 0)
			{
				bitmaps.RemoveAt(scrollBar.Value);
			}
         UpdateUI();
      }

      private void RemoveThisToEnd_Click(object sender, EventArgs e)
      {
			int l = bitmaps.Count - scrollBar.Value;
         for (int i = 0; i <= l && bitmaps.Count > 0; i++)
         {
            bitmaps.RemoveAt(bitmaps.Count - 1);
         }
         UpdateUI();
      }

      private void ScrollBar_Scroll(object sender, ScrollEventArgs e)
      {
         currentFrame.Image = bitmaps[scrollBar.Value];
         frameCount.Text = string.Format("Image: {0}/{1}", scrollBar.Value + 1, scrollBar.Maximum + 1);
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
