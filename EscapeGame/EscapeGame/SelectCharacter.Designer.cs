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
            ((System.ComponentModel.ISupportInitialize)(this.pbxCharacter)).BeginInit();
            this.SuspendLayout();
            // 
            // cbxCharacters
            // 
            this.cbxCharacters.FormattingEnabled = true;
            this.cbxCharacters.Location = new System.Drawing.Point(103, 207);
            this.cbxCharacters.Name = "cbxCharacters";
            this.cbxCharacters.Size = new System.Drawing.Size(122, 20);
            this.cbxCharacters.TabIndex = 0;
            this.cbxCharacters.SelectedIndexChanged += new System.EventHandler(this.cbxCharacters_SelectedIndexChanged);
            // 
            // pbxCharacter
            // 
            this.pbxCharacter.Location = new System.Drawing.Point(270, 91);
            this.pbxCharacter.Name = "pbxCharacter";
            this.pbxCharacter.Size = new System.Drawing.Size(256, 256);
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
            this.btnCustomize.Location = new System.Drawing.Point(556, 128);
            this.btnCustomize.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCustomize.Name = "btnCustomize";
            this.btnCustomize.Size = new System.Drawing.Size(203, 73);
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
            this.btnSelectCharacter.Location = new System.Drawing.Point(556, 245);
            this.btnSelectCharacter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSelectCharacter.Name = "btnSelectCharacter";
            this.btnSelectCharacter.Size = new System.Drawing.Size(203, 73);
            this.btnSelectCharacter.TabIndex = 5;
            this.btnSelectCharacter.Text = "캐릭터 선택";
            this.btnSelectCharacter.UseVisualStyleBackColor = true;
            this.btnSelectCharacter.Click += new System.EventHandler(this.btnSelectCharacter_Click);
            // 
            // characterTimer
            // 
            this.characterTimer.Tick += new System.EventHandler(this.characterTimer_Tick);
            // 
            // SelectCharacter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::EscapeGame.Properties.Resources.BG;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSelectCharacter);
            this.Controls.Add(this.btnCustomize);
            this.Controls.Add(this.pbxCharacter);
            this.Controls.Add(this.cbxCharacters);
            this.Name = "SelectCharacter";
            this.Text = "SelectCharacter";
            ((System.ComponentModel.ISupportInitialize)(this.pbxCharacter)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxCharacters;
        private System.Windows.Forms.PictureBox pbxCharacter;
        private System.Windows.Forms.Button btnCustomize;
        private System.Windows.Forms.Button btnSelectCharacter;
        private System.Windows.Forms.Timer characterTimer;
    }
}