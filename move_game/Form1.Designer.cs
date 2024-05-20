namespace move_game
{
    partial class main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            floor = new PictureBox();
            player = new PictureBox();
            npc1 = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)floor).BeginInit();
            ((System.ComponentModel.ISupportInitialize)player).BeginInit();
            ((System.ComponentModel.ISupportInitialize)npc1).BeginInit();
            SuspendLayout();
            // 
            // floor
            // 
            floor.BackColor = Color.Black;
            floor.Location = new Point(-2, 428);
            floor.Name = "floor";
            floor.Size = new Size(803, 25);
            floor.TabIndex = 0;
            floor.TabStop = false;
            // 
            // player
            // 
            player.Image = Properties.Resources.running;
            player.Location = new Point(106, 372);
            player.Name = "player";
            player.Size = new Size(45, 50);
            player.TabIndex = 1;
            player.TabStop = false;
            player.PreviewKeyDown += player_PreviewKeyDown;
            // 
            // npc1
            // 
            npc1.Image = Properties.Resources.obstacle_1;
            npc1.Location = new Point(378, 372);
            npc1.Name = "npc1";
            npc1.Size = new Size(28, 50);
            npc1.TabIndex = 2;
            npc1.TabStop = false;
            npc1.Tag = "obstacle";
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 20;
            timer1.Tick += timer1_Tick;
            // 
            // main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(npc1);
            Controls.Add(player);
            Controls.Add(floor);
            IsMdiContainer = true;
            Name = "main";
            Text = "Form1";
            KeyDown += Form1_KeyDown;
            KeyUp += Form1_KeyUp;
            ((System.ComponentModel.ISupportInitialize)floor).EndInit();
            ((System.ComponentModel.ISupportInitialize)player).EndInit();
            ((System.ComponentModel.ISupportInitialize)npc1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox floor;
        private PictureBox player;
        private PictureBox npc1;
        private System.Windows.Forms.Timer timer1;
    }
}
