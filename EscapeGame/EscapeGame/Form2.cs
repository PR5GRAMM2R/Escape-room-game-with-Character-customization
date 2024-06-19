using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Making_Pixel_Art
{
    public partial class PreviewForm : Form
    {
        int numCells;

        List<Color[,]> Frames = new List<Color[,]>();

        int currentFrameNum = 0;
        int totalFramesNum;

        public PreviewForm(List<Color[,]> Frames, int numCells)
        {
            InitializeComponent();

            this.Frames = Frames;
            currentFrameNum = 0;
            totalFramesNum = Frames.Count;
            this.numCells = numCells;
            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            pbxPreviewFrame.Invalidate();

            lblCurrentFrameNum.Text = (currentFrameNum + 1).ToString() + " / " + totalFramesNum.ToString();

            currentFrameNum = ++currentFrameNum % totalFramesNum;
        }

        private void pbxPreviewFrame_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            int cellSizeX = pbxPreviewFrame.Width / numCells;
            int cellSizeY = pbxPreviewFrame.Height / numCells;

            for (int x = 0; x < numCells; x++)
            {
                for (int y = 0; y < numCells; y++)
                {
                    using (SolidBrush brush = new SolidBrush(Frames[currentFrameNum][x, y]))
                    {
                        e.Graphics.FillRectangle(brush, x * cellSizeX, y * cellSizeY, cellSizeX, cellSizeY);
                    }
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
