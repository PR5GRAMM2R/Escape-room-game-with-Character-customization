using System;                       // 광운대학교 소프트웨어학과
using System.Collections.Generic;   //
using System.ComponentModel;        //
using System.Data;                  //
using System.Drawing;               // 응용 소프트웨어 실습
using System.IO;                    // 10 조
using System.Linq;                  //
using System.Text;                  //
using System.Threading.Tasks;       //
using System.Windows.Forms;         // 조윤호, 배주환, 강동호, 고현호

namespace EscapeGame
{
    public partial class MainGameMenu : Form
    {
        /*public int characterNum = 0;
        public int frameCount = 0;
        public List<Color[,]> frames = new List<Color[,]>();*/

        int frameNum = 0;
        int numCells = 32;

        public MainGameMenu()
        {
            InitializeComponent();
            label1.BackColor = Color.FromArgb(0, 255, 255, 255);
            /*btnStart.ForeColor = Color.FromArgb(0, 255, 255, 255);
            btnCharacter.ForeColor = Color.FromArgb(0, 255, 255, 255);
            btnExit.ForeColor = Color.FromArgb(0, 255, 255, 255);*/

            pbxCharacter.BackColor = Color.FromArgb(0, 255, 255, 255);

            GlobalSettings.Instance.frames.Clear();

            string directory = "..\\..\\Resources\\Customize\\" + GlobalSettings.Instance.characterNum.ToString();

            if (Directory.Exists(directory))
            {
                string[] files = Directory.GetFiles(directory, "*.png");

                if (files != null && files.Length > 0)
                {
                    GlobalSettings.Instance.frameCount = files.Length;

                    foreach (string file in files)
                    {
                        Color[,] frame = (Color[,])GetImageColors(file).Clone();

                        GlobalSettings.Instance.frames.Add(frame);
                    }
                }
            }

            //MessageBox.Show(GlobalSettings.Instance.frames.Count.ToString());

            characterTimer.Start();
        }

        private Color[,] GetImageColors(string filePath)
        {
            Bitmap bitmap = new Bitmap(filePath);
            int width = bitmap.Width;
            int height = bitmap.Height;
            Color[,] colors = new Color[width, height];

            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    colors[x, y] = bitmap.GetPixel(x, y);
                }
            }

            return colors;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            Form1 gameForm = new Form1();
            gameForm.Show();
            this.Hide();
        }

        private void btnCharacter_Click(object sender, EventArgs e)
        {
            SelectCharacter selectCharacter = new SelectCharacter();
            selectCharacter.Show();
            //DialogResult dialogResult = selectCharacter.ShowDialog();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void characterTimer_Tick(object sender, EventArgs e)
        {
            pbxCharacter.Invalidate();
            frameNum = (frameNum + 1) % GlobalSettings.Instance.frameCount;
        }

        private void pbxCharacter_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            int cellSizeX = pbxCharacter.Width / numCells;
            int cellSizeY = pbxCharacter.Height / numCells;

            for (int x = 0; x < numCells; x++)
            {
                for (int y = 0; y < numCells; y++)
                {
                    using (SolidBrush brush = new SolidBrush(GlobalSettings.Instance.frames[frameNum][x, y]))
                    {
                        e.Graphics.FillRectangle(brush, x * cellSizeX, y * cellSizeY, cellSizeX, cellSizeY);
                    }
                }
            }
        }
    }
}
