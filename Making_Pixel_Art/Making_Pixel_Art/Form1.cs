﻿using System;
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
using static System.Windows.Forms.AxHost;

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

        private static Point clickPoint;
        private static Point upPoint;

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

            clickPoint = new Point(e.X, e.Y);

            float w = Math.Abs(clickPoint.X - e.X);
            float h = Math.Abs(clickPoint.Y - e.Y);

            Pen pn = new Pen(currentColor);
            pn.Width = 3;
            Graphics g = pbxCurrentFrame.CreateGraphics();

            if (x >= 0 &&  x < pbxCurrentFrame.Width && y >= 0 && y < pbxCurrentFrame.Height)
            {
                if (e.Button == MouseButtons.Left)
                {
                    /////////////////// 도구 사용 여기에

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
                            currentFrame[cellX, cellY] = Color.FromArgb(0, 255, 255, 255);
                            break;
                        default:
                            break;
                    }
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
            int cellSizeX = pbxCurrentFrame.Width / numCells;
            int cellSizeY = pbxCurrentFrame.Height / numCells;

            float w = Math.Abs(clickPoint.X - e.X);
            float h = Math.Abs(clickPoint.Y - e.Y);

            Pen pn = new Pen(currentColor);
            pn.Width = 3;
            Graphics g = pbxCurrentFrame.CreateGraphics();

            if (e.Button == MouseButtons.Left)
            {
                /////////////////// 도구 사용 여기에

                switch (currentTool)
                {
                    case Tools.Pen:
                        break;
                    case Tools.Line:
                        DrawLine(clickPoint.X, clickPoint.Y, e.X, e.Y, cellSizeX, cellSizeY);
                        break;
                    case Tools.Rectangle:
                        DrawLine(clickPoint.X, clickPoint.Y, e.X, clickPoint.Y, cellSizeX, cellSizeY);
                        DrawLine(e.X, clickPoint.Y, e.X, e.Y, cellSizeX, cellSizeY);
                        DrawLine(e.X, e.Y, clickPoint.X, e.Y, cellSizeX, cellSizeY);
                        DrawLine(clickPoint.X, e.Y, clickPoint.X, clickPoint.Y, cellSizeX, cellSizeY);
                        break;
                    case Tools.Circle:
                        float midX = (float)(clickPoint.X + e.X) / 2;
                        float midY = (float)(clickPoint.Y + e.Y) / 2;
                        w /= 2;
                        h /= 2;

                        int devideNumX = Math.Abs((int)((e.X - clickPoint.X) / (float)cellSizeX));

                        if (devideNumX == 0)
                            break;

                        if(e.X > clickPoint.X)
                        {
                            int tempRangeX = (e.X - clickPoint.X) / devideNumX;

                            for (int x = clickPoint.X; x < e.X; x += tempRangeX)
                            {
                                int cellX = (int)(x / (float)cellSizeX);

                                if (cellX >= 0 && cellX < numCells)
                                {
                                    int ellipsePlusY = (int)(midY + h * (float)Math.Sqrt(1 - ((float)Math.Pow((x - midX), 2) / (float)Math.Pow(w, 2))));
                                    int ellipseMinusY = (int)(midY - h * (float)Math.Sqrt(1 - ((float)Math.Pow((x - midX), 2) / (float)Math.Pow(w, 2))));

                                    int cellPlusY = (int)(ellipsePlusY / (float)cellSizeY);
                                    int cellMinusY = (int)(ellipseMinusY / (float)cellSizeY);

                                    if (cellPlusY >= 0 && cellPlusY < numCells && currentFrame[cellX, cellPlusY] != currentColor)
                                    {
                                        currentFrame[cellX, cellPlusY] = currentColor;
                                    }
                                    if (cellMinusY >= 0 && cellMinusY < numCells && currentFrame[cellX, cellMinusY] != currentColor)
                                    {
                                        currentFrame[cellX, cellMinusY] = currentColor;
                                    }
                                }
                            }
                        }
                        else
                        {
                            int tempRangeX = (clickPoint.X - e.X) / devideNumX;

                            for (int x = e.X; x < clickPoint.X; x += tempRangeX)
                            {
                                int cellX = (int)(x / (float)cellSizeX);

                                if (cellX >= 0 && cellX < numCells)
                                {
                                    int ellipsePlusY = (int)(midY + h * (float)Math.Sqrt(1 - ((float)Math.Pow((x - midX), 2) / (float)Math.Pow(w, 2))));
                                    int ellipseMinusY = (int)(midY - h * (float)Math.Sqrt(1 - ((float)Math.Pow((x - midX), 2) / (float)Math.Pow(w, 2))));

                                    int cellPlusY = (int)(ellipsePlusY / (float)cellSizeY);
                                    int cellMinusY = (int)(ellipseMinusY / (float)cellSizeY);

                                    if (cellPlusY >= 0 && cellPlusY < numCells && currentFrame[cellX, cellPlusY] != currentColor)
                                    {
                                        currentFrame[cellX, cellPlusY] = currentColor;
                                    }
                                    if (cellMinusY >= 0 && cellMinusY < numCells && currentFrame[cellX, cellMinusY] != currentColor)
                                    {
                                        currentFrame[cellX, cellMinusY] = currentColor;
                                    }
                                }
                            }
                        }

                        int devideNumY = Math.Abs((int)((e.Y - clickPoint.Y) / (float)cellSizeY));

                        if (devideNumY == 0)
                            break;

                        if (e.Y > clickPoint.Y)
                        {
                            int tempRangeY = (e.Y - clickPoint.Y) / devideNumY;

                            for (int y = clickPoint.Y; y < e.Y; y += tempRangeY)
                            {
                                int cellY = (int)(y / (float)cellSizeY);

                                if (cellY >= 0 && cellY < numCells)
                                {
                                    int ellipsePlusX = (int)(midX + w * (float)Math.Sqrt(1 - ((float)Math.Pow((y - midY), 2) / (float)Math.Pow(h, 2))));
                                    int ellipseMinusX = (int)(midX - w * (float)Math.Sqrt(1 - ((float)Math.Pow((y - midY), 2) / (float)Math.Pow(h, 2))));

                                    int cellPlusX = (int)(ellipsePlusX / (float)cellSizeX);
                                    int cellMinusX = (int)(ellipseMinusX / (float)cellSizeX);

                                    if (cellPlusX >= 0 && cellPlusX < numCells && currentFrame[cellPlusX, cellY] != currentColor)
                                    {
                                        currentFrame[cellPlusX, cellY] = currentColor;
                                    }
                                    if (cellMinusX >= 0 && cellMinusX < numCells && currentFrame[cellMinusX, cellY] != currentColor)
                                    {
                                        currentFrame[cellMinusX, cellY] = currentColor;
                                    }
                                }
                            }
                        }
                        else
                        {
                            int tempRangeY = (clickPoint.Y - e.Y) / devideNumY;

                            for (int y = e.Y; y < clickPoint.Y; y += tempRangeY)
                            {
                                int cellY = (int)(y / (float)cellSizeY);

                                if (cellY >= 0 && cellY < numCells)
                                {
                                    int ellipsePlusX = (int)(midX + w * (float)Math.Sqrt(1 - ((float)Math.Pow((y - midY), 2) / (float)Math.Pow(h, 2))));
                                    int ellipseMinusX = (int)(midX - w * (float)Math.Sqrt(1 - ((float)Math.Pow((y - midY), 2) / (float)Math.Pow(h, 2))));

                                    int cellPlusX = (int)(ellipsePlusX / (float)cellSizeX);
                                    int cellMinusX = (int)(ellipseMinusX / (float)cellSizeX);

                                    if (cellPlusX >= 0 && cellPlusX < numCells && currentFrame[cellPlusX, cellY] != currentColor)
                                    {
                                        currentFrame[cellPlusX, cellY] = currentColor;
                                    }
                                    if (cellMinusX >= 0 && cellMinusX < numCells && currentFrame[cellMinusX, cellY] != currentColor)
                                    {
                                        currentFrame[cellMinusX, cellY] = currentColor;
                                    }
                                }
                            }
                        }
                        break;
                    case Tools.Eraser:
                        break;
                    default:
                        break;
                }
            }

            pbxCurrentFrame.Invalidate();

            isMouseDown = false;
        }

        private void DrawLine(int startX, int startY, int endX, int endY, int cellSizeX, int cellSizeY)
        {
            float tempX = startX;
            float tempY = startY;
            int devideNumX = Math.Abs((int)((endX - startX) / (float)cellSizeX));
            int devideNumY = Math.Abs((int)((endY - startY) / (float)cellSizeY));
            float devide = (devideNumX > devideNumY ? devideNumX : devideNumY) + 1;
            float tempRangeX = (endX - tempX) / devide;
            float tempRangeY = (endY - tempY) / devide;

            for (int i = 0; i <= devide; i++)
            {
                int cellX = (int)(tempX / (float)cellSizeX);
                int cellY = (int)(tempY / (float)cellSizeY);
                if ((cellX >= 0 && cellX < numCells) && (cellY >= 0 && cellY < numCells))
                {
                    currentFrame[cellX, cellY] = currentColor;
                }
                tempX += tempRangeX;
                tempY += tempRangeY;
            }
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
                float w = Math.Abs(clickPoint.X - e.X);
                float h = Math.Abs(clickPoint.Y - e.Y);

                Pen pn = new Pen(currentColor);
                pn.Width = 3;
                Graphics g = pbxCurrentFrame.CreateGraphics();

                pbxCurrentFrame.Refresh();

                if (e.Button == MouseButtons.Left)
                {
                    /////////////////// 도구 사용 여기에

                    switch (currentTool)
                    {
                        case Tools.Pen:
                            if (x >= 0 && x < pbxCurrentFrame.Width && y >= 0 && y < pbxCurrentFrame.Height)
                            {
                                currentFrame[cellX, cellY] = currentColor;
                                pbxCurrentFrame.Invalidate();
                            }
                            break;
                        case Tools.Line:
                            g.DrawLine(pn, clickPoint.X, clickPoint.Y, e.X, e.Y);
                            break;
                        case Tools.Rectangle:
                            if (e.X > clickPoint.X)
                            {
                                if (e.Y > clickPoint.Y)
                                {
                                    g.DrawRectangle(pn, clickPoint.X, clickPoint.Y, w, h);
                                }
                                else
                                {
                                    g.DrawRectangle(pn, clickPoint.X, e.Y, w, h);
                                }
                            }
                            else
                            {
                                if (e.Y > clickPoint.Y)
                                {
                                    g.DrawRectangle(pn, e.X, clickPoint.Y, w, h);
                                }
                                else
                                {
                                    g.DrawRectangle(pn, e.X, e.Y, w, h);
                                }
                            }
                            break;
                        case Tools.Circle:
                            if (e.X > clickPoint.X)
                            {
                                if (e.Y > clickPoint.Y)
                                {
                                    g.DrawEllipse(pn, clickPoint.X, clickPoint.Y, w, h);
                                }
                                else
                                {
                                    g.DrawEllipse(pn, clickPoint.X, e.Y, w, h);
                                }
                            }
                            else
                            {
                                if (e.Y > clickPoint.Y)
                                {
                                    g.DrawEllipse(pn, e.X, clickPoint.Y, w, h);
                                }
                                else
                                {
                                    g.DrawEllipse(pn, e.X, e.Y, w, h);
                                }
                            }
                            break;
                        case Tools.Eraser:
                            currentFrame[cellX, cellY] = Color.FromArgb(0, 255, 255, 255);
                            break;
                        default:
                            break;
                    }
                }
                else if (e.Button == MouseButtons.Right)
                {
                    if (x >= 0 && x < pbxCurrentFrame.Width && y >= 0 && y < pbxCurrentFrame.Height)
                    {
                        currentFrame[cellX, cellY] = Color.FromArgb(0, 255, 255, 255);
                        pbxCurrentFrame.Invalidate();
                    }
                }

                //pbxCurrentFrame.Invalidate();
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
