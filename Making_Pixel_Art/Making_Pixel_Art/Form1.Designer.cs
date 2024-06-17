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
            this.lblColorValue = new System.Windows.Forms.Label();
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.gbxPalette.SuspendLayout();
            this.gbxTools.SuspendLayout();
            this.gbxFrames.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxNextFrame)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPreviousFrame)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCurrentFrame)).BeginInit();
            this.groupBox3.SuspendLayout();
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
            this.gbxPalette.Location = new System.Drawing.Point(100, 12);
            this.gbxPalette.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbxPalette.Name = "gbxPalette";
            this.gbxPalette.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbxPalette.Size = new System.Drawing.Size(640, 66);
            this.gbxPalette.TabIndex = 2;
            this.gbxPalette.TabStop = false;
            this.gbxPalette.Text = "Palette";
            // 
            // btnColorEdit
            // 
            this.btnColorEdit.Location = new System.Drawing.Point(566, 20);
            this.btnColorEdit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnColorEdit.Name = "btnColorEdit";
            this.btnColorEdit.Size = new System.Drawing.Size(68, 40);
            this.btnColorEdit.TabIndex = 10;
            this.btnColorEdit.Text = "Edit";
            this.btnColorEdit.UseVisualStyleBackColor = true;
            this.btnColorEdit.Click += new System.EventHandler(this.btnColorEdit_Click);
            // 
            // btnColor00
            // 
            this.btnColor00.Location = new System.Drawing.Point(510, 20);
            this.btnColor00.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnColor00.Name = "btnColor00";
            this.btnColor00.Size = new System.Drawing.Size(50, 40);
            this.btnColor00.TabIndex = 9;
            this.btnColor00.Text = "0";
            this.btnColor00.UseVisualStyleBackColor = true;
            this.btnColor00.Click += new System.EventHandler(this.btnColor01_Click);
            // 
            // btnColor09
            // 
            this.btnColor09.Location = new System.Drawing.Point(454, 20);
            this.btnColor09.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnColor09.Name = "btnColor09";
            this.btnColor09.Size = new System.Drawing.Size(50, 40);
            this.btnColor09.TabIndex = 8;
            this.btnColor09.Text = "9";
            this.btnColor09.UseVisualStyleBackColor = true;
            this.btnColor09.Click += new System.EventHandler(this.btnColor01_Click);
            // 
            // btnColor08
            // 
            this.btnColor08.Location = new System.Drawing.Point(398, 20);
            this.btnColor08.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnColor08.Name = "btnColor08";
            this.btnColor08.Size = new System.Drawing.Size(50, 40);
            this.btnColor08.TabIndex = 7;
            this.btnColor08.Text = "8";
            this.btnColor08.UseVisualStyleBackColor = true;
            this.btnColor08.Click += new System.EventHandler(this.btnColor01_Click);
            // 
            // btnColor07
            // 
            this.btnColor07.Location = new System.Drawing.Point(342, 20);
            this.btnColor07.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnColor07.Name = "btnColor07";
            this.btnColor07.Size = new System.Drawing.Size(50, 40);
            this.btnColor07.TabIndex = 6;
            this.btnColor07.Text = "7";
            this.btnColor07.UseVisualStyleBackColor = true;
            this.btnColor07.Click += new System.EventHandler(this.btnColor01_Click);
            // 
            // btnColor06
            // 
            this.btnColor06.Location = new System.Drawing.Point(286, 20);
            this.btnColor06.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnColor06.Name = "btnColor06";
            this.btnColor06.Size = new System.Drawing.Size(50, 40);
            this.btnColor06.TabIndex = 5;
            this.btnColor06.Text = "6";
            this.btnColor06.UseVisualStyleBackColor = true;
            this.btnColor06.Click += new System.EventHandler(this.btnColor01_Click);
            // 
            // btnColor05
            // 
            this.btnColor05.Location = new System.Drawing.Point(230, 20);
            this.btnColor05.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnColor05.Name = "btnColor05";
            this.btnColor05.Size = new System.Drawing.Size(50, 40);
            this.btnColor05.TabIndex = 4;
            this.btnColor05.Text = "5";
            this.btnColor05.UseVisualStyleBackColor = true;
            this.btnColor05.Click += new System.EventHandler(this.btnColor01_Click);
            // 
            // btnColor04
            // 
            this.btnColor04.Location = new System.Drawing.Point(174, 20);
            this.btnColor04.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnColor04.Name = "btnColor04";
            this.btnColor04.Size = new System.Drawing.Size(50, 40);
            this.btnColor04.TabIndex = 3;
            this.btnColor04.Text = "4";
            this.btnColor04.UseVisualStyleBackColor = true;
            this.btnColor04.Click += new System.EventHandler(this.btnColor01_Click);
            // 
            // btnColor03
            // 
            this.btnColor03.Location = new System.Drawing.Point(118, 20);
            this.btnColor03.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnColor03.Name = "btnColor03";
            this.btnColor03.Size = new System.Drawing.Size(50, 40);
            this.btnColor03.TabIndex = 2;
            this.btnColor03.Text = "3";
            this.btnColor03.UseVisualStyleBackColor = true;
            this.btnColor03.Click += new System.EventHandler(this.btnColor01_Click);
            // 
            // btnColor02
            // 
            this.btnColor02.Location = new System.Drawing.Point(62, 20);
            this.btnColor02.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnColor02.Name = "btnColor02";
            this.btnColor02.Size = new System.Drawing.Size(50, 40);
            this.btnColor02.TabIndex = 1;
            this.btnColor02.Text = "2";
            this.btnColor02.UseVisualStyleBackColor = true;
            this.btnColor02.Click += new System.EventHandler(this.btnColor01_Click);
            // 
            // btnColor01
            // 
            this.btnColor01.Location = new System.Drawing.Point(6, 20);
            this.btnColor01.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnColor01.Name = "btnColor01";
            this.btnColor01.Size = new System.Drawing.Size(50, 40);
            this.btnColor01.TabIndex = 0;
            this.btnColor01.Text = "1";
            this.btnColor01.UseVisualStyleBackColor = true;
            this.btnColor01.Click += new System.EventHandler(this.btnColor01_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(875, 76);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 12);
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
            this.gbxTools.Location = new System.Drawing.Point(12, 100);
            this.gbxTools.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbxTools.Name = "gbxTools";
            this.gbxTools.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbxTools.Size = new System.Drawing.Size(66, 340);
            this.gbxTools.TabIndex = 4;
            this.gbxTools.TabStop = false;
            this.gbxTools.Text = "Tools";
            // 
            // btnTool07
            // 
            this.btnTool07.BackgroundImage = global::Making_Pixel_Art.Properties.Resources.Tool07_Spoid;
            this.btnTool07.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnTool07.Location = new System.Drawing.Point(6, 296);
            this.btnTool07.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnTool07.Name = "btnTool07";
            this.btnTool07.Size = new System.Drawing.Size(55, 40);
            this.btnTool07.TabIndex = 16;
            this.btnTool07.UseVisualStyleBackColor = true;
            this.btnTool07.Click += new System.EventHandler(this.btnTool01_Click);
            // 
            // btnTool06
            // 
            this.btnTool06.BackgroundImage = global::Making_Pixel_Art.Properties.Resources.Tool06_Fill;
            this.btnTool06.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnTool06.Location = new System.Drawing.Point(6, 250);
            this.btnTool06.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnTool06.Name = "btnTool06";
            this.btnTool06.Size = new System.Drawing.Size(55, 40);
            this.btnTool06.TabIndex = 16;
            this.btnTool06.UseVisualStyleBackColor = true;
            this.btnTool06.Click += new System.EventHandler(this.btnTool01_Click);
            // 
            // btnTool05
            // 
            this.btnTool05.BackgroundImage = global::Making_Pixel_Art.Properties.Resources.Tool05_Eraser;
            this.btnTool05.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnTool05.Location = new System.Drawing.Point(6, 204);
            this.btnTool05.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnTool05.Name = "btnTool05";
            this.btnTool05.Size = new System.Drawing.Size(55, 40);
            this.btnTool05.TabIndex = 15;
            this.btnTool05.Tag = "Tools.Eraser";
            this.btnTool05.UseVisualStyleBackColor = true;
            this.btnTool05.Click += new System.EventHandler(this.btnTool01_Click);
            // 
            // btnTool04
            // 
            this.btnTool04.BackgroundImage = global::Making_Pixel_Art.Properties.Resources.Tool04_Circle;
            this.btnTool04.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnTool04.Location = new System.Drawing.Point(6, 158);
            this.btnTool04.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnTool04.Name = "btnTool04";
            this.btnTool04.Size = new System.Drawing.Size(55, 40);
            this.btnTool04.TabIndex = 14;
            this.btnTool04.Tag = "Tools.Circle";
            this.btnTool04.UseVisualStyleBackColor = true;
            this.btnTool04.Click += new System.EventHandler(this.btnTool01_Click);
            // 
            // btnTool03
            // 
            this.btnTool03.BackgroundImage = global::Making_Pixel_Art.Properties.Resources.Tool03_Rectangle;
            this.btnTool03.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnTool03.Location = new System.Drawing.Point(5, 112);
            this.btnTool03.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnTool03.Name = "btnTool03";
            this.btnTool03.Size = new System.Drawing.Size(55, 40);
            this.btnTool03.TabIndex = 13;
            this.btnTool03.Tag = "Tools.Rectangle";
            this.btnTool03.UseVisualStyleBackColor = true;
            this.btnTool03.Click += new System.EventHandler(this.btnTool01_Click);
            // 
            // btnTool02
            // 
            this.btnTool02.BackgroundImage = global::Making_Pixel_Art.Properties.Resources.Tool02_Line;
            this.btnTool02.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnTool02.Location = new System.Drawing.Point(6, 66);
            this.btnTool02.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnTool02.Name = "btnTool02";
            this.btnTool02.Size = new System.Drawing.Size(55, 40);
            this.btnTool02.TabIndex = 12;
            this.btnTool02.Tag = "Tools.Line";
            this.btnTool02.UseVisualStyleBackColor = true;
            this.btnTool02.Click += new System.EventHandler(this.btnTool01_Click);
            // 
            // btnTool01
            // 
            this.btnTool01.BackgroundImage = global::Making_Pixel_Art.Properties.Resources.Tool01_Pen;
            this.btnTool01.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnTool01.Location = new System.Drawing.Point(6, 20);
            this.btnTool01.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnTool01.Name = "btnTool01";
            this.btnTool01.Size = new System.Drawing.Size(55, 40);
            this.btnTool01.TabIndex = 11;
            this.btnTool01.Tag = "Tools.Pen";
            this.btnTool01.UseVisualStyleBackColor = true;
            this.btnTool01.Click += new System.EventHandler(this.btnTool01_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(888, 460);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "Next Frame";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(33, 775);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 40);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSaveAndExit
            // 
            this.btnSaveAndExit.Location = new System.Drawing.Point(954, 775);
            this.btnSaveAndExit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSaveAndExit.Name = "btnSaveAndExit";
            this.btnSaveAndExit.Size = new System.Drawing.Size(100, 40);
            this.btnSaveAndExit.TabIndex = 8;
            this.btnSaveAndExit.Text = "Save And Exit";
            this.btnSaveAndExit.UseVisualStyleBackColor = true;
            this.btnSaveAndExit.Click += new System.EventHandler(this.btnSaveAndExit_Click);
            // 
            // btnPreview
            // 
            this.btnPreview.Location = new System.Drawing.Point(798, 775);
            this.btnPreview.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(100, 40);
            this.btnPreview.TabIndex = 9;
            this.btnPreview.Text = "Preview";
            this.btnPreview.UseVisualStyleBackColor = true;
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(16, 20);
            this.btnPrevious.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(116, 46);
            this.btnPrevious.TabIndex = 10;
            this.btnPrevious.Text = "Previous Frame";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // gbxFrames
            // 
            this.gbxFrames.Controls.Add(this.btnNext);
            this.gbxFrames.Controls.Add(this.btnPrevious);
            this.gbxFrames.Location = new System.Drawing.Point(458, 755);
            this.gbxFrames.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbxFrames.Name = "gbxFrames";
            this.gbxFrames.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbxFrames.Size = new System.Drawing.Size(279, 77);
            this.gbxFrames.TabIndex = 11;
            this.gbxFrames.TabStop = false;
            this.gbxFrames.Text = "Move Frames";
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(148, 20);
            this.btnNext.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(116, 46);
            this.btnNext.TabIndex = 11;
            this.btnNext.Text = "Next Frame";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // lblColorValue
            // 
            this.lblColorValue.AutoSize = true;
            this.lblColorValue.Location = new System.Drawing.Point(757, 46);
            this.lblColorValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblColorValue.Name = "lblColorValue";
            this.lblColorValue.Size = new System.Drawing.Size(165, 12);
            this.lblColorValue.TabIndex = 13;
            this.lblColorValue.Text = "현재 색상 : ( 255 . 255 . 255 )";
            // 
            // cbxShowPreviousFrame
            // 
            this.cbxShowPreviousFrame.AutoSize = true;
            this.cbxShowPreviousFrame.Checked = true;
            this.cbxShowPreviousFrame.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxShowPreviousFrame.Location = new System.Drawing.Point(798, 402);
            this.cbxShowPreviousFrame.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbxShowPreviousFrame.Name = "cbxShowPreviousFrame";
            this.cbxShowPreviousFrame.Size = new System.Drawing.Size(149, 16);
            this.cbxShowPreviousFrame.TabIndex = 0;
            this.cbxShowPreviousFrame.Text = "Show Previous Frame";
            this.cbxShowPreviousFrame.UseVisualStyleBackColor = true;
            this.cbxShowPreviousFrame.CheckedChanged += new System.EventHandler(this.cbxShowPreviousFrame_CheckedChanged);
            // 
            // btnCopyPreviousFrameToCurrentFrame
            // 
            this.btnCopyPreviousFrameToCurrentFrame.Location = new System.Drawing.Point(798, 367);
            this.btnCopyPreviousFrameToCurrentFrame.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCopyPreviousFrameToCurrentFrame.Name = "btnCopyPreviousFrameToCurrentFrame";
            this.btnCopyPreviousFrameToCurrentFrame.Size = new System.Drawing.Size(256, 24);
            this.btnCopyPreviousFrameToCurrentFrame.TabIndex = 17;
            this.btnCopyPreviousFrameToCurrentFrame.Text = "Copy Previous Frame To Current Frame";
            this.btnCopyPreviousFrameToCurrentFrame.UseVisualStyleBackColor = true;
            this.btnCopyPreviousFrameToCurrentFrame.Click += new System.EventHandler(this.btnCopyPreviousFrameToCurrentFrame_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblCurrentFrameNum);
            this.groupBox1.Location = new System.Drawing.Point(12, 469);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(76, 55);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Frame";
            // 
            // lblCurrentFrameNum
            // 
            this.lblCurrentFrameNum.AutoSize = true;
            this.lblCurrentFrameNum.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblCurrentFrameNum.Location = new System.Drawing.Point(10, 23);
            this.lblCurrentFrameNum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCurrentFrameNum.Name = "lblCurrentFrameNum";
            this.lblCurrentFrameNum.Size = new System.Drawing.Size(44, 16);
            this.lblCurrentFrameNum.TabIndex = 0;
            this.lblCurrentFrameNum.Text = "1 / 1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnAdd);
            this.groupBox2.Controls.Add(this.btnRemove);
            this.groupBox2.Location = new System.Drawing.Point(174, 755);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Size = new System.Drawing.Size(279, 77);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Control Frames";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(148, 20);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(116, 46);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "Add New Frame Next To This";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(16, 20);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(116, 46);
            this.btnRemove.TabIndex = 10;
            this.btnRemove.Text = "Remove This Frame";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnCopyNextFrameToCurrentFrame
            // 
            this.btnCopyNextFrameToCurrentFrame.Location = new System.Drawing.Point(798, 426);
            this.btnCopyNextFrameToCurrentFrame.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCopyNextFrameToCurrentFrame.Name = "btnCopyNextFrameToCurrentFrame";
            this.btnCopyNextFrameToCurrentFrame.Size = new System.Drawing.Size(256, 24);
            this.btnCopyNextFrameToCurrentFrame.TabIndex = 19;
            this.btnCopyNextFrameToCurrentFrame.Text = "Copy Next Frame To Current Frame";
            this.btnCopyNextFrameToCurrentFrame.UseVisualStyleBackColor = true;
            this.btnCopyNextFrameToCurrentFrame.Click += new System.EventHandler(this.btnCopyNextFrameToCurrentFrame_Click);
            // 
            // pbxNextFrame
            // 
            this.pbxNextFrame.Location = new System.Drawing.Point(798, 484);
            this.pbxNextFrame.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pbxNextFrame.Name = "pbxNextFrame";
            this.pbxNextFrame.Size = new System.Drawing.Size(256, 256);
            this.pbxNextFrame.TabIndex = 5;
            this.pbxNextFrame.TabStop = false;
            this.pbxNextFrame.Paint += new System.Windows.Forms.PaintEventHandler(this.pbxNextFrame_Paint);
            // 
            // pbxPreviousFrame
            // 
            this.pbxPreviousFrame.Location = new System.Drawing.Point(798, 100);
            this.pbxPreviousFrame.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pbxPreviousFrame.Name = "pbxPreviousFrame";
            this.pbxPreviousFrame.Size = new System.Drawing.Size(256, 256);
            this.pbxPreviousFrame.TabIndex = 1;
            this.pbxPreviousFrame.TabStop = false;
            this.pbxPreviousFrame.Paint += new System.Windows.Forms.PaintEventHandler(this.pbxPreviousFrame_Paint);
            // 
            // pbxCurrentFrame
            // 
            this.pbxCurrentFrame.Location = new System.Drawing.Point(100, 100);
            this.pbxCurrentFrame.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pbxCurrentFrame.Name = "pbxCurrentFrame";
            this.pbxCurrentFrame.Size = new System.Drawing.Size(640, 640);
            this.pbxCurrentFrame.TabIndex = 0;
            this.pbxCurrentFrame.TabStop = false;
            this.pbxCurrentFrame.Paint += new System.Windows.Forms.PaintEventHandler(this.pbxCurrentFrame_Paint);
            this.pbxCurrentFrame.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbxCurrentFrame_MouseDown);
            this.pbxCurrentFrame.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbxCurrentFrame_MouseMove);
            this.pbxCurrentFrame.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pbxCurrentFrame_MouseUp);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox3.Location = new System.Drawing.Point(12, 832);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Size = new System.Drawing.Size(1084, 138);
            this.groupBox3.TabIndex = 24;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "사용설명서";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 121);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(652, 12);
            this.label3.TabIndex = 31;
            this.label3.Text = "Cancel 버튼을 누르면 저장 없이 종료되고, Save And Exit 버튼을 누르면 지금까지 작업한 내용이 저장되고 종료됩니다.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 105);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(1044, 12);
            this.label4.TabIndex = 30;
            this.label4.Text = "Copy Previous Frame To Current Frame 버튼을 누르면 이전 프레임이 현재 프레임에 복사되고, Copy Next Fram" +
    "e To Current Frame 버튼을 누르면 다음 프레임이 현재 프레임에 복사됩니다.";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(4, 60);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(523, 12);
            this.label11.TabIndex = 29;
            this.label11.Text = "Add New Frame Next To This 버튼을 누르면 현재 프레임 다음에 새로운 프레임이 생성됩니다.";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(4, 45);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(348, 12);
            this.label12.TabIndex = 28;
            this.label12.Text = "Remove This Frame 버튼을 누르면 현재 프레임이 삭제됩니다.";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(4, 31);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(815, 12);
            this.label13.TabIndex = 27;
            this.label13.Text = "키보드에서 Q , W , E , R , A , S , D 를 누르면 누른 키에 해당하는 도구를 사용할 수 있고, 키보드에서 F 키를 누르면 현재 " +
    "색상을 변경할 수 있습니다.\r\n";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(4, 90);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(519, 12);
            this.label14.TabIndex = 26;
            this.label14.Text = "Preview 버튼을 누르면 지금까지 그렸던 프레임들의 애니메이션을 볼 수 있습니다. ( FPS : 10 )";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(4, 75);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(504, 12);
            this.label15.TabIndex = 25;
            this.label15.Text = "Previous 버튼을 누르면 이전 프레임이 나오고, Next 버튼을 누르면 다음 프레임이 나옵니다.";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(4, 16);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(489, 12);
            this.label16.TabIndex = 24;
            this.label16.Text = "키보드에서 숫자키 1부터 0까지 중 하나를 누르면 해당 번호의 색상을 선택할 수 있습니다.";
            // 
            // MakingPixelArtForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1105, 977);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnCopyNextFrameToCurrentFrame);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCopyPreviousFrameToCurrentFrame);
            this.Controls.Add(this.cbxShowPreviousFrame);
            this.Controls.Add(this.lblColorValue);
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
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
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
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
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
        private System.Windows.Forms.Label lblColorValue;
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
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label3;
    }
}

