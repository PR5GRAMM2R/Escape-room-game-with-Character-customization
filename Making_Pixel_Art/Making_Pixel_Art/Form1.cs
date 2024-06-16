using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Making_Pixel_Art
{
    public enum Tools
    {
        Pen,
        Line,
        Rectangle,
        Circle,
        Eraser
    }

    public partial class MakingPixelArtForm : Form
    {
        private List<Button> colorButtons;
        private Button currentColorButton;
        private Color currentColor;             // 현재 사용하고 있는 색상

        private List<Button> toolButtons;
        private Button currentToolButton;
        private Tools currentTool;              // 현재 사용하고 있는 도구

        private bool isMouseDown = false;

        private const int numCells = 32;

        private int currentFrameNum = 0;
        private int totalFramesNum = 0;
        Color[,] currentFrame = new Color[numCells, numCells];      // 현재 프레임
        List<Color[,]> Frames = new List<Color[,]> ();              // 그려온 프레임들을 저장

        public MakingPixelArtForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnTool01.Tag = Tools.Pen;
            btnTool02.Tag = Tools.Line;
            btnTool03.Tag = Tools.Rectangle;
            btnTool04.Tag = Tools.Circle;
            btnTool05.Tag = Tools.Eraser;
            btnTool06.Tag = Tools.Eraser;   //////////

            pbxCurrentFrame.BackColor = Color.FromArgb(0, 255, 255, 255);       // 색상을 전부 투명으로 설정
            pbxPreviousFrame.BackColor = Color.FromArgb(0, 255, 255, 255);
            pbxNextFrame.BackColor = Color.FromArgb(0, 255, 255, 255);

            this.colorButtons = GetAllButtons(this.gbxPalette);

            btnColor01.BackColor = Color.Black;
            btnColor01.PerformClick();

            this.toolButtons = GetAllButtons(this.gbxTools);

            btnTool01.PerformClick();

            Color[,] tempFrame = new Color[numCells, numCells];
            Frames.Add(tempFrame);
            totalFramesNum++;
        }

        private List<Button> GetAllButtons(Control control)     // 해당 group 내의 버튼들을 가져옴.
        {
            List<Button> buttons = new List<Button>();

            foreach (Control c in control.Controls)
            {
                if(c is Button && c.Text != "Edit")
                {
                    c.BackColor = Color.White;
                    buttons.Add((Button)c);
                }
            }

            return buttons;
        }

        ////////////////////////////////////////////////////////////////////////////////////////////

        ////////////////////////////////////////////////////////////////////////////////////////////

        private void btnColor01_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;

            if(clickedButton != null )
            {
                foreach(Button button in colorButtons)
                {
                    button.FlatStyle = FlatStyle.Standard;
                    button.FlatAppearance.BorderSize = 0;
                }

                clickedButton.FlatStyle = FlatStyle.Flat;
                clickedButton.FlatAppearance.BorderSize = 3;

                currentColorButton = clickedButton;
                currentColor = clickedButton.BackColor;

                clickedButton.ForeColor = Color.FromArgb(255 - clickedButton.BackColor.R, 255 - clickedButton.BackColor.G, 255 - clickedButton.BackColor.B);
            }

            lblColorValue.Text = "현재 색상 : ( " + currentColor.R + " . " + currentColor.G + " . " + currentColor.B + " )";
        }

        private void btnColorEdit_Click(object sender, EventArgs e)
        {
            cld.Color = currentColorButton.BackColor;
            cld.ShowDialog();
            currentColorButton.BackColor = cld.Color;
            currentColor = currentColorButton.BackColor;
            currentColorButton.ForeColor = Color.FromArgb(255 - currentColorButton.BackColor.R, 255 - currentColorButton.BackColor.G, 255 - currentColorButton.BackColor.B);
            lblColorValue.Text = "현재 색상 : ( " + currentColor.R + " . " + currentColor.G + " . " + currentColor.B + " )";
        }

        private void btnTool01_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;

            if (clickedButton != null)
            {
                foreach (Button button in toolButtons)
                {
                    button.FlatStyle = FlatStyle.Standard;
                    button.FlatAppearance.BorderSize = 0;
                }

                clickedButton.FlatStyle = FlatStyle.Flat;
                clickedButton.FlatAppearance.BorderSize = 3;

                currentToolButton = clickedButton;
                currentTool = (Tools)clickedButton.Tag;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        ////////////////////////////////////////////////////////////////////////////////////////////
        
        //                  현재 Frame (PictureBox) 에 그리기
        ////////////////////////////////////////////////////////////////////////////////////////////

        private void pbxCurrentFrame_MouseDown(object sender, MouseEventArgs e)
        {
            int cellSizeX = pbxCurrentFrame.Width / numCells;
            int cellSizeY = pbxCurrentFrame.Height / numCells;

            int x = e.X;
            int y = e.Y;

            int cellX = x / cellSizeX;
            int cellY = y / cellSizeY;

            if (x >= 0 &&  x < pbxCurrentFrame.Width && y >= 0 && y < pbxCurrentFrame.Height)
            {
                if (e.Button == MouseButtons.Left)
                {
                    /////////////////// 도구 사용 여기에
                    
                    UseTools(cellX, cellY);
                }
                else if(e.Button == MouseButtons.Right)
                {
                    currentFrame[cellX, cellY] = Color.FromArgb(0, 255, 255, 255);
                }

                pbxCurrentFrame.Invalidate();
            }

            isMouseDown = true;
        }

        private void pbxCurrentFrame_MouseUp(object sender, MouseEventArgs e)
        {
            isMouseDown = false;
        }

        private void pbxCurrentFrame_MouseMove(object sender, MouseEventArgs e)
        {
            int cellSizeX = pbxCurrentFrame.Width / numCells;
            int cellSizeY = pbxCurrentFrame.Height / numCells;

            int x = e.X;
            int y = e.Y;
            
            int cellX = x / cellSizeX;
            int cellY = y / cellSizeY;

            if (isMouseDown)
            {
                if (x >= 0 && x < pbxCurrentFrame.Width && y >= 0 && y < pbxCurrentFrame.Height)
                {
                    Color previousColor = currentFrame[cellX, cellY];

                    if (e.Button == MouseButtons.Left)
                    {
                        /////////////////// 도구 사용 여기에

                        UseTools(cellX, cellY);
                    }
                    else if (e.Button == MouseButtons.Right)
                    {
                        currentFrame[cellX, cellY] = Color.FromArgb(0, 255, 255, 255);
                    }
                }

                pbxCurrentFrame.Invalidate();
            }
        }

        ////////////////////////////////////////////////////////////////////////////////////////////
        
        //                  프레임 이동 시 Current, Previous, Next PictureBox 에 그리기
        ////////////////////////////////////////////////////////////////////////////////////////////

        private void pbxCurrentFrame_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            int cellSizeX = pbxCurrentFrame.Width / numCells;
            int cellSizeY = pbxCurrentFrame.Height / numCells;

            for (int x = 0; x < numCells; x++)
            {
                for (int y = 0; y < numCells; y++)
                {
                    using (SolidBrush brush = new SolidBrush(currentFrame[x, y]))
                    {
                        e.Graphics.FillRectangle(brush, x * cellSizeX, y * cellSizeY, cellSizeX, cellSizeY);
                    }
                }
            }

            using (Pen gridPen = new Pen(Color.Black))
            {
                // Draw horizontal lines
                for (int x = 0; x < numCells; x++)
                {
                    g.DrawLine(gridPen, 0, x * cellSizeX, pbxCurrentFrame.Width, x * cellSizeX);
                }
                g.DrawLine(gridPen, 0, numCells * cellSizeX - 1, pbxCurrentFrame.Width - 1, numCells * cellSizeX - 1);

                // Draw vertical lines
                for (int y = 0; y < numCells; y++)
                {
                    g.DrawLine(gridPen, y * cellSizeY, 0, y * cellSizeY, pbxCurrentFrame.Height);
                }
                g.DrawLine(gridPen, numCells * cellSizeY - 1, 0, numCells * cellSizeY - 1, pbxCurrentFrame.Height - 1);
            }
        }
        private void pbxPreviousFrame_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            int cellSizeX = pbxPreviousFrame.Width / numCells;
            int cellSizeY = pbxPreviousFrame.Height / numCells;

            if (currentFrameNum > 0 && currentFrameNum < totalFramesNum)
            {
                for (int x = 0; x < numCells; x++)
                {
                    for (int y = 0; y < numCells; y++)
                    {
                        using (SolidBrush brush = new SolidBrush(Frames[currentFrameNum - 1][x, y]))
                        {
                            e.Graphics.FillRectangle(brush, x * cellSizeX, y * cellSizeY, cellSizeX, cellSizeY);
                        }
                    }
                }
            }

            using (Pen gridPen = new Pen(Color.Black))
            {
                // Draw horizontal lines
                for (int x = 0; x < numCells; x++)
                {
                    g.DrawLine(gridPen, 0, x * cellSizeX, pbxPreviousFrame.Width, x * cellSizeX);
                }
                g.DrawLine(gridPen, 0, numCells * cellSizeX - 1, pbxPreviousFrame.Width - 1, numCells * cellSizeX - 1);

                // Draw vertical lines
                for (int y = 0; y < numCells; y++)
                {
                    g.DrawLine(gridPen, y * cellSizeY, 0, y * cellSizeY, pbxPreviousFrame.Height);
                }
                g.DrawLine(gridPen, numCells * cellSizeY - 1, 0, numCells * cellSizeY - 1, pbxPreviousFrame.Height - 1);
            }
        }

        private void pbxNextFrame_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            int cellSizeX = pbxNextFrame.Width / numCells;
            int cellSizeY = pbxNextFrame.Height / numCells;

            if (currentFrameNum < totalFramesNum - 1)
            {
                for (int x = 0; x < numCells; x++)
                {
                    for (int y = 0; y < numCells; y++)
                    {
                        using (SolidBrush brush = new SolidBrush(Frames[currentFrameNum + 1][x, y]))
                        {
                            e.Graphics.FillRectangle(brush, x * cellSizeX, y * cellSizeY, cellSizeX, cellSizeY);
                        }
                    }
                }
            }
            /*else
            {
                for (int x = 0; x < numCells; x++)
                {
                    for (int y = 0; y < numCells; y++)
                    {
                        using (SolidBrush brush = new SolidBrush(Color.FromArgb(0, 255, 255, 255)))
                        {
                            e.Graphics.FillRectangle(brush, x * cellSizeX, y * cellSizeY, cellSizeX, cellSizeY);
                        }
                    }
                }
            }*/

            using (Pen gridPen = new Pen(Color.Black))
            {
                // Draw horizontal lines
                for (int x = 0; x < numCells; x++)
                {
                    g.DrawLine(gridPen, 0, x * cellSizeX, pbxNextFrame.Width, x * cellSizeX);
                }
                g.DrawLine(gridPen, 0, numCells * cellSizeX - 1, pbxNextFrame.Width - 1, numCells * cellSizeX - 1);

                // Draw vertical lines
                for (int y = 0; y < numCells; y++)
                {
                    g.DrawLine(gridPen, y * cellSizeY, 0, y * cellSizeY, pbxNextFrame.Height);
                }
                g.DrawLine(gridPen, numCells * cellSizeY - 1, 0, numCells * cellSizeY - 1, pbxNextFrame.Height - 1);
            }
        }

        ////////////////////////////////////////////////////////////////////////////////////////////

        //                  Next Frame 버튼과 Previous Frame 버튼에 대한 동작
        ////////////////////////////////////////////////////////////////////////////////////////////

        private void btnNext_Click(object sender, EventArgs e)
        {
            if(currentFrameNum < totalFramesNum - 1)
            {
                Color[,] frame = new Color[numCells, numCells];
                frame = (Color[,])currentFrame.Clone();

                Frames[currentFrameNum] = frame;

                currentFrameNum++;

                for (int i = 0; i < numCells; i++)
                    for (int j = 0; j < numCells; j++)
                        currentFrame[i, j] = Frames[currentFrameNum][i, j];
            }

            lblCurrentFrameNum.Text = (currentFrameNum + 1).ToString() + " / " + totalFramesNum.ToString();

            pbxCurrentFrame.Invalidate();
            pbxPreviousFrame.Invalidate();
            pbxNextFrame.Invalidate();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if(currentFrameNum > 0)
            {
                Color[,] frame = new Color[numCells, numCells];
                frame = (Color[,])currentFrame.Clone();
                                
                Frames[currentFrameNum] = frame;

                currentFrameNum--;

                for (int i = 0; i < numCells; i++)
                    for (int j = 0; j < numCells; j++)
                        currentFrame[i, j] = Frames[currentFrameNum][i, j];
            }

            lblCurrentFrameNum.Text = (currentFrameNum + 1).ToString() + " / " + totalFramesNum.ToString();

            pbxCurrentFrame.Invalidate();
            pbxPreviousFrame.Invalidate();
            pbxNextFrame.Invalidate();
        }

        ////////////////////////////////////////////////////////////////////////////////////////////

        //                  기존의 Frame 다음에 새로운 프레임 추가 & 기존의 Frame 제거
        ////////////////////////////////////////////////////////////////////////////////////////////

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Color[,] frame = new Color[numCells, numCells];
            frame = (Color[,])currentFrame.Clone();

            Frames[currentFrameNum] = frame;

            for (int i = 0; i < numCells; i++)
                for (int j = 0; j < numCells; j++)
                    currentFrame[i, j] = Color.FromArgb(0, 255, 255, 255);

            Color[,] tempFrame = new Color[numCells, numCells];
            tempFrame = (Color[,])currentFrame.Clone();
            if (currentFrameNum == totalFramesNum - 1)
            {
                currentFrameNum++;
                Frames.Add(tempFrame);
            }
            else
            {
                currentFrameNum++;
                Frames.Insert(currentFrameNum, frame);
            }

            totalFramesNum++;

            lblCurrentFrameNum.Text = (currentFrameNum + 1).ToString() + " / " + totalFramesNum.ToString();

            pbxCurrentFrame.Invalidate();
            pbxPreviousFrame.Invalidate();
            pbxNextFrame.Invalidate();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if(currentFrameNum > 0)
            {
                Frames.RemoveAt(currentFrameNum);

                if (currentFrameNum == totalFramesNum - 1)
                {
                    currentFrameNum--;
                }

                for (int i = 0; i < numCells; i++)
                    for (int j = 0; j < numCells; j++)
                        currentFrame[i, j] = Frames[currentFrameNum][i, j];

                totalFramesNum--;
            }
            else
            {
                for (int i = 0; i < numCells; i++)
                    for (int j = 0; j < numCells; j++)
                        currentFrame[i, j] = Color.FromArgb(0, 255, 255, 255);
            }

            lblCurrentFrameNum.Text = (currentFrameNum + 1).ToString() + " / " + totalFramesNum.ToString();

            pbxCurrentFrame.Invalidate();
            pbxPreviousFrame.Invalidate();
            pbxNextFrame.Invalidate();
        }

        ////////////////////////////////////////////////////////////////////////////////////////////

        //                  도형을 그리는 기능들
        ////////////////////////////////////////////////////////////////////////////////////////////

        private void UseTools(int cellX, int cellY)
        {
            switch (currentTool)
            {
                case Tools.Pen:
                    currentFrame[cellX, cellY] = currentColor;
                    break;
                case Tools.Line:
                    break;
                case Tools.Rectangle:
                    break;
                case Tools.Circle:
                    break;
                case Tools.Eraser:
                    break;
                default:
                    break;
            }
        }

        ////////////////////////////////////////////////////////////////////////////////////////////

        //                  Previous Frame 또는 Next Frame 의 그림을 Current Frame 에 복사하기
        ////////////////////////////////////////////////////////////////////////////////////////////

        private void btnCopyPreviousFrameToCurrentFrame_Click(object sender, EventArgs e)
        {
            if(currentFrameNum != 0)
            {
                for (int i = 0; i < numCells; i++)
                    for (int j = 0; j < numCells; j++)
                        currentFrame[i, j] = Frames[currentFrameNum - 1][i, j];

                pbxCurrentFrame.Invalidate();
            }
        }

        private void btnCopyNextFrameToCurrentFrame_Click(object sender, EventArgs e)
        {
            if (currentFrameNum != totalFramesNum - 1)
            {
                for (int i = 0; i < numCells; i++)
                    for (int j = 0; j < numCells; j++)
                        currentFrame[i, j] = Frames[currentFrameNum + 1][i, j];

                pbxCurrentFrame.Invalidate();
            }
        }

        ////////////////////////////////////////////////////////////////////////////////////////////

        //                  Preview 을 위한 창을 띄우기 (Modal 창)
        ////////////////////////////////////////////////////////////////////////////////////////////

        private void btnPreview_Click(object sender, EventArgs e)
        {
            Color[,] frame = new Color[numCells, numCells];
            frame = (Color[,])currentFrame.Clone();

            Frames[currentFrameNum] = frame;

            PreviewForm pvf = new PreviewForm(Frames, numCells);
            DialogResult dialogResult = pvf.ShowDialog();
        }

        ////////////////////////////////////////////////////////////////////////////////////////////

        //                  그렸던 Image 들을 순차적으로 저장하기
        ////////////////////////////////////////////////////////////////////////////////////////////

        private void btnSaveAndExit_Click(object sender, EventArgs e)
        {
            Color[,] frame = new Color[numCells, numCells];
            frame = (Color[,])currentFrame.Clone();

            Frames[currentFrameNum] = frame;

            int customizeNum = 0;

            string directory = "..\\..\\Resources\\Customize\\" + customizeNum.ToString();

            if (!Directory.Exists(directory))
            {
                Directory.CreateDirectory(directory);
            }
            else
            {
                Directory.Delete(directory, true);
                Directory.CreateDirectory(directory);
            }

            for (int i=0;i<totalFramesNum;i++)
            {
                Bitmap bitmap = new Bitmap(numCells, numCells);
                for(int x=0;x<numCells;x++)
                {
                    for (int y=0;y<numCells;y++)
                    {
                        bitmap.SetPixel(x, y, Frames[i][x, y]);
                    }
                }

                try
                {
                    bitmap.Save(directory + "\\" + "frame" + (i+1) + ".png", System.Drawing.Imaging.ImageFormat.Png);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            Application.Exit();
        }
    }
}
