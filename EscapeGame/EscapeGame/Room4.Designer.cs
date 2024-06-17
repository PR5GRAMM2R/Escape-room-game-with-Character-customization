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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Room4));
            this.pbKeyBox = new System.Windows.Forms.PictureBox();
            this.pbQ3 = new System.Windows.Forms.PictureBox();
            this.pbQ2 = new System.Windows.Forms.PictureBox();
            this.pbQ1 = new System.Windows.Forms.PictureBox();
            this.pbPlayer = new System.Windows.Forms.PictureBox();
            this.pbMainp = new System.Windows.Forms.PictureBox();
            this.tmrImage = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbKeyBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbQ3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbQ2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbQ1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMainp)).BeginInit();
            this.SuspendLayout();
            // 
            // pbKeyBox
            // 
            this.pbKeyBox.BackColor = System.Drawing.Color.Crimson;
            this.pbKeyBox.BackgroundImage = global::EscapeGame.Properties.Resources.BGs;
            this.pbKeyBox.Image = global::EscapeGame.Properties.Resources.금고1;
            this.pbKeyBox.Location = new System.Drawing.Point(819, -1);
            this.pbKeyBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbKeyBox.Name = "pbKeyBox";
            this.pbKeyBox.Size = new System.Drawing.Size(30, 30);
            this.pbKeyBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbKeyBox.TabIndex = 15;
            this.pbKeyBox.TabStop = false;
            // 
            // pbQ3
            // 
            this.pbQ3.BackColor = System.Drawing.Color.Violet;
            this.pbQ3.BackgroundImage = global::EscapeGame.Properties.Resources.BGs;
            this.pbQ3.Image = global::EscapeGame.Properties.Resources.팻말1;
            this.pbQ3.Location = new System.Drawing.Point(621, -1);
            this.pbQ3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbQ3.Name = "pbQ3";
            this.pbQ3.Size = new System.Drawing.Size(32, 33);
            this.pbQ3.TabIndex = 11;
            this.pbQ3.TabStop = false;
            // 
            // pbQ2
            // 
            this.pbQ2.BackColor = System.Drawing.Color.Violet;
            this.pbQ2.BackgroundImage = global::EscapeGame.Properties.Resources.BGs;
            this.pbQ2.Image = global::EscapeGame.Properties.Resources.팻말1;
            this.pbQ2.Location = new System.Drawing.Point(337, -1);
            this.pbQ2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbQ2.Name = "pbQ2";
            this.pbQ2.Size = new System.Drawing.Size(33, 33);
            this.pbQ2.TabIndex = 10;
            this.pbQ2.TabStop = false;
            // 
            // pbQ1
            // 
            this.pbQ1.BackColor = System.Drawing.Color.Violet;
            this.pbQ1.BackgroundImage = global::EscapeGame.Properties.Resources.BGs;
            this.pbQ1.Image = global::EscapeGame.Properties.Resources.팻말1;
            this.pbQ1.Location = new System.Drawing.Point(71, -1);
            this.pbQ1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbQ1.Name = "pbQ1";
            this.pbQ1.Size = new System.Drawing.Size(33, 33);
            this.pbQ1.TabIndex = 9;
            this.pbQ1.TabStop = false;
            // 
            // pbPlayer
            // 
            this.pbPlayer.Location = new System.Drawing.Point(478, 320);
            this.pbPlayer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbPlayer.Name = "pbPlayer";
            this.pbPlayer.Size = new System.Drawing.Size(73, 80);
            this.pbPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPlayer.TabIndex = 8;
            this.pbPlayer.TabStop = false;
            this.pbPlayer.Paint += new System.Windows.Forms.PaintEventHandler(this.pbPlayer_Paint);
            // 
            // pbMainp
            // 
            this.pbMainp.BackColor = System.Drawing.Color.Blue;
            this.pbMainp.BackgroundImage = global::EscapeGame.Properties.Resources.BG;
            this.pbMainp.Image = ((System.Drawing.Image)(resources.GetObject("pbMainp.Image")));
            this.pbMainp.Location = new System.Drawing.Point(442, 405);
            this.pbMainp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbMainp.Name = "pbMainp";
            this.pbMainp.Size = new System.Drawing.Size(138, 134);
            this.pbMainp.TabIndex = 7;
            this.pbMainp.TabStop = false;
            // 
            // tmrImage
            // 
            this.tmrImage.Tick += new System.EventHandler(this.tmrImage_Tick);
            // 
            // Room4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::EscapeGame.Properties.Resources.BG;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(982, 552);
            this.Controls.Add(this.pbKeyBox);
            this.Controls.Add(this.pbQ3);
            this.Controls.Add(this.pbQ2);
            this.Controls.Add(this.pbQ1);
            this.Controls.Add(this.pbPlayer);
            this.Controls.Add(this.pbMainp);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Room4";
            this.Text = "Room4";
            ((System.ComponentModel.ISupportInitialize)(this.pbKeyBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbQ3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbQ2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbQ1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMainp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbMainp;
        private System.Windows.Forms.PictureBox pbPlayer;
        private System.Windows.Forms.PictureBox pbQ1;
        private System.Windows.Forms.PictureBox pbQ2;
        private System.Windows.Forms.PictureBox pbQ3;
        private System.Windows.Forms.PictureBox pbKeyBox;
        private System.Windows.Forms.Timer tmrImage;
    }
}