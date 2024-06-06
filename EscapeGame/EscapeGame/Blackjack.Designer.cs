namespace EscapeGame
{
    partial class Blackjack
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
            this.GBDealer = new System.Windows.Forms.GroupBox();
            this.GBPlayer = new System.Windows.Forms.GroupBox();
            this.btnStand = new System.Windows.Forms.Button();
            this.btnhit = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // GBDealer
            // 
            this.GBDealer.BackColor = System.Drawing.SystemColors.Control;
            this.GBDealer.Location = new System.Drawing.Point(26, 37);
            this.GBDealer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GBDealer.Name = "GBDealer";
            this.GBDealer.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GBDealer.Size = new System.Drawing.Size(605, 181);
            this.GBDealer.TabIndex = 2;
            this.GBDealer.TabStop = false;
            this.GBDealer.Text = "Dealer";
            this.GBDealer.Visible = false;
            // 
            // GBPlayer
            // 
            this.GBPlayer.BackColor = System.Drawing.SystemColors.Control;
            this.GBPlayer.Location = new System.Drawing.Point(26, 326);
            this.GBPlayer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GBPlayer.Name = "GBPlayer";
            this.GBPlayer.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GBPlayer.Size = new System.Drawing.Size(605, 189);
            this.GBPlayer.TabIndex = 3;
            this.GBPlayer.TabStop = false;
            this.GBPlayer.Text = "Player";
            this.GBPlayer.Visible = false;
            // 
            // btnStand
            // 
            this.btnStand.Location = new System.Drawing.Point(823, 454);
            this.btnStand.Name = "btnStand";
            this.btnStand.Size = new System.Drawing.Size(112, 53);
            this.btnStand.TabIndex = 10;
            this.btnStand.Text = "결정";
            this.btnStand.UseVisualStyleBackColor = true;
            this.btnStand.Click += new System.EventHandler(this.btnStand_Click);
            // 
            // btnhit
            // 
            this.btnhit.Location = new System.Drawing.Point(823, 395);
            this.btnhit.Name = "btnhit";
            this.btnhit.Size = new System.Drawing.Size(112, 53);
            this.btnhit.TabIndex = 9;
            this.btnhit.Text = "뽑기";
            this.btnhit.UseVisualStyleBackColor = true;
            this.btnhit.Click += new System.EventHandler(this.btnhit_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(823, 336);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(112, 53);
            this.btnStart.TabIndex = 8;
            this.btnStart.Text = "시작";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // Blackjack
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 553);
            this.Controls.Add(this.btnStand);
            this.Controls.Add(this.btnhit);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.GBPlayer);
            this.Controls.Add(this.GBDealer);
            this.Name = "Blackjack";
            this.Text = "Blackjack";
            this.Load += new System.EventHandler(this.Game_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Game_Paint);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GBDealer;
        private System.Windows.Forms.GroupBox GBPlayer;
        private System.Windows.Forms.Button btnStand;
        private System.Windows.Forms.Button btnhit;
        private System.Windows.Forms.Button btnStart;
    }
}