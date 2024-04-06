using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test
{
    public partial class Form1 : Form
    {
        private static Point clickPoint;
        private static Point upPoint;
        private static Bitmap originalBmp;
        private static Bitmap drawBmp;
        private static Rectangle imgRect;

        public static PaintTools tooltype {  get; set; }
        public enum PaintTools
        {
            IDLE = default,
            Drawline,
            DrawRectangle,
            DrawCircle
        }

        public List<Rectangle> listRect = new List<Rectangle>();
        public List<Rectangle> tempRect = new List<Rectangle>();
        public List<PaintTools> listTool = new List<PaintTools>();
        public List<PaintTools> tempTool = new List<PaintTools>();

        public Form1()
        {
            InitializeComponent();

            pictureBox1.Image = new Bitmap(Application.StartupPath + @"\DefaultBackGround.png");
            originalBmp = (Bitmap)pictureBox1.Image;
            imgRect = new Rectangle(0, 0, pictureBox1.Width, pictureBox1.Height);
        }

        private void rectangleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tooltype = PaintTools.DrawRectangle;
        }

        private void circleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tooltype = PaintTools.DrawCircle;
        }

        private void lineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tooltype = PaintTools.Drawline;
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                clickPoint = new Point(e.X, e.Y);
            }
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                float w = Math.Abs(clickPoint.X - e.X);
                float h = Math.Abs(clickPoint.Y - e.Y);

                Pen pn = new Pen(Color.Black);
                pn.Width = 3;
                Graphics g = pictureBox1.CreateGraphics();
                pictureBox1.Refresh();

                if(tooltype == PaintTools.DrawRectangle)
                {
                    if(e.X > clickPoint.X)
                    {
                        if(e.Y > clickPoint.Y)
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
                }
                else if (tooltype == PaintTools.DrawCircle)
                {
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
                }
                else if(tooltype == PaintTools.Drawline)
                {
                    g.DrawLine(pn, clickPoint.X, clickPoint.Y, e.X, e.Y);
                }
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                upPoint.X = e.X;
                upPoint.Y = e.Y;

                float w = Math.Abs(clickPoint.X - e.X);
                float h = Math.Abs(clickPoint.Y - e.Y);

                Pen pn = new Pen(Color.Black);
                pn.Width = 3;
                Rectangle rect = new Rectangle();
                Graphics g = pictureBox1.CreateGraphics();

                if(tooltype == PaintTools.DrawRectangle)
                {
                    if(e.X > clickPoint.X)
                    {
                        if(e.Y > clickPoint.Y)
                        {
                            rect = new Rectangle(clickPoint.X, clickPoint.Y, (int)w, (int)h);
                        }
                        else
                        {
                            rect = new Rectangle(clickPoint.X, e.Y, (int)w, (int)h);
                        }
                    }
                    else
                    {
                        if (e.Y > clickPoint.Y)
                        {
                            rect = new Rectangle(e.X, clickPoint.Y, (int)w, (int)h);
                        }
                        else
                        {
                            rect = new Rectangle(e.X, e.Y, (int)w, (int)h);
                        }
                    }
                }
                else if(tooltype == PaintTools.DrawCircle)
                {
                    if (e.X > clickPoint.X)
                    {
                        if (e.Y > clickPoint.Y)
                        {
                            rect = new Rectangle(clickPoint.X, clickPoint.Y, (int)w, (int)h);
                        }
                        else
                        {
                            rect = new Rectangle(clickPoint.X, e.Y, (int)w, (int)h);
                        }
                    }
                    else
                    {
                        if (e.Y > clickPoint.Y)
                        {
                            rect = new Rectangle(e.X, clickPoint.Y, (int)w, (int)h);
                        }
                        else
                        {
                            rect = new Rectangle(e.X, e.Y, (int)w, (int)h);
                        }
                    }
                }
                else if(tooltype == PaintTools.Drawline)
                {
                    rect = new Rectangle(clickPoint.X, clickPoint.Y, clickPoint.X + e.X, clickPoint.Y + e.Y);
                }

                listRect.Add(rect);
                listTool.Add(tooltype);
                DrawBitmap();
            }
        }

        private void DrawBitmap()
        {
            if(originalBmp != null)
            {
                drawBmp = (Bitmap)originalBmp.Clone();

                for(int i = 0; i < listTool.Count; i++)
                {
                    double wRatio = (double)originalBmp.Width / pictureBox1.Width;
                    double hRatio = (double)originalBmp.Height / pictureBox1.Height;

                    Rectangle rect = new Rectangle((int)(listRect[i].X * wRatio), (int)(listRect[i].Y * hRatio),
                                                    (int)(listRect[i].Width * wRatio), (int)(listRect[i].Height * hRatio));
                    Pen pn = new Pen(Color.Black);
                    pn.Width = (float)(3 * wRatio);

                    using (Graphics g = Graphics.FromImage(drawBmp))
                    {
                        if (listTool[i] == PaintTools.DrawRectangle) g.DrawRectangle(pn, rect);
                        else if (listTool[i] == PaintTools.DrawCircle) g.DrawEllipse(pn, rect);
                        else if (listTool[i] == PaintTools.Drawline) g.DrawLine(pn, new Point(rect.X, rect.Y), new Point(rect.Width - rect.X, rect.Height - rect.Y));
                    }
                }

                pictureBox1.Image = drawBmp;
            }
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            if(originalBmp != null)
            {
                e.Graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                if(listRect.Count > 0 && drawBmp != null)
                {
                    e.Graphics.DrawImage(drawBmp, imgRect);
                }
                else
                {
                    e.Graphics.DrawImage(originalBmp, imgRect);
                }
            }
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(listRect.Count > 0 && listRect.Count <= listRect.Count + tempRect.Count)
            {
                tempRect.Add(listRect[listRect.Count - 1]);
                listRect.RemoveAt(listRect.Count - 1);
                tempTool.Add(listTool[listTool.Count - 1]);
                listTool.RemoveAt(listTool.Count - 1);
                pictureBox1.Refresh();
                DrawBitmap();
            }
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tempRect.Count >= 0 && listRect.Count < listRect.Count + tempRect.Count)
            {
                listRect.Add(tempRect[tempRect.Count - 1]);
                tempRect.RemoveAt(tempRect.Count - 1);
                listTool.Add(tempTool[tempTool.Count - 1]);
                tempTool.RemoveAt(tempTool.Count - 1);
                pictureBox1.Refresh();
                DrawBitmap();
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.Control && !e.Shift && e.KeyCode == Keys.Z)
            {
                if(listRect.Count > 0 && listRect.Count <= listRect.Count + tempRect.Count)
                {
                    tempRect.Add(listRect[listRect.Count - 1]);
                    listRect.RemoveAt(listRect.Count - 1);
                    tempTool.Add(listTool[listTool.Count - 1]);
                    listTool.RemoveAt(listTool.Count - 1);
                    pictureBox1.Refresh();
                    DrawBitmap();
                }
            }
            if(e.Control && e.Shift && e.KeyCode == Keys.Z)
            {
                if(listRect.Count >= 0 && listRect.Count < listRect.Count + tempRect.Count)
                {
                    listRect.Add(tempRect[tempRect.Count - 1]);
                    tempRect.RemoveAt(tempRect.Count - 1);
                    listTool.Add(tempTool[tempTool.Count - 1]);
                    tempTool.RemoveAt(tempTool.Count - 1);
                    pictureBox1.Refresh();
                    DrawBitmap();
                }
            }
        }
    }
}
