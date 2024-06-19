namespace EscapeGame
{
    partial class SelectCharacter
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
            this.cbxCharacters = new System.Windows.Forms.ComboBox();
            this.pbxCharacter = new System.Windows.Forms.PictureBox();
            this.btnCustomize = new System.Windows.Forms.Button();
            this.btnSelectCharacter = new System.Windows.Forms.Button();
            this.characterTimer = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCharacter)).BeginInit();
            this.SuspendLayout();
            // 
            // cbxCharacters
            // 
            this.cbxCharacters.FormattingEnabled = true;
            this.cbxCharacters.Location = new System.Drawing.Point(147, 355);
            this.cbxCharacters.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbxCharacters.Name = "cbxCharacters";
            this.cbxCharacters.Size = new System.Drawing.Size(173, 26);
            this.cbxCharacters.TabIndex = 0;
            this.cbxCharacters.SelectedIndexChanged += new System.EventHandler(this.cbxCharacters_SelectedIndexChanged);
            // 
            // pbxCharacter
            // 
            this.pbxCharacter.Location = new System.Drawing.Point(386, 181);
            this.pbxCharacter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbxCharacter.Name = "pbxCharacter";
            this.pbxCharacter.Size = new System.Drawing.Size(366, 384);
            this.pbxCharacter.TabIndex = 1;
            this.pbxCharacter.TabStop = false;
            this.pbxCharacter.Paint += new System.Windows.Forms.PaintEventHandler(this.pbxCharacter_Paint);
            // 
            // btnCustomize
            // 
            this.btnCustomize.BackgroundImage = global::EscapeGame.Properties.Resources.BG;
            this.btnCustomize.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnCustomize.ForeColor = System.Drawing.Color.Orange;
            this.btnCustomize.Image = global::EscapeGame.Properties.Resources.판자_마지막;
            this.btnCustomize.Location = new System.Drawing.Point(794, 237);
            this.btnCustomize.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCustomize.Name = "btnCustomize";
            this.btnCustomize.Size = new System.Drawing.Size(290, 110);
            this.btnCustomize.TabIndex = 4;
            this.btnCustomize.Text = "새로운 캐릭터 만들기\r\n( 커스터마이징 )";
            this.btnCustomize.UseVisualStyleBackColor = true;
            this.btnCustomize.Click += new System.EventHandler(this.btnCustomize_Click);
            // 
            // btnSelectCharacter
            // 
            this.btnSelectCharacter.BackgroundImage = global::EscapeGame.Properties.Resources.BG;
            this.btnSelectCharacter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnSelectCharacter.ForeColor = System.Drawing.Color.Orange;
            this.btnSelectCharacter.Image = global::EscapeGame.Properties.Resources.판자_마지막;
            this.btnSelectCharacter.Location = new System.Drawing.Point(794, 413);
            this.btnSelectCharacter.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSelectCharacter.Name = "btnSelectCharacter";
            this.btnSelectCharacter.Size = new System.Drawing.Size(290, 110);
            this.btnSelectCharacter.TabIndex = 5;
            this.btnSelectCharacter.Text = "캐릭터 선택";
            this.btnSelectCharacter.UseVisualStyleBackColor = true;
            this.btnSelectCharacter.Click += new System.EventHandler(this.btnSelectCharacter_Click);
            // 
            // characterTimer
            // 
            this.characterTimer.Tick += new System.EventHandler(this.characterTimer_Tick);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("휴먼둥근헤드라인", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(414, 64);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(310, 79);
            this.label1.TabIndex = 6;
            this.label1.Text = "캐릭터 선택";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("휴먼둥근헤드라인", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(166, 317);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 30);
            this.label2.TabIndex = 7;
            this.label2.Text = "캐릭터";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SelectCharacter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::EscapeGame.Properties.Resources.BG;
            this.ClientSize = new System.Drawing.Size(1143, 675);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSelectCharacter);
            this.Controls.Add(this.btnCustomize);
            this.Controls.Add(this.pbxCharacter);
            this.Controls.Add(this.cbxCharacters);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "SelectCharacter";
            this.Text = "SelectCharacter";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SelectCharacter_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pbxCharacter)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxCharacters;
        private System.Windows.Forms.PictureBox pbxCharacter;
        private System.Windows.Forms.Button btnCustomize;
        private System.Windows.Forms.Button btnSelectCharacter;
        private System.Windows.Forms.Timer characterTimer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}