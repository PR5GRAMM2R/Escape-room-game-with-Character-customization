namespace EscapeGame
{
    partial class Room4
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
            this.pbMainp = new System.Windows.Forms.PictureBox();
            this.pbPlayer = new System.Windows.Forms.PictureBox();
            this.pbQ1 = new System.Windows.Forms.PictureBox();
            this.pbQ2 = new System.Windows.Forms.PictureBox();
            this.pbQ3 = new System.Windows.Forms.PictureBox();
            this.pbKeyBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbMainp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbQ1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbQ2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbQ3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbKeyBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pbMainp
            // 
            this.pbMainp.BackColor = System.Drawing.Color.Blue;
            this.pbMainp.Location = new System.Drawing.Point(470, 518);
            this.pbMainp.Name = "pbMainp";
            this.pbMainp.Size = new System.Drawing.Size(32, 35);
            this.pbMainp.TabIndex = 7;
            this.pbMainp.TabStop = false;
            // 
            // pbPlayer
            // 
            this.pbPlayer.Image = global::EscapeGame.Properties.Resources.running;
            this.pbPlayer.Location = new System.Drawing.Point(470, 469);
            this.pbPlayer.Name = "pbPlayer";
            this.pbPlayer.Size = new System.Drawing.Size(40, 43);
            this.pbPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPlayer.TabIndex = 8;
            this.pbPlayer.TabStop = false;
            // 
            // pbQ1
            // 
            this.pbQ1.BackColor = System.Drawing.Color.Violet;
            this.pbQ1.Location = new System.Drawing.Point(67, -1);
            this.pbQ1.Name = "pbQ1";
            this.pbQ1.Size = new System.Drawing.Size(32, 35);
            this.pbQ1.TabIndex = 9;
            this.pbQ1.TabStop = false;
            // 
            // pbQ2
            // 
            this.pbQ2.BackColor = System.Drawing.Color.Violet;
            this.pbQ2.Location = new System.Drawing.Point(338, -1);
            this.pbQ2.Name = "pbQ2";
            this.pbQ2.Size = new System.Drawing.Size(32, 35);
            this.pbQ2.TabIndex = 10;
            this.pbQ2.TabStop = false;
            // 
            // pbQ3
            // 
            this.pbQ3.BackColor = System.Drawing.Color.Violet;
            this.pbQ3.Location = new System.Drawing.Point(610, -1);
            this.pbQ3.Name = "pbQ3";
            this.pbQ3.Size = new System.Drawing.Size(32, 35);
            this.pbQ3.TabIndex = 11;
            this.pbQ3.TabStop = false;
            // 
            // pbKeyBox
            // 
            this.pbKeyBox.BackColor = System.Drawing.Color.Crimson;
            this.pbKeyBox.Location = new System.Drawing.Point(858, -1);
            this.pbKeyBox.Name = "pbKeyBox";
            this.pbKeyBox.Size = new System.Drawing.Size(32, 35);
            this.pbKeyBox.TabIndex = 15;
            this.pbKeyBox.TabStop = false;
            // 
            // Room4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 553);
            this.Controls.Add(this.pbKeyBox);
            this.Controls.Add(this.pbQ3);
            this.Controls.Add(this.pbQ2);
            this.Controls.Add(this.pbQ1);
            this.Controls.Add(this.pbPlayer);
            this.Controls.Add(this.pbMainp);
            this.Name = "Room4";
            this.Text = "Room4";
            ((System.ComponentModel.ISupportInitialize)(this.pbMainp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbQ1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbQ2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbQ3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbKeyBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbMainp;
        private System.Windows.Forms.PictureBox pbPlayer;
        private System.Windows.Forms.PictureBox pbQ1;
        private System.Windows.Forms.PictureBox pbQ2;
        private System.Windows.Forms.PictureBox pbQ3;
        private System.Windows.Forms.PictureBox pbKeyBox;
    }
}