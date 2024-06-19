namespace EscapeGame
{
    partial class PreviewForm
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
            this.btnBack = new System.Windows.Forms.Button();
            this.lblCurrentFrameNum = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.pbxPreviewFrame = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPreviewFrame)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnBack.Location = new System.Drawing.Point(162, 440);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(136, 43);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblCurrentFrameNum
            // 
            this.lblCurrentFrameNum.AutoSize = true;
            this.lblCurrentFrameNum.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblCurrentFrameNum.Location = new System.Drawing.Point(205, 41);
            this.lblCurrentFrameNum.Name = "lblCurrentFrameNum";
            this.lblCurrentFrameNum.Size = new System.Drawing.Size(60, 21);
            this.lblCurrentFrameNum.TabIndex = 3;
            this.lblCurrentFrameNum.Text = "0 / 0";
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // pbxPreviewFrame
            // 
            this.pbxPreviewFrame.Location = new System.Drawing.Point(74, 79);
            this.pbxPreviewFrame.Name = "pbxPreviewFrame";
            this.pbxPreviewFrame.Size = new System.Drawing.Size(320, 320);
            this.pbxPreviewFrame.TabIndex = 1;
            this.pbxPreviewFrame.TabStop = false;
            this.pbxPreviewFrame.Paint += new System.Windows.Forms.PaintEventHandler(this.pbxPreviewFrame_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(74, 100);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(0, 0);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // PreviewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 523);
            this.Controls.Add(this.lblCurrentFrameNum);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.pbxPreviewFrame);
            this.Controls.Add(this.pictureBox1);
            this.Name = "PreviewForm";
            this.Text = "Preview";
            ((System.ComponentModel.ISupportInitialize)(this.pbxPreviewFrame)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pbxPreviewFrame;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblCurrentFrameNum;
        private System.Windows.Forms.Timer timer;
    }
}