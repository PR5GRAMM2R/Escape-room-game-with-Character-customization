namespace runner_game
{
    partial class mazeForm
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
            this.user = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.user)).BeginInit();
            this.SuspendLayout();
            // 
            // user
            // 
            this.user.Image = global::runner_game.Properties.Resources.running;
            this.user.Location = new System.Drawing.Point(403, 319);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(39, 55);
            this.user.TabIndex = 0;
            this.user.TabStop = false;
            // 
            // mazeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(855, 539);
            this.Controls.Add(this.user);
            this.Name = "mazeForm";
            this.Text = "mazeForm";
            ((System.ComponentModel.ISupportInitialize)(this.user)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox user;
    }
}