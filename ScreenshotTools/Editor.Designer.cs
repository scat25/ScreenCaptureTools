namespace ScreenshotTools
{
	partial class Editor
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
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Editor));
         this.scrollBar = new System.Windows.Forms.HScrollBar();
         this.currentFrame = new System.Windows.Forms.PictureBox();
         this.frameCount = new System.Windows.Forms.Label();
         this.removeFrame = new System.Windows.Forms.Button();
         this.removeThisToEnd = new System.Windows.Forms.Button();
         this.removeStartToThis = new System.Windows.Forms.Button();
         this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
         ((System.ComponentModel.ISupportInitialize)(this.currentFrame)).BeginInit();
         this.flowLayoutPanel1.SuspendLayout();
         this.SuspendLayout();
         // 
         // scrollBar
         // 
         this.scrollBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.scrollBar.LargeChange = 1;
         this.scrollBar.Location = new System.Drawing.Point(0, 515);
         this.scrollBar.Name = "scrollBar";
         this.scrollBar.Size = new System.Drawing.Size(683, 20);
         this.scrollBar.TabIndex = 1;
         this.scrollBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.ScrollBar_Scroll);
         // 
         // currentFrame
         // 
         this.currentFrame.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.currentFrame.BackColor = System.Drawing.SystemColors.Window;
         this.currentFrame.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this.currentFrame.Location = new System.Drawing.Point(0, 0);
         this.currentFrame.Name = "currentFrame";
         this.currentFrame.Size = new System.Drawing.Size(803, 483);
         this.currentFrame.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
         this.currentFrame.TabIndex = 2;
         this.currentFrame.TabStop = false;
         // 
         // frameCount
         // 
         this.frameCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
         this.frameCount.AutoSize = true;
         this.frameCount.Location = new System.Drawing.Point(689, 515);
         this.frameCount.Name = "frameCount";
         this.frameCount.Size = new System.Drawing.Size(55, 13);
         this.frameCount.TabIndex = 7;
         this.frameCount.Text = "Image: i/n";
         // 
         // removeFrame
         // 
         this.removeFrame.Anchor = System.Windows.Forms.AnchorStyles.None;
         this.removeFrame.Location = new System.Drawing.Point(149, 3);
         this.removeFrame.Name = "removeFrame";
         this.removeFrame.Size = new System.Drawing.Size(95, 23);
         this.removeFrame.TabIndex = 3;
         this.removeFrame.Text = "Remove current";
         this.removeFrame.UseVisualStyleBackColor = true;
         this.removeFrame.Click += new System.EventHandler(this.RemoveFrame_Click);
         // 
         // removeThisToEnd
         // 
         this.removeThisToEnd.Anchor = System.Windows.Forms.AnchorStyles.None;
         this.removeThisToEnd.Location = new System.Drawing.Point(250, 3);
         this.removeThisToEnd.Name = "removeThisToEnd";
         this.removeThisToEnd.Size = new System.Drawing.Size(140, 23);
         this.removeThisToEnd.TabIndex = 4;
         this.removeThisToEnd.Text = "Remove from current to end";
         this.removeThisToEnd.UseVisualStyleBackColor = true;
         this.removeThisToEnd.Click += new System.EventHandler(this.RemoveThisToEnd_Click);
         // 
         // removeStartToThis
         // 
         this.removeStartToThis.Anchor = System.Windows.Forms.AnchorStyles.None;
         this.removeStartToThis.Location = new System.Drawing.Point(3, 3);
         this.removeStartToThis.Name = "removeStartToThis";
         this.removeStartToThis.Size = new System.Drawing.Size(140, 23);
         this.removeStartToThis.TabIndex = 2;
         this.removeStartToThis.Text = "Remove from start to current";
         this.removeStartToThis.UseVisualStyleBackColor = true;
         this.removeStartToThis.Click += new System.EventHandler(this.RemoveStartToThis_Click);
         // 
         // flowLayoutPanel1
         // 
         this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.flowLayoutPanel1.Controls.Add(this.removeStartToThis);
         this.flowLayoutPanel1.Controls.Add(this.removeFrame);
         this.flowLayoutPanel1.Controls.Add(this.removeThisToEnd);
         this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 484);
         this.flowLayoutPanel1.Name = "flowLayoutPanel1";
         this.flowLayoutPanel1.Size = new System.Drawing.Size(804, 28);
         this.flowLayoutPanel1.TabIndex = 8;
         this.flowLayoutPanel1.WrapContents = false;
         // 
         // Editor
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(803, 535);
         this.Controls.Add(this.flowLayoutPanel1);
         this.Controls.Add(this.frameCount);
         this.Controls.Add(this.currentFrame);
         this.Controls.Add(this.scrollBar);
         this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
         this.MinimizeBox = false;
         this.MinimumSize = new System.Drawing.Size(450, 300);
         this.Name = "Editor";
         this.ShowInTaskbar = false;
         this.Text = "Editor";
         this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Editor_FormClosing);
         this.Load += new System.EventHandler(this.Editor_Load);
         ((System.ComponentModel.ISupportInitialize)(this.currentFrame)).EndInit();
         this.flowLayoutPanel1.ResumeLayout(false);
         this.ResumeLayout(false);
         this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.HScrollBar scrollBar;
		private System.Windows.Forms.PictureBox currentFrame;
		private System.Windows.Forms.Label frameCount;
		private System.Windows.Forms.Button removeFrame;
		private System.Windows.Forms.Button removeThisToEnd;
		private System.Windows.Forms.Button removeStartToThis;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
	}
}