namespace EscapeGame
{
    partial class Room2
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
            this.pbHint = new System.Windows.Forms.PictureBox();
            this.pbRunnerGameMachine = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbMainp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRunnerGameMachine)).BeginInit();
            this.SuspendLayout();
            // 
            // pbMainp
            // 
            this.pbMainp.BackColor = System.Drawing.Color.Blue;
            this.pbMainp.Location = new System.Drawing.Point(949, 247);
            this.pbMainp.Name = "pbMainp";
            this.pbMainp.Size = new System.Drawing.Size(32, 35);
            this.pbMainp.TabIndex = 3;
            this.pbMainp.TabStop = false;
            // 
            // pbPlayer
            // 
            this.pbPlayer.Image = global::EscapeGame.Properties.Resources.running;
            this.pbPlayer.Location = new System.Drawing.Point(903, 247);
            this.pbPlayer.Name = "pbPlayer";
            this.pbPlayer.Size = new System.Drawing.Size(40, 43);
            this.pbPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPlayer.TabIndex = 4;
            this.pbPlayer.TabStop = false;
            // 
            // pbHint
            // 
            this.pbHint.BackColor = System.Drawing.Color.Violet;
            this.pbHint.Location = new System.Drawing.Point(651, 0);
            this.pbHint.Name = "pbHint";
            this.pbHint.Size = new System.Drawing.Size(32, 35);
            this.pbHint.TabIndex = 6;
            this.pbHint.TabStop = false;
            // 
            // pbRunnerGameMachine
            // 
            this.pbRunnerGameMachine.BackColor = System.Drawing.Color.Green;
            this.pbRunnerGameMachine.Location = new System.Drawing.Point(304, 0);
            this.pbRunnerGameMachine.Name = "pbRunnerGameMachine";
            this.pbRunnerGameMachine.Size = new System.Drawing.Size(32, 35);
            this.pbRunnerGameMachine.TabIndex = 7;
            this.pbRunnerGameMachine.TabStop = false;
            // 
            // Room2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 553);
            this.Controls.Add(this.pbRunnerGameMachine);
            this.Controls.Add(this.pbHint);
            this.Controls.Add(this.pbPlayer);
            this.Controls.Add(this.pbMainp);
            this.Name = "Room2";
            this.Text = "Room2";
            ((System.ComponentModel.ISupportInitialize)(this.pbMainp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRunnerGameMachine)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbMainp;
        private System.Windows.Forms.PictureBox pbPlayer;
        private System.Windows.Forms.PictureBox pbHint;
        private System.Windows.Forms.PictureBox pbRunnerGameMachine;
    }
}