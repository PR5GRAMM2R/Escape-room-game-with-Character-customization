namespace EscapeGame
{
    partial class MainGameMenu
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnCharacter = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(583, 97);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(256, 284);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnStart
            // 
            this.btnStart.BackgroundImage = global::EscapeGame.Properties.Resources.BG;
            this.btnStart.Font = new System.Drawing.Font("한컴산뜻돋움", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnStart.ForeColor = System.Drawing.Color.Orange;
            this.btnStart.Image = global::EscapeGame.Properties.Resources.판자_위;
            this.btnStart.Location = new System.Drawing.Point(322, 147);
            this.btnStart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(203, 116);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "                            시작하기";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnCharacter
            // 
            this.btnCharacter.BackgroundImage = global::EscapeGame.Properties.Resources.BG;
            this.btnCharacter.Font = new System.Drawing.Font("한컴산뜻돋움", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnCharacter.ForeColor = System.Drawing.Color.Orange;
            this.btnCharacter.Image = global::EscapeGame.Properties.Resources.판자_중간;
            this.btnCharacter.Location = new System.Drawing.Point(322, 267);
            this.btnCharacter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCharacter.Name = "btnCharacter";
            this.btnCharacter.Size = new System.Drawing.Size(200, 72);
            this.btnCharacter.TabIndex = 2;
            this.btnCharacter.Text = "캐릭터 선택";
            this.btnCharacter.UseVisualStyleBackColor = true;
            this.btnCharacter.Click += new System.EventHandler(this.btnCharacter_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackgroundImage = global::EscapeGame.Properties.Resources.BG;
            this.btnExit.Font = new System.Drawing.Font("한컴산뜻돋움", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnExit.ForeColor = System.Drawing.Color.Orange;
            this.btnExit.Image = global::EscapeGame.Properties.Resources.판자_마지막;
            this.btnExit.Location = new System.Drawing.Point(322, 343);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(203, 73);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "나가기";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("휴먼엑스포", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(284, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(278, 57);
            this.label1.TabIndex = 4;
            this.label1.Text = "Prison Break";
            // 
            // MainGameMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::EscapeGame.Properties.Resources.BG;
            this.ClientSize = new System.Drawing.Size(859, 442);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCharacter);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainGameMenu";
            this.Text = "MainGameMenu";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnCharacter;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label1;
    }
}