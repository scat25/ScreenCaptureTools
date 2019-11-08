namespace ScreenshotTools
{
	partial class MainWindow
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
         this.components = new System.ComponentModel.Container();
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
         this.CaptureArea = new System.Windows.Forms.Panel();
         this.ToolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
         this.ToolStrip1 = new System.Windows.Forms.ToolStrip();
         this.TakeScreenshot = new System.Windows.Forms.ToolStripSplitButton();
         this.NewScreenshotSeries = new System.Windows.Forms.ToolStripMenuItem();
         this.CaptureCursor = new System.Windows.Forms.ToolStripMenuItem();
         this.HighlightCursor = new System.Windows.Forms.ToolStripMenuItem();
         this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
         this.delay1Second = new System.Windows.Forms.ToolStripMenuItem();
         this.delay3Seconds = new System.Windows.Forms.ToolStripMenuItem();
         this.delay5Seconds = new System.Windows.Forms.ToolStripMenuItem();
         this.Edit = new System.Windows.Forms.ToolStripButton();
         this.Save = new System.Windows.Forms.ToolStripSplitButton();
         this.StoreHorizontalStitchedImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.StoreVerticalStitchedImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.ToolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
         this.ImagesText = new System.Windows.Forms.ToolStripLabel();
         this.ImagesCount = new System.Windows.Forms.ToolStripLabel();
         this.timer1 = new System.Windows.Forms.Timer(this.components);
         this.ToolStripContainer1.ContentPanel.SuspendLayout();
         this.ToolStripContainer1.RightToolStripPanel.SuspendLayout();
         this.ToolStripContainer1.SuspendLayout();
         this.ToolStrip1.SuspendLayout();
         this.SuspendLayout();
         // 
         // CaptureArea
         // 
         this.CaptureArea.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this.CaptureArea.Dock = System.Windows.Forms.DockStyle.Fill;
         this.CaptureArea.Location = new System.Drawing.Point(0, 0);
         this.CaptureArea.Margin = new System.Windows.Forms.Padding(0);
         this.CaptureArea.Name = "CaptureArea";
         this.CaptureArea.Size = new System.Drawing.Size(522, 237);
         this.CaptureArea.TabIndex = 1;
         // 
         // ToolStripContainer1
         // 
         this.ToolStripContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         // 
         // ToolStripContainer1.BottomToolStripPanel
         // 
         this.ToolStripContainer1.BottomToolStripPanel.BackColor = System.Drawing.SystemColors.Control;
         // 
         // ToolStripContainer1.ContentPanel
         // 
         this.ToolStripContainer1.ContentPanel.Controls.Add(this.CaptureArea);
         this.ToolStripContainer1.ContentPanel.Size = new System.Drawing.Size(522, 237);
         // 
         // ToolStripContainer1.LeftToolStripPanel
         // 
         this.ToolStripContainer1.LeftToolStripPanel.BackColor = System.Drawing.SystemColors.Control;
         this.ToolStripContainer1.Location = new System.Drawing.Point(0, 0);
         this.ToolStripContainer1.Name = "ToolStripContainer1";
         // 
         // ToolStripContainer1.RightToolStripPanel
         // 
         this.ToolStripContainer1.RightToolStripPanel.BackColor = System.Drawing.SystemColors.Control;
         this.ToolStripContainer1.RightToolStripPanel.Controls.Add(this.ToolStrip1);
         this.ToolStripContainer1.Size = new System.Drawing.Size(570, 262);
         this.ToolStripContainer1.TabIndex = 0;
         this.ToolStripContainer1.Text = "toolStripContainer1";
         // 
         // ToolStripContainer1.TopToolStripPanel
         // 
         this.ToolStripContainer1.TopToolStripPanel.BackColor = System.Drawing.SystemColors.Control;
         // 
         // ToolStrip1
         // 
         this.ToolStrip1.Dock = System.Windows.Forms.DockStyle.None;
         this.ToolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TakeScreenshot,
            this.Edit,
            this.Save,
            this.ToolStripSeparator1,
            this.ImagesText,
            this.ImagesCount});
         this.ToolStrip1.Location = new System.Drawing.Point(0, 3);
         this.ToolStrip1.Name = "ToolStrip1";
         this.ToolStrip1.Padding = new System.Windows.Forms.Padding(0);
         this.ToolStrip1.Size = new System.Drawing.Size(48, 170);
         this.ToolStrip1.TabIndex = 0;
         this.ToolStrip1.TabStop = true;
         // 
         // TakeScreenshot
         // 
         this.TakeScreenshot.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
         this.TakeScreenshot.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewScreenshotSeries,
            this.CaptureCursor,
            this.HighlightCursor,
            this.toolStripSeparator2,
            this.delay1Second,
            this.delay3Seconds,
            this.delay5Seconds});
         this.TakeScreenshot.Image = global::ScreenshotTools.Properties.Resources.AddScreenshot;
         this.TakeScreenshot.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
         this.TakeScreenshot.ImageTransparentColor = System.Drawing.Color.Magenta;
         this.TakeScreenshot.Name = "TakeScreenshot";
         this.TakeScreenshot.Size = new System.Drawing.Size(47, 36);
         this.TakeScreenshot.ButtonClick += new System.EventHandler(this.TakeScreenshot_Click);
         // 
         // NewScreenshotSeries
         // 
         this.NewScreenshotSeries.Name = "NewScreenshotSeries";
         this.NewScreenshotSeries.Size = new System.Drawing.Size(190, 22);
         this.NewScreenshotSeries.Text = "New screenshot series";
         this.NewScreenshotSeries.Click += new System.EventHandler(this.NewScreenshotSeries_Click);
         // 
         // CaptureCursor
         // 
         this.CaptureCursor.Checked = true;
         this.CaptureCursor.CheckOnClick = true;
         this.CaptureCursor.CheckState = System.Windows.Forms.CheckState.Checked;
         this.CaptureCursor.Name = "CaptureCursor";
         this.CaptureCursor.Size = new System.Drawing.Size(190, 22);
         this.CaptureCursor.Text = "Capture cursor";
         // 
         // HighlightCursor
         // 
         this.HighlightCursor.CheckOnClick = true;
         this.HighlightCursor.Name = "HighlightCursor";
         this.HighlightCursor.Size = new System.Drawing.Size(190, 22);
         this.HighlightCursor.Text = "Highlight cursor";
         // 
         // toolStripSeparator2
         // 
         this.toolStripSeparator2.Name = "toolStripSeparator2";
         this.toolStripSeparator2.Size = new System.Drawing.Size(187, 6);
         // 
         // delay1Second
         // 
         this.delay1Second.CheckOnClick = true;
         this.delay1Second.Name = "delay1Second";
         this.delay1Second.Size = new System.Drawing.Size(190, 22);
         this.delay1Second.Text = "Delay 1 second";
         this.delay1Second.CheckedChanged += new System.EventHandler(this.delay1Second_CheckedChanged);
         // 
         // delay3Seconds
         // 
         this.delay3Seconds.CheckOnClick = true;
         this.delay3Seconds.Name = "delay3Seconds";
         this.delay3Seconds.Size = new System.Drawing.Size(190, 22);
         this.delay3Seconds.Text = "Delay 3 seconds";
         this.delay3Seconds.CheckedChanged += new System.EventHandler(this.delay3Seconds_CheckedChanged);
         // 
         // delay5Seconds
         // 
         this.delay5Seconds.CheckOnClick = true;
         this.delay5Seconds.Name = "delay5Seconds";
         this.delay5Seconds.Size = new System.Drawing.Size(190, 22);
         this.delay5Seconds.Text = "Delay 5 seconds";
         this.delay5Seconds.CheckedChanged += new System.EventHandler(this.delay5Seconds_CheckedChanged);
         // 
         // Edit
         // 
         this.Edit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
         this.Edit.Image = global::ScreenshotTools.Properties.Resources.EditVideo;
         this.Edit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
         this.Edit.ImageTransparentColor = System.Drawing.Color.Magenta;
         this.Edit.Name = "Edit";
         this.Edit.Size = new System.Drawing.Size(47, 36);
         this.Edit.Text = "Edit";
         this.Edit.Click += new System.EventHandler(this.Edit_Click);
         // 
         // Save
         // 
         this.Save.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
         this.Save.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StoreHorizontalStitchedImageToolStripMenuItem,
            this.StoreVerticalStitchedImageToolStripMenuItem});
         this.Save.Image = global::ScreenshotTools.Properties.Resources.Save;
         this.Save.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
         this.Save.ImageTransparentColor = System.Drawing.Color.Magenta;
         this.Save.Name = "Save";
         this.Save.Size = new System.Drawing.Size(47, 36);
         this.Save.Text = "Save";
         this.Save.ButtonClick += new System.EventHandler(this.Save_Click);
         // 
         // StoreHorizontalStitchedImageToolStripMenuItem
         // 
         this.StoreHorizontalStitchedImageToolStripMenuItem.Name = "StoreHorizontalStitchedImageToolStripMenuItem";
         this.StoreHorizontalStitchedImageToolStripMenuItem.Size = new System.Drawing.Size(238, 22);
         this.StoreHorizontalStitchedImageToolStripMenuItem.Text = "Store horizontal stitched image";
         this.StoreHorizontalStitchedImageToolStripMenuItem.Click += new System.EventHandler(this.StoreHorizontalStitchedImageToolStripMenuItem_Click);
         // 
         // StoreVerticalStitchedImageToolStripMenuItem
         // 
         this.StoreVerticalStitchedImageToolStripMenuItem.Name = "StoreVerticalStitchedImageToolStripMenuItem";
         this.StoreVerticalStitchedImageToolStripMenuItem.Size = new System.Drawing.Size(238, 22);
         this.StoreVerticalStitchedImageToolStripMenuItem.Text = "Store vertical stitched image";
         this.StoreVerticalStitchedImageToolStripMenuItem.Click += new System.EventHandler(this.StoreVerticalStitchedImageToolStripMenuItem_Click);
         // 
         // ToolStripSeparator1
         // 
         this.ToolStripSeparator1.Name = "ToolStripSeparator1";
         this.ToolStripSeparator1.Size = new System.Drawing.Size(47, 6);
         // 
         // ImagesText
         // 
         this.ImagesText.Name = "ImagesText";
         this.ImagesText.Size = new System.Drawing.Size(47, 15);
         this.ImagesText.Text = "Images:";
         // 
         // ImagesCount
         // 
         this.ImagesCount.Name = "ImagesCount";
         this.ImagesCount.Size = new System.Drawing.Size(47, 15);
         this.ImagesCount.Text = "0";
         this.ImagesCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
         // 
         // timer1
         // 
         this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
         // 
         // MainWindow
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.BackColor = System.Drawing.Color.Fuchsia;
         this.ClientSize = new System.Drawing.Size(570, 262);
         this.Controls.Add(this.ToolStripContainer1);
         this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
         this.MaximizeBox = false;
         this.Name = "MainWindow";
         this.Text = "ScreenshotTools";
         this.TopMost = true;
         this.TransparencyKey = System.Drawing.Color.Fuchsia;
         this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_FormClosing);
         this.Load += new System.EventHandler(this.MainWindow_Load);
         this.Resize += new System.EventHandler(this.MainWindow_Resize);
         this.ToolStripContainer1.ContentPanel.ResumeLayout(false);
         this.ToolStripContainer1.RightToolStripPanel.ResumeLayout(false);
         this.ToolStripContainer1.RightToolStripPanel.PerformLayout();
         this.ToolStripContainer1.ResumeLayout(false);
         this.ToolStripContainer1.PerformLayout();
         this.ToolStrip1.ResumeLayout(false);
         this.ToolStrip1.PerformLayout();
         this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Panel CaptureArea;
		private System.Windows.Forms.ToolStripContainer ToolStripContainer1;
		private System.Windows.Forms.ToolStrip ToolStrip1;
		private System.Windows.Forms.ToolStripSeparator ToolStripSeparator1;
		private System.Windows.Forms.ToolStripLabel ImagesText;
		private System.Windows.Forms.ToolStripLabel ImagesCount;
		private System.Windows.Forms.ToolStripSplitButton TakeScreenshot;
		private System.Windows.Forms.ToolStripMenuItem CaptureCursor;
		private System.Windows.Forms.ToolStripMenuItem HighlightCursor;
      private System.Windows.Forms.ToolStripMenuItem NewScreenshotSeries;
      private System.Windows.Forms.ToolStripSplitButton Save;
      private System.Windows.Forms.ToolStripMenuItem StoreHorizontalStitchedImageToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem StoreVerticalStitchedImageToolStripMenuItem;
      private System.Windows.Forms.ToolStripButton Edit;
      private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
      private System.Windows.Forms.ToolStripMenuItem delay1Second;
      private System.Windows.Forms.ToolStripMenuItem delay3Seconds;
      private System.Windows.Forms.ToolStripMenuItem delay5Seconds;
      private System.Windows.Forms.Timer timer1;
   }
}

