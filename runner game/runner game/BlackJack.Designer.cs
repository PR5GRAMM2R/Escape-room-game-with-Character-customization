namespace runner_game
{
    partial class BlackJack
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
            this.btnStart = new System.Windows.Forms.Button();
            this.btnhit = new System.Windows.Forms.Button();
            this.btnStand = new System.Windows.Forms.Button();
            this.GBPlayer = new System.Windows.Forms.GroupBox();
            this.GBDealer = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(578, 210);
            this.btnStart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(98, 42);
            this.btnStart.TabIndex = 5;
            this.btnStart.Text = "시작";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click_1);
            // 
            // btnhit
            // 
            this.btnhit.Location = new System.Drawing.Point(578, 257);
            this.btnhit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnhit.Name = "btnhit";
            this.btnhit.Size = new System.Drawing.Size(98, 42);
            this.btnhit.TabIndex = 6;
            this.btnhit.Text = "뽑기";
            this.btnhit.UseVisualStyleBackColor = true;
            this.btnhit.Click += new System.EventHandler(this.btnhit_Click);
            // 
            // btnStand
            // 
            this.btnStand.Location = new System.Drawing.Point(578, 304);
            this.btnStand.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnStand.Name = "btnStand";
            this.btnStand.Size = new System.Drawing.Size(98, 42);
            this.btnStand.TabIndex = 7;
            this.btnStand.Text = "결정";
            this.btnStand.UseVisualStyleBackColor = true;
            this.btnStand.Click += new System.EventHandler(this.btnStand_Click);
            // 
            // GBPlayer
            // 
            this.GBPlayer.Location = new System.Drawing.Point(26, 199);
            this.GBPlayer.Name = "GBPlayer";
            this.GBPlayer.Size = new System.Drawing.Size(529, 151);
            this.GBPlayer.TabIndex = 2;
            this.GBPlayer.TabStop = false;
            this.GBPlayer.Text = "Player";
            // 
            // GBDealer
            // 
            this.GBDealer.Location = new System.Drawing.Point(26, 10);
            this.GBDealer.Name = "GBDealer";
            this.GBDealer.Size = new System.Drawing.Size(529, 145);
            this.GBDealer.TabIndex = 1;
            this.GBDealer.TabStop = false;
            this.GBDealer.Text = "Dealer";
            // 
            // BlackJack
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 362);
            this.Controls.Add(this.GBDealer);
            this.Controls.Add(this.GBPlayer);
            this.Controls.Add(this.btnStand);
            this.Controls.Add(this.btnhit);
            this.Controls.Add(this.btnStart);
            this.Name = "BlackJack";
            this.Text = "BlackJack";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnhit;
        private System.Windows.Forms.Button btnStand;
        private System.Windows.Forms.GroupBox GBPlayer;
        private System.Windows.Forms.GroupBox GBDealer;
    }
}