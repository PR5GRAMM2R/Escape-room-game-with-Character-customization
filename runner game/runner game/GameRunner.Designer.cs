namespace runner_game
{
    partial class GameRunner
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
            this.lblScore = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pbObstacle2 = new System.Windows.Forms.PictureBox();
            this.pbObstacle1 = new System.Windows.Forms.PictureBox();
            this.pbRunner = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbObstacle2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbObstacle1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRunner)).BeginInit();
            this.SuspendLayout();
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("맑은 고딕", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblScore.Location = new System.Drawing.Point(13, 9);
            this.lblScore.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(86, 31);
            this.lblScore.TabIndex = 2;
            this.lblScore.Text = "점수: 0";
            // 
            // gameTimer
            // 
            this.gameTimer.Interval = 17;
            this.gameTimer.Tick += new System.EventHandler(this.GameTimerEvent);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.Location = new System.Drawing.Point(-16, 472);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1101, 58);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // pbObstacle2
            // 
            this.pbObstacle2.Image = global::runner_game.Properties.Resources.obstacle_2;
            this.pbObstacle2.Location = new System.Drawing.Point(847, 435);
            this.pbObstacle2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pbObstacle2.Name = "pbObstacle2";
            this.pbObstacle2.Size = new System.Drawing.Size(32, 33);
            this.pbObstacle2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbObstacle2.TabIndex = 4;
            this.pbObstacle2.TabStop = false;
            this.pbObstacle2.Tag = "obstacle";
            // 
            // pbObstacle1
            // 
            this.pbObstacle1.Image = global::runner_game.Properties.Resources.obstacle_1;
            this.pbObstacle1.Location = new System.Drawing.Point(700, 420);
            this.pbObstacle1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pbObstacle1.Name = "pbObstacle1";
            this.pbObstacle1.Size = new System.Drawing.Size(23, 46);
            this.pbObstacle1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbObstacle1.TabIndex = 5;
            this.pbObstacle1.TabStop = false;
            this.pbObstacle1.Tag = "obstacle";
            // 
            // pbRunner
            // 
            this.pbRunner.BackColor = System.Drawing.SystemColors.Control;
            this.pbRunner.Image = global::runner_game.Properties.Resources.running;
            this.pbRunner.Location = new System.Drawing.Point(175, 338);
            this.pbRunner.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pbRunner.Name = "pbRunner";
            this.pbRunner.Size = new System.Drawing.Size(40, 43);
            this.pbRunner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbRunner.TabIndex = 6;
            this.pbRunner.TabStop = false;
            // 
            // GameRunner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1087, 527);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pbRunner);
            this.Controls.Add(this.pbObstacle1);
            this.Controls.Add(this.pbObstacle2);
            this.Controls.Add(this.lblScore);
            this.Name = "GameRunner";
            this.Text = "GameRunner";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyisdown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyisup);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbObstacle2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbObstacle1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRunner)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pbObstacle2;
        private System.Windows.Forms.PictureBox pbObstacle1;
        private System.Windows.Forms.PictureBox pbRunner;
    }
}