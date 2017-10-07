namespace ScreenCam
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
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
         this.CaptureArea = new System.Windows.Forms.Panel();
         this.ToolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
         this.ToolStrip1 = new System.Windows.Forms.ToolStrip();
         this.Record = new System.Windows.Forms.ToolStripSplitButton();
         this.CaptureCursor = new System.Windows.Forms.ToolStripMenuItem();
         this.HighlightCursor = new System.Windows.Forms.ToolStripMenuItem();
         this.ToolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
         this.Fps30 = new System.Windows.Forms.ToolStripMenuItem();
         this.Fps60 = new System.Windows.Forms.ToolStripMenuItem();
         this.Edit = new System.Windows.Forms.ToolStripButton();
         this.Save = new System.Windows.Forms.ToolStripButton();
         this.ToolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
         this.FramesText = new System.Windows.Forms.ToolStripLabel();
         this.FrameCount = new System.Windows.Forms.ToolStripLabel();
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
            this.Record,
            this.Edit,
            this.Save,
            this.ToolStripSeparator1,
            this.FramesText,
            this.FrameCount});
         this.ToolStrip1.Location = new System.Drawing.Point(0, 3);
         this.ToolStrip1.Name = "ToolStrip1";
         this.ToolStrip1.Padding = new System.Windows.Forms.Padding(0);
         this.ToolStrip1.Size = new System.Drawing.Size(48, 189);
         this.ToolStrip1.TabIndex = 0;
         this.ToolStrip1.TabStop = true;
         // 
         // Record
         // 
         this.Record.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
         this.Record.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CaptureCursor,
            this.HighlightCursor,
            this.ToolStripSeparator2,
            this.Fps30,
            this.Fps60});
         this.Record.Image = global::ScreenCam.Properties.Resources.StartRecording;
         this.Record.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
         this.Record.ImageTransparentColor = System.Drawing.Color.Magenta;
         this.Record.Name = "Record";
         this.Record.Size = new System.Drawing.Size(47, 36);
         this.Record.ButtonClick += new System.EventHandler(this.Record_Click);
         // 
         // CaptureCursor
         // 
         this.CaptureCursor.Checked = true;
         this.CaptureCursor.CheckOnClick = true;
         this.CaptureCursor.CheckState = System.Windows.Forms.CheckState.Checked;
         this.CaptureCursor.Name = "CaptureCursor";
         this.CaptureCursor.Size = new System.Drawing.Size(160, 22);
         this.CaptureCursor.Text = "Capture cursor";
         // 
         // HighlightCursor
         // 
         this.HighlightCursor.CheckOnClick = true;
         this.HighlightCursor.Name = "HighlightCursor";
         this.HighlightCursor.Size = new System.Drawing.Size(160, 22);
         this.HighlightCursor.Text = "Highlight cursor";
         // 
         // ToolStripSeparator2
         // 
         this.ToolStripSeparator2.Name = "ToolStripSeparator2";
         this.ToolStripSeparator2.Size = new System.Drawing.Size(157, 6);
         // 
         // Fps30
         // 
         this.Fps30.Checked = true;
         this.Fps30.CheckOnClick = true;
         this.Fps30.CheckState = System.Windows.Forms.CheckState.Checked;
         this.Fps30.Name = "Fps30";
         this.Fps30.Size = new System.Drawing.Size(160, 22);
         this.Fps30.Text = "30 FPS";
         this.Fps30.Click += new System.EventHandler(this.Fps30_Click);
         // 
         // Fps60
         // 
         this.Fps60.CheckOnClick = true;
         this.Fps60.Name = "Fps60";
         this.Fps60.Size = new System.Drawing.Size(160, 22);
         this.Fps60.Text = "60 FPS";
         this.Fps60.Click += new System.EventHandler(this.Fps60_Click);
         // 
         // Edit
         // 
         this.Edit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
         this.Edit.Image = global::ScreenCam.Properties.Resources.EditVideo;
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
         this.Save.Image = global::ScreenCam.Properties.Resources.Save;
         this.Save.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
         this.Save.ImageTransparentColor = System.Drawing.Color.Magenta;
         this.Save.Name = "Save";
         this.Save.Size = new System.Drawing.Size(47, 36);
         this.Save.Text = "Save";
         this.Save.Click += new System.EventHandler(this.Save_Click);
         // 
         // ToolStripSeparator1
         // 
         this.ToolStripSeparator1.Name = "ToolStripSeparator1";
         this.ToolStripSeparator1.Size = new System.Drawing.Size(47, 6);
         // 
         // FramesText
         // 
         this.FramesText.Name = "FramesText";
         this.FramesText.Size = new System.Drawing.Size(47, 15);
         this.FramesText.Text = "Frames:";
         // 
         // FrameCount
         // 
         this.FrameCount.Name = "FrameCount";
         this.FrameCount.Size = new System.Drawing.Size(47, 15);
         this.FrameCount.Text = "0";
         this.FrameCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
         this.Text = "ScreenCam";
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
		private System.Windows.Forms.ToolStripButton Edit;
		private System.Windows.Forms.ToolStripButton Save;
		private System.Windows.Forms.ToolStripSeparator ToolStripSeparator1;
		private System.Windows.Forms.ToolStripLabel FramesText;
		private System.Windows.Forms.ToolStripLabel FrameCount;
		private System.Windows.Forms.ToolStripSplitButton Record;
		private System.Windows.Forms.ToolStripMenuItem CaptureCursor;
		private System.Windows.Forms.ToolStripMenuItem HighlightCursor;
		private System.Windows.Forms.ToolStripSeparator ToolStripSeparator2;
		private System.Windows.Forms.ToolStripMenuItem Fps30;
		private System.Windows.Forms.ToolStripMenuItem Fps60;
	}
}

