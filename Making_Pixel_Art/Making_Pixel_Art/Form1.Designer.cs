namespace Making_Pixel_Art
{
    partial class MakingPixelArtForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbxPalette = new System.Windows.Forms.GroupBox();
            this.btnColorEdit = new System.Windows.Forms.Button();
            this.btnColor00 = new System.Windows.Forms.Button();
            this.btnColor09 = new System.Windows.Forms.Button();
            this.btnColor08 = new System.Windows.Forms.Button();
            this.btnColor07 = new System.Windows.Forms.Button();
            this.btnColor06 = new System.Windows.Forms.Button();
            this.btnColor05 = new System.Windows.Forms.Button();
            this.btnColor04 = new System.Windows.Forms.Button();
            this.btnColor03 = new System.Windows.Forms.Button();
            this.btnColor02 = new System.Windows.Forms.Button();
            this.btnColor01 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.gbxTools = new System.Windows.Forms.GroupBox();
            this.btnTool07 = new System.Windows.Forms.Button();
            this.btnTool06 = new System.Windows.Forms.Button();
            this.btnTool05 = new System.Windows.Forms.Button();
            this.btnTool04 = new System.Windows.Forms.Button();
            this.btnTool03 = new System.Windows.Forms.Button();
            this.btnTool02 = new System.Windows.Forms.Button();
            this.btnTool01 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSaveAndExit = new System.Windows.Forms.Button();
            this.btnPreview = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.gbxFrames = new System.Windows.Forms.GroupBox();
            this.btnNext = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblColorValue = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbxShowPreviousFrame = new System.Windows.Forms.CheckBox();
            this.btnCopyPreviousFrameToCurrentFrame = new System.Windows.Forms.Button();
            this.cld = new System.Windows.Forms.ColorDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblCurrentFrameNum = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnCopyNextFrameToCurrentFrame = new System.Windows.Forms.Button();
            this.pbxNextFrame = new System.Windows.Forms.PictureBox();
            this.pbxPreviousFrame = new System.Windows.Forms.PictureBox();
            this.pbxCurrentFrame = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.gbxPalette.SuspendLayout();
            this.gbxTools.SuspendLayout();
            this.gbxFrames.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxNextFrame)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPreviousFrame)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCurrentFrame)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxPalette
            // 
            this.gbxPalette.Controls.Add(this.btnColorEdit);
            this.gbxPalette.Controls.Add(this.btnColor00);
            this.gbxPalette.Controls.Add(this.btnColor09);
            this.gbxPalette.Controls.Add(this.btnColor08);
            this.gbxPalette.Controls.Add(this.btnColor07);
            this.gbxPalette.Controls.Add(this.btnColor06);
            this.gbxPalette.Controls.Add(this.btnColor05);
            this.gbxPalette.Controls.Add(this.btnColor04);
            this.gbxPalette.Controls.Add(this.btnColor03);
            this.gbxPalette.Controls.Add(this.btnColor02);
            this.gbxPalette.Controls.Add(this.btnColor01);
            this.gbxPalette.Location = new System.Drawing.Point(143, 18);
            this.gbxPalette.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.gbxPalette.Name = "gbxPalette";
            this.gbxPalette.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.gbxPalette.Size = new System.Drawing.Size(915, 99);
            this.gbxPalette.TabIndex = 2;
            this.gbxPalette.TabStop = false;
            this.gbxPalette.Text = "Palette";
            // 
            // btnColorEdit
            // 
            this.btnColorEdit.Location = new System.Drawing.Point(808, 30);
            this.btnColorEdit.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnColorEdit.Name = "btnColorEdit";
            this.btnColorEdit.Size = new System.Drawing.Size(97, 60);
            this.btnColorEdit.TabIndex = 10;
            this.btnColorEdit.Text = "Edit";
            this.btnColorEdit.UseVisualStyleBackColor = true;
            this.btnColorEdit.Click += new System.EventHandler(this.btnColorEdit_Click);
            // 
            // btnColor00
            // 
            this.btnColor00.Location = new System.Drawing.Point(728, 30);
            this.btnColor00.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnColor00.Name = "btnColor00";
            this.btnColor00.Size = new System.Drawing.Size(72, 60);
            this.btnColor00.TabIndex = 9;
            this.btnColor00.Text = "0";
            this.btnColor00.UseVisualStyleBackColor = true;
            this.btnColor00.Click += new System.EventHandler(this.btnColor01_Click);
            // 
            // btnColor09
            // 
            this.btnColor09.Location = new System.Drawing.Point(648, 30);
            this.btnColor09.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnColor09.Name = "btnColor09";
            this.btnColor09.Size = new System.Drawing.Size(72, 60);
            this.btnColor09.TabIndex = 8;
            this.btnColor09.Text = "9";
            this.btnColor09.UseVisualStyleBackColor = true;
            this.btnColor09.Click += new System.EventHandler(this.btnColor01_Click);
            // 
            // btnColor08
            // 
            this.btnColor08.Location = new System.Drawing.Point(568, 30);
            this.btnColor08.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnColor08.Name = "btnColor08";
            this.btnColor08.Size = new System.Drawing.Size(72, 60);
            this.btnColor08.TabIndex = 7;
            this.btnColor08.Text = "8";
            this.btnColor08.UseVisualStyleBackColor = true;
            this.btnColor08.Click += new System.EventHandler(this.btnColor01_Click);
            // 
            // btnColor07
            // 
            this.btnColor07.Location = new System.Drawing.Point(488, 30);
            this.btnColor07.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnColor07.Name = "btnColor07";
            this.btnColor07.Size = new System.Drawing.Size(72, 60);
            this.btnColor07.TabIndex = 6;
            this.btnColor07.Text = "7";
            this.btnColor07.UseVisualStyleBackColor = true;
            this.btnColor07.Click += new System.EventHandler(this.btnColor01_Click);
            // 
            // btnColor06
            // 
            this.btnColor06.Location = new System.Drawing.Point(408, 30);
            this.btnColor06.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnColor06.Name = "btnColor06";
            this.btnColor06.Size = new System.Drawing.Size(72, 60);
            this.btnColor06.TabIndex = 5;
            this.btnColor06.Text = "6";
            this.btnColor06.UseVisualStyleBackColor = true;
            this.btnColor06.Click += new System.EventHandler(this.btnColor01_Click);
            // 
            // btnColor05
            // 
            this.btnColor05.Location = new System.Drawing.Point(328, 30);
            this.btnColor05.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnColor05.Name = "btnColor05";
            this.btnColor05.Size = new System.Drawing.Size(72, 60);
            this.btnColor05.TabIndex = 4;
            this.btnColor05.Text = "5";
            this.btnColor05.UseVisualStyleBackColor = true;
            this.btnColor05.Click += new System.EventHandler(this.btnColor01_Click);
            // 
            // btnColor04
            // 
            this.btnColor04.Location = new System.Drawing.Point(248, 30);
            this.btnColor04.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnColor04.Name = "btnColor04";
            this.btnColor04.Size = new System.Drawing.Size(72, 60);
            this.btnColor04.TabIndex = 3;
            this.btnColor04.Text = "4";
            this.btnColor04.UseVisualStyleBackColor = true;
            this.btnColor04.Click += new System.EventHandler(this.btnColor01_Click);
            // 
            // btnColor03
            // 
            this.btnColor03.Location = new System.Drawing.Point(168, 30);
            this.btnColor03.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnColor03.Name = "btnColor03";
            this.btnColor03.Size = new System.Drawing.Size(72, 60);
            this.btnColor03.TabIndex = 2;
            this.btnColor03.Text = "3";
            this.btnColor03.UseVisualStyleBackColor = true;
            this.btnColor03.Click += new System.EventHandler(this.btnColor01_Click);
            // 
            // btnColor02
            // 
            this.btnColor02.Location = new System.Drawing.Point(88, 30);
            this.btnColor02.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnColor02.Name = "btnColor02";
            this.btnColor02.Size = new System.Drawing.Size(72, 60);
            this.btnColor02.TabIndex = 1;
            this.btnColor02.Text = "2";
            this.btnColor02.UseVisualStyleBackColor = true;
            this.btnColor02.Click += new System.EventHandler(this.btnColor01_Click);
            // 
            // btnColor01
            // 
            this.btnColor01.Location = new System.Drawing.Point(8, 30);
            this.btnColor01.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnColor01.Name = "btnColor01";
            this.btnColor01.Size = new System.Drawing.Size(72, 60);
            this.btnColor01.TabIndex = 0;
            this.btnColor01.Text = "1";
            this.btnColor01.UseVisualStyleBackColor = true;
            this.btnColor01.Click += new System.EventHandler(this.btnColor01_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1250, 114);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Previous Frame";
            // 
            // gbxTools
            // 
            this.gbxTools.Controls.Add(this.btnTool07);
            this.gbxTools.Controls.Add(this.btnTool06);
            this.gbxTools.Controls.Add(this.btnTool05);
            this.gbxTools.Controls.Add(this.btnTool04);
            this.gbxTools.Controls.Add(this.btnTool03);
            this.gbxTools.Controls.Add(this.btnTool02);
            this.gbxTools.Controls.Add(this.btnTool01);
            this.gbxTools.Location = new System.Drawing.Point(17, 150);
            this.gbxTools.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.gbxTools.Name = "gbxTools";
            this.gbxTools.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.gbxTools.Size = new System.Drawing.Size(95, 510);
            this.gbxTools.TabIndex = 4;
            this.gbxTools.TabStop = false;
            this.gbxTools.Text = "Tools";
            // 
            // btnTool07
            // 
            this.btnTool07.BackgroundImage = global::Making_Pixel_Art.Properties.Resources.Tool07_Spoid;
            this.btnTool07.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnTool07.Location = new System.Drawing.Point(8, 444);
            this.btnTool07.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnTool07.Name = "btnTool07";
            this.btnTool07.Size = new System.Drawing.Size(78, 60);
            this.btnTool07.TabIndex = 16;
            this.btnTool07.UseVisualStyleBackColor = true;
            this.btnTool07.Click += new System.EventHandler(this.btnTool01_Click);
            // 
            // btnTool06
            // 
            this.btnTool06.BackgroundImage = global::Making_Pixel_Art.Properties.Resources.Tool06_Fill;
            this.btnTool06.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnTool06.Location = new System.Drawing.Point(8, 375);
            this.btnTool06.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnTool06.Name = "btnTool06";
            this.btnTool06.Size = new System.Drawing.Size(78, 60);
            this.btnTool06.TabIndex = 16;
            this.btnTool06.UseVisualStyleBackColor = true;
            this.btnTool06.Click += new System.EventHandler(this.btnTool01_Click);
            // 
            // btnTool05
            // 
            this.btnTool05.BackgroundImage = global::Making_Pixel_Art.Properties.Resources.Tool05_Eraser;
            this.btnTool05.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnTool05.Location = new System.Drawing.Point(8, 306);
            this.btnTool05.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnTool05.Name = "btnTool05";
            this.btnTool05.Size = new System.Drawing.Size(78, 60);
            this.btnTool05.TabIndex = 15;
            this.btnTool05.Tag = "Tools.Eraser";
            this.btnTool05.UseVisualStyleBackColor = true;
            this.btnTool05.Click += new System.EventHandler(this.btnTool01_Click);
            // 
            // btnTool04
            // 
            this.btnTool04.BackgroundImage = global::Making_Pixel_Art.Properties.Resources.Tool04_Circle;
            this.btnTool04.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnTool04.Location = new System.Drawing.Point(8, 237);
            this.btnTool04.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnTool04.Name = "btnTool04";
            this.btnTool04.Size = new System.Drawing.Size(78, 60);
            this.btnTool04.TabIndex = 14;
            this.btnTool04.Tag = "Tools.Circle";
            this.btnTool04.UseVisualStyleBackColor = true;
            this.btnTool04.Click += new System.EventHandler(this.btnTool01_Click);
            // 
            // btnTool03
            // 
            this.btnTool03.BackgroundImage = global::Making_Pixel_Art.Properties.Resources.Tool03_Rectangle;
            this.btnTool03.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnTool03.Location = new System.Drawing.Point(7, 168);
            this.btnTool03.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnTool03.Name = "btnTool03";
            this.btnTool03.Size = new System.Drawing.Size(78, 60);
            this.btnTool03.TabIndex = 13;
            this.btnTool03.Tag = "Tools.Rectangle";
            this.btnTool03.UseVisualStyleBackColor = true;
            this.btnTool03.Click += new System.EventHandler(this.btnTool01_Click);
            // 
            // btnTool02
            // 
            this.btnTool02.BackgroundImage = global::Making_Pixel_Art.Properties.Resources.Tool02_Line;
            this.btnTool02.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnTool02.Location = new System.Drawing.Point(8, 99);
            this.btnTool02.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnTool02.Name = "btnTool02";
            this.btnTool02.Size = new System.Drawing.Size(78, 60);
            this.btnTool02.TabIndex = 12;
            this.btnTool02.Tag = "Tools.Line";
            this.btnTool02.UseVisualStyleBackColor = true;
            this.btnTool02.Click += new System.EventHandler(this.btnTool01_Click);
            // 
            // btnTool01
            // 
            this.btnTool01.BackgroundImage = global::Making_Pixel_Art.Properties.Resources.Tool01_Pen;
            this.btnTool01.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnTool01.Location = new System.Drawing.Point(8, 30);
            this.btnTool01.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnTool01.Name = "btnTool01";
            this.btnTool01.Size = new System.Drawing.Size(78, 60);
            this.btnTool01.TabIndex = 11;
            this.btnTool01.Tag = "Tools.Pen";
            this.btnTool01.UseVisualStyleBackColor = true;
            this.btnTool01.Click += new System.EventHandler(this.btnTool01_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1268, 690);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "Next Frame";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(47, 1162);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(143, 60);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSaveAndExit
            // 
            this.btnSaveAndExit.Location = new System.Drawing.Point(1363, 1162);
            this.btnSaveAndExit.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnSaveAndExit.Name = "btnSaveAndExit";
            this.btnSaveAndExit.Size = new System.Drawing.Size(143, 60);
            this.btnSaveAndExit.TabIndex = 8;
            this.btnSaveAndExit.Text = "Save And Exit";
            this.btnSaveAndExit.UseVisualStyleBackColor = true;
            this.btnSaveAndExit.Click += new System.EventHandler(this.btnSaveAndExit_Click);
            // 
            // btnPreview
            // 
            this.btnPreview.Location = new System.Drawing.Point(1153, 1162);
            this.btnPreview.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(143, 60);
            this.btnPreview.TabIndex = 9;
            this.btnPreview.Text = "Preview";
            this.btnPreview.UseVisualStyleBackColor = true;
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(23, 30);
            this.btnPrevious.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(165, 69);
            this.btnPrevious.TabIndex = 10;
            this.btnPrevious.Text = "Previous Frame";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // gbxFrames
            // 
            this.gbxFrames.Controls.Add(this.btnNext);
            this.gbxFrames.Controls.Add(this.btnPrevious);
            this.gbxFrames.Location = new System.Drawing.Point(655, 1132);
            this.gbxFrames.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.gbxFrames.Name = "gbxFrames";
            this.gbxFrames.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.gbxFrames.Size = new System.Drawing.Size(398, 116);
            this.gbxFrames.TabIndex = 11;
            this.gbxFrames.TabStop = false;
            this.gbxFrames.Text = "Move Frames";
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(212, 30);
            this.btnNext.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(165, 69);
            this.btnNext.TabIndex = 11;
            this.btnNext.Text = "Next Frame";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 1257);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(736, 18);
            this.label3.TabIndex = 12;
            this.label3.Text = "키보드에서 숫자키 1부터 0까지 중 하나를 누르면 해당 번호의 색상을 선택할 수 있습니다.";
            // 
            // lblColorValue
            // 
            this.lblColorValue.AutoSize = true;
            this.lblColorValue.Location = new System.Drawing.Point(1082, 69);
            this.lblColorValue.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblColorValue.Name = "lblColorValue";
            this.lblColorValue.Size = new System.Drawing.Size(254, 18);
            this.lblColorValue.TabIndex = 13;
            this.lblColorValue.Text = "현재 색상 : ( 255 . 255 . 255 )";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 1346);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(752, 18);
            this.label5.TabIndex = 15;
            this.label5.Text = "Previous 버튼을 누르면 이전 프레임이 나오고, Next 버튼을 누르면 다음 프레임이 나옵니다.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 1368);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(771, 18);
            this.label6.TabIndex = 16;
            this.label6.Text = "Preview 버튼을 누르면 지금까지 그렸던 프레임들의 애니메이션을 볼 수 있습니다. ( FPS : 10 )";
            // 
            // cbxShowPreviousFrame
            // 
            this.cbxShowPreviousFrame.AutoSize = true;
            this.cbxShowPreviousFrame.Location = new System.Drawing.Point(1140, 601);
            this.cbxShowPreviousFrame.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cbxShowPreviousFrame.Name = "cbxShowPreviousFrame";
            this.cbxShowPreviousFrame.Size = new System.Drawing.Size(213, 22);
            this.cbxShowPreviousFrame.TabIndex = 0;
            this.cbxShowPreviousFrame.Text = "Show Previous Frame";
            this.cbxShowPreviousFrame.UseVisualStyleBackColor = true;
            // 
            // btnCopyPreviousFrameToCurrentFrame
            // 
            this.btnCopyPreviousFrameToCurrentFrame.Location = new System.Drawing.Point(1140, 550);
            this.btnCopyPreviousFrameToCurrentFrame.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnCopyPreviousFrameToCurrentFrame.Name = "btnCopyPreviousFrameToCurrentFrame";
            this.btnCopyPreviousFrameToCurrentFrame.Size = new System.Drawing.Size(365, 36);
            this.btnCopyPreviousFrameToCurrentFrame.TabIndex = 17;
            this.btnCopyPreviousFrameToCurrentFrame.Text = "Copy Previous Frame To Current Frame";
            this.btnCopyPreviousFrameToCurrentFrame.UseVisualStyleBackColor = true;
            this.btnCopyPreviousFrameToCurrentFrame.Click += new System.EventHandler(this.btnCopyPreviousFrameToCurrentFrame_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblCurrentFrameNum);
            this.groupBox1.Location = new System.Drawing.Point(17, 704);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.groupBox1.Size = new System.Drawing.Size(95, 82);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Frame";
            // 
            // lblCurrentFrameNum
            // 
            this.lblCurrentFrameNum.AutoSize = true;
            this.lblCurrentFrameNum.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblCurrentFrameNum.Location = new System.Drawing.Point(15, 34);
            this.lblCurrentFrameNum.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblCurrentFrameNum.Name = "lblCurrentFrameNum";
            this.lblCurrentFrameNum.Size = new System.Drawing.Size(59, 20);
            this.lblCurrentFrameNum.TabIndex = 0;
            this.lblCurrentFrameNum.Text = "1 / 1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnAdd);
            this.groupBox2.Controls.Add(this.btnRemove);
            this.groupBox2.Location = new System.Drawing.Point(248, 1132);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.groupBox2.Size = new System.Drawing.Size(398, 116);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Control Frames";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(212, 30);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(165, 69);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "Add New Frame Next To This";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(23, 30);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(165, 69);
            this.btnRemove.TabIndex = 10;
            this.btnRemove.Text = "Remove This Frame";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnCopyNextFrameToCurrentFrame
            // 
            this.btnCopyNextFrameToCurrentFrame.Location = new System.Drawing.Point(1140, 639);
            this.btnCopyNextFrameToCurrentFrame.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnCopyNextFrameToCurrentFrame.Name = "btnCopyNextFrameToCurrentFrame";
            this.btnCopyNextFrameToCurrentFrame.Size = new System.Drawing.Size(365, 36);
            this.btnCopyNextFrameToCurrentFrame.TabIndex = 19;
            this.btnCopyNextFrameToCurrentFrame.Text = "Copy Next Frame To Current Frame";
            this.btnCopyNextFrameToCurrentFrame.UseVisualStyleBackColor = true;
            this.btnCopyNextFrameToCurrentFrame.Click += new System.EventHandler(this.btnCopyNextFrameToCurrentFrame_Click);
            // 
            // pbxNextFrame
            // 
            this.pbxNextFrame.Location = new System.Drawing.Point(1140, 726);
            this.pbxNextFrame.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.pbxNextFrame.Name = "pbxNextFrame";
            this.pbxNextFrame.Size = new System.Drawing.Size(365, 384);
            this.pbxNextFrame.TabIndex = 5;
            this.pbxNextFrame.TabStop = false;
            this.pbxNextFrame.Paint += new System.Windows.Forms.PaintEventHandler(this.pbxNextFrame_Paint);
            // 
            // pbxPreviousFrame
            // 
            this.pbxPreviousFrame.Location = new System.Drawing.Point(1140, 150);
            this.pbxPreviousFrame.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.pbxPreviousFrame.Name = "pbxPreviousFrame";
            this.pbxPreviousFrame.Size = new System.Drawing.Size(365, 384);
            this.pbxPreviousFrame.TabIndex = 1;
            this.pbxPreviousFrame.TabStop = false;
            this.pbxPreviousFrame.Paint += new System.Windows.Forms.PaintEventHandler(this.pbxPreviousFrame_Paint);
            // 
            // pbxCurrentFrame
            // 
            this.pbxCurrentFrame.Location = new System.Drawing.Point(143, 150);
            this.pbxCurrentFrame.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.pbxCurrentFrame.Name = "pbxCurrentFrame";
            this.pbxCurrentFrame.Size = new System.Drawing.Size(915, 960);
            this.pbxCurrentFrame.TabIndex = 0;
            this.pbxCurrentFrame.TabStop = false;
            this.pbxCurrentFrame.Paint += new System.Windows.Forms.PaintEventHandler(this.pbxCurrentFrame_Paint);
            this.pbxCurrentFrame.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbxCurrentFrame_MouseDown);
            this.pbxCurrentFrame.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbxCurrentFrame_MouseMove);
            this.pbxCurrentFrame.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pbxCurrentFrame_MouseUp);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 1279);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(1217, 18);
            this.label7.TabIndex = 20;
            this.label7.Text = "키보드에서 Q , W , E , R , A , S , D 를 누르면 누른 키에 해당하는 도구를 사용할 수 있고, 키보드에서 F 키를 누르면 현재 " +
    "색상을 변경할 수 있습니다.\r\n";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(25, 1301);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(512, 18);
            this.label8.TabIndex = 21;
            this.label8.Text = "Remove This Frame 버튼을 누르면 현재 프레임이 삭제됩니다.";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(25, 1323);
            this.label9.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(769, 18);
            this.label9.TabIndex = 22;
            this.label9.Text = "Add New Frame Next To This 버튼을 누르면 현재 프레임 다음에 새로운 프레임이 생성됩니다.";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(25, 1391);
            this.label10.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(1534, 18);
            this.label10.TabIndex = 23;
            this.label10.Text = "Copy Previous Frame To Current Frame 버튼을 누르면 이전 프레임이 현재 프레임에 복사되고, Copy Next Fram" +
    "e To Current Frame 버튼을 누르면 다음 프레임이 현재 프레임에 복사됩니다.";
            // 
            // MakingPixelArtForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1578, 1442);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnCopyNextFrameToCurrentFrame);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCopyPreviousFrameToCurrentFrame);
            this.Controls.Add(this.cbxShowPreviousFrame);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblColorValue);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.gbxFrames);
            this.Controls.Add(this.btnPreview);
            this.Controls.Add(this.btnSaveAndExit);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pbxNextFrame);
            this.Controls.Add(this.gbxTools);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gbxPalette);
            this.Controls.Add(this.pbxPreviousFrame);
            this.Controls.Add(this.pbxCurrentFrame);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "MakingPixelArtForm";
            this.Text = "Making Pixel Art";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MakingPixelArtForm_KeyDown);
            this.gbxPalette.ResumeLayout(false);
            this.gbxTools.ResumeLayout(false);
            this.gbxFrames.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxNextFrame)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPreviousFrame)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCurrentFrame)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxCurrentFrame;
        private System.Windows.Forms.PictureBox pbxPreviousFrame;
        private System.Windows.Forms.GroupBox gbxPalette;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbxTools;
        private System.Windows.Forms.PictureBox pbxNextFrame;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnColorEdit;
        private System.Windows.Forms.Button btnColor00;
        private System.Windows.Forms.Button btnColor09;
        private System.Windows.Forms.Button btnColor08;
        private System.Windows.Forms.Button btnColor07;
        private System.Windows.Forms.Button btnColor06;
        private System.Windows.Forms.Button btnColor05;
        private System.Windows.Forms.Button btnColor04;
        private System.Windows.Forms.Button btnColor03;
        private System.Windows.Forms.Button btnColor02;
        private System.Windows.Forms.Button btnColor01;
        private System.Windows.Forms.Button btnTool06;
        private System.Windows.Forms.Button btnTool05;
        private System.Windows.Forms.Button btnTool04;
        private System.Windows.Forms.Button btnTool03;
        private System.Windows.Forms.Button btnTool02;
        private System.Windows.Forms.Button btnTool01;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSaveAndExit;
        private System.Windows.Forms.Button btnPreview;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.GroupBox gbxFrames;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblColorValue;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox cbxShowPreviousFrame;
        private System.Windows.Forms.Button btnCopyPreviousFrameToCurrentFrame;
        private System.Windows.Forms.ColorDialog cld;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblCurrentFrameNum;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnCopyNextFrameToCurrentFrame;
        private System.Windows.Forms.Button btnTool07;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}

