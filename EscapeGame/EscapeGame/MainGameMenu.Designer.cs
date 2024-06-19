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
            this.components = new System.ComponentModel.Container();
            this.pbxCharacter = new System.Windows.Forms.PictureBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnCharacter = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.characterTimer = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCharacter)).BeginInit();
            this.SuspendLayout();
            // 
            // pbxCharacter
            // 
            this.pbxCharacter.Location = new System.Drawing.Point(607, 191);
            this.pbxCharacter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbxCharacter.Name = "pbxCharacter";
            this.pbxCharacter.Size = new System.Drawing.Size(180, 180);
            this.pbxCharacter.TabIndex = 0;
            this.pbxCharacter.TabStop = false;
            this.pbxCharacter.Paint += new System.Windows.Forms.PaintEventHandler(this.pbxCharacter_Paint);
            // 
            // btnStart
            // 
            this.btnStart.BackgroundImage = global::EscapeGame.Properties.Resources.BG;
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnStart.ForeColor = System.Drawing.Color.Orange;
            this.btnStart.Image = global::EscapeGame.Properties.Resources.판자_위;
            this.btnStart.Location = new System.Drawing.Point(322, 147);
            this.btnStart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(203, 116);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "\r\n시작하기";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnCharacter
            // 
            this.btnCharacter.BackgroundImage = global::EscapeGame.Properties.Resources.BG;
            this.btnCharacter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
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
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
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
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("휴먼둥근헤드라인", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(135, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(583, 103);
            this.label1.TabIndex = 4;
            this.label1.Text = "Prison Break";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // characterTimer
            // 
            this.characterTimer.Tick += new System.EventHandler(this.characterTimer_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(30, 351);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(205, 65);
            this.label2.TabIndex = 5;
            this.label2.Text = "광운대학교 소프트웨어학과\r\n\r\n응용소프트웨어실습 10조\r\n\r\n조윤호, 배주환, 강동호, 고현호";
            // 
            // MainGameMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::EscapeGame.Properties.Resources.BG;
            this.ClientSize = new System.Drawing.Size(859, 442);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCharacter);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.pbxCharacter);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainGameMenu";
            this.Text = "MainGameMenu";
            ((System.ComponentModel.ISupportInitialize)(this.pbxCharacter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxCharacter;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnCharacter;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer characterTimer;
        private System.Windows.Forms.Label label2;
    }
}