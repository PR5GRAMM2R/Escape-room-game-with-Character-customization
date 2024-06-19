namespace EscapeGame
{
    partial class Room1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Room1));
            this.pbPlayer = new System.Windows.Forms.PictureBox();
            this.pbMainp = new System.Windows.Forms.PictureBox();
            this.pbRunnerGameMachine = new System.Windows.Forms.PictureBox();
            this.pbHint = new System.Windows.Forms.PictureBox();
            this.tmrImage2 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMainp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRunnerGameMachine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHint)).BeginInit();
            this.SuspendLayout();
            // 
            // pbPlayer
            // 
            this.pbPlayer.Location = new System.Drawing.Point(236, 292);
            this.pbPlayer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pbPlayer.Name = "pbPlayer";
            this.pbPlayer.Size = new System.Drawing.Size(91, 96);
            this.pbPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPlayer.TabIndex = 3;
            this.pbPlayer.TabStop = false;
            this.pbPlayer.Paint += new System.Windows.Forms.PaintEventHandler(this.pbPlayer_Paint);
            // 
            // pbMainp
            // 
            this.pbMainp.BackColor = System.Drawing.Color.Blue;
            this.pbMainp.BackgroundImage = global::EscapeGame.Properties.Resources.BGs;
            this.pbMainp.Image = ((System.Drawing.Image)(resources.GetObject("pbMainp.Image")));
            this.pbMainp.Location = new System.Drawing.Point(14, 268);
            this.pbMainp.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pbMainp.Name = "pbMainp";
            this.pbMainp.Size = new System.Drawing.Size(150, 100);
            this.pbMainp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbMainp.TabIndex = 2;
            this.pbMainp.TabStop = false;
            // 
            // pbRunnerGameMachine
            // 
            this.pbRunnerGameMachine.BackColor = System.Drawing.Color.White;
            this.pbRunnerGameMachine.BackgroundImage = global::EscapeGame.Properties.Resources.BGs;
            this.pbRunnerGameMachine.Image = global::EscapeGame.Properties.Resources.오른쪽_오락기2;
            this.pbRunnerGameMachine.Location = new System.Drawing.Point(1164, 196);
            this.pbRunnerGameMachine.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pbRunnerGameMachine.Name = "pbRunnerGameMachine";
            this.pbRunnerGameMachine.Size = new System.Drawing.Size(50, 70);
            this.pbRunnerGameMachine.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbRunnerGameMachine.TabIndex = 4;
            this.pbRunnerGameMachine.TabStop = false;
            // 
            // pbHint
            // 
            this.pbHint.BackColor = System.Drawing.Color.Violet;
            this.pbHint.BackgroundImage = global::EscapeGame.Properties.Resources.BGs;
            this.pbHint.Image = global::EscapeGame.Properties.Resources.팻말1;
            this.pbHint.Location = new System.Drawing.Point(1173, 314);
            this.pbHint.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pbHint.Name = "pbHint";
            this.pbHint.Size = new System.Drawing.Size(40, 42);
            this.pbHint.TabIndex = 5;
            this.pbHint.TabStop = false;
            // 
            // tmrImage2
            // 
            this.tmrImage2.Tick += new System.EventHandler(this.tmrImage2_Tick);
            // 
            // Room1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::EscapeGame.Properties.Resources.BG;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1227, 663);
            this.Controls.Add(this.pbHint);
            this.Controls.Add(this.pbRunnerGameMachine);
            this.Controls.Add(this.pbPlayer);
            this.Controls.Add(this.pbMainp);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Room1";
            this.Text = "room1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Room1_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMainp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRunnerGameMachine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHint)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbMainp;
        private System.Windows.Forms.PictureBox pbPlayer;
        private System.Windows.Forms.PictureBox pbRunnerGameMachine;
        private System.Windows.Forms.PictureBox pbHint;
        private System.Windows.Forms.Timer tmrImage2;
    }
}