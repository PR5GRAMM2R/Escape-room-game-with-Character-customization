namespace EscapeGame
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.pbPlayer = new System.Windows.Forms.PictureBox();
            this.pbRoom1p = new System.Windows.Forms.PictureBox();
            this.pbRoom2p = new System.Windows.Forms.PictureBox();
            this.pbRoom3p = new System.Windows.Forms.PictureBox();
            this.pbEscape = new System.Windows.Forms.PictureBox();
            this.pbRoom4p = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRoom1p)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRoom2p)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRoom3p)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEscape)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRoom4p)).BeginInit();
            this.SuspendLayout();
            // 
            // pbPlayer
            // 
            this.pbPlayer.Image = global::EscapeGame.Properties.Resources.running;
            this.pbPlayer.Location = new System.Drawing.Point(411, 198);
            this.pbPlayer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbPlayer.Name = "pbPlayer";
            this.pbPlayer.Size = new System.Drawing.Size(35, 34);
            this.pbPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPlayer.TabIndex = 0;
            this.pbPlayer.TabStop = false;
            // 
            // pbRoom1p
            // 
            this.pbRoom1p.BackColor = System.Drawing.Color.Blue;
            this.pbRoom1p.Location = new System.Drawing.Point(831, 204);
            this.pbRoom1p.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbRoom1p.Name = "pbRoom1p";
            this.pbRoom1p.Size = new System.Drawing.Size(28, 28);
            this.pbRoom1p.TabIndex = 1;
            this.pbRoom1p.TabStop = false;
            // 
            // pbRoom2p
            // 
            this.pbRoom2p.BackColor = System.Drawing.Color.Blue;
            this.pbRoom2p.Location = new System.Drawing.Point(0, 204);
            this.pbRoom2p.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbRoom2p.Name = "pbRoom2p";
            this.pbRoom2p.Size = new System.Drawing.Size(28, 28);
            this.pbRoom2p.TabIndex = 2;
            this.pbRoom2p.TabStop = false;
            // 
            // pbRoom3p
            // 
            this.pbRoom3p.BackColor = System.Drawing.Color.Blue;
            this.pbRoom3p.Location = new System.Drawing.Point(294, -2);
            this.pbRoom3p.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbRoom3p.Name = "pbRoom3p";
            this.pbRoom3p.Size = new System.Drawing.Size(28, 28);
            this.pbRoom3p.TabIndex = 3;
            this.pbRoom3p.TabStop = false;
            // 
            // pbEscape
            // 
            this.pbEscape.BackColor = System.Drawing.Color.Blue;
            this.pbEscape.Location = new System.Drawing.Point(411, 415);
            this.pbEscape.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbEscape.Name = "pbEscape";
            this.pbEscape.Size = new System.Drawing.Size(28, 28);
            this.pbEscape.TabIndex = 4;
            this.pbEscape.TabStop = false;
            // 
            // pbRoom4p
            // 
            this.pbRoom4p.BackColor = System.Drawing.Color.Blue;
            this.pbRoom4p.Location = new System.Drawing.Point(542, -2);
            this.pbRoom4p.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbRoom4p.Name = "pbRoom4p";
            this.pbRoom4p.Size = new System.Drawing.Size(28, 28);
            this.pbRoom4p.TabIndex = 8;
            this.pbRoom4p.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 442);
            this.Controls.Add(this.pbRoom4p);
            this.Controls.Add(this.pbEscape);
            this.Controls.Add(this.pbRoom3p);
            this.Controls.Add(this.pbRoom2p);
            this.Controls.Add(this.pbPlayer);
            this.Controls.Add(this.pbRoom1p);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "d";
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRoom1p)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRoom2p)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRoom3p)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEscape)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRoom4p)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbPlayer;
        private System.Windows.Forms.PictureBox pbRoom1p;
        private System.Windows.Forms.PictureBox pbRoom2p;
        private System.Windows.Forms.PictureBox pbRoom3p;
        private System.Windows.Forms.PictureBox pbEscape;
        private System.Windows.Forms.PictureBox pbRoom4p;
    }
}

