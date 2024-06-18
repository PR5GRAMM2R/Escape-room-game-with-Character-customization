using System;                       // 배주환, 고현호
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EscapeGame
{
    public partial class SelectCharacter : Form
    {
        int frameNum = 0;
        int numCells = 32;

        int directoryNum = 0;

        int characterNum = 0;
        int framesCount = 0;
        List<Color[,]> frames = new List<Color[,]>();

        string tempDirectory = "..\\..\\Resources\\Customize\\";

        public SelectCharacter()
        {
            InitializeComponent();

            bool isEndDirectory = true;

            while (isEndDirectory)
            {
                string directory = tempDirectory + "\\" + directoryNum.ToString();

                if (Directory.Exists(directory))
                {
                    cbxCharacters.Items.Add(directoryNum.ToString());
                }
                else
                {
                    isEndDirectory = false;
                }

                directoryNum++;
            }

            pbxCharacter.BackColor = Color.FromArgb(0, 255, 255, 255);
        }

        private void characterTimer_Tick(object sender, EventArgs e)
        {
            pbxCharacter.Invalidate();
            frameNum = (frameNum + 1) % framesCount;
        }

        private void pbxCharacter_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            int cellSizeX = pbxCharacter.Width / numCells;
            int cellSizeY = pbxCharacter.Height / numCells;

            if (frames.Count == 0)
                return;

            for (int x = 0; x < numCells; x++)
            {
                for (int y = 0; y < numCells; y++)
                {
                    using (SolidBrush brush = new SolidBrush(frames[frameNum][x, y]))
                    {
                        e.Graphics.FillRectangle(brush, x * cellSizeX, y * cellSizeY, cellSizeX, cellSizeY);
                    }
                }
            }
        }

        private void cbxCharacters_SelectedIndexChanged(object sender, EventArgs e)
        {
            characterTimer.Stop();

            frames.Clear();

            string selectedCharacterNum = cbxCharacters.SelectedItem.ToString();

            characterNum = int.Parse(selectedCharacterNum);

            string directory = tempDirectory + selectedCharacterNum.ToString();

            if (Directory.Exists(directory))
            {
                string[] files = Directory.GetFiles(directory, "*.png");

                if (files != null && files.Length > 0)
                {
                    framesCount = files.Length;

                    foreach (string file in files)
                    {
                        Color[,] frame = (Color[,])GetImageColors(file).Clone();

                        frames.Add(frame);
                    }
                }
            }

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

        private void btnSelectCharacter_Click(object sender, EventArgs e)
        {
            MainGameMenu main = new MainGameMenu();

            if (framesCount <= 0)
            {
                MessageBox.Show("캐릭터를 선택하세요!");
                return;
            }

            GlobalSettings.Instance.characterNum = characterNum;
            GlobalSettings.Instance.frameCount = framesCount;
            GlobalSettings.Instance.frames.Clear();
            GlobalSettings.Instance.frames = frames;

            main.Show();

            this.Hide();
        }

        private void btnCustomize_Click(object sender, EventArgs e)
        {
            MakingPixelArtForm makingPixelArtForm = new MakingPixelArtForm(directoryNum - 1);

            //makingPixelArtForm.FormClosed += MakingPixelArtForm_FormClosed;

            makingPixelArtForm.Show();

            this.Hide();
        }

        private void SelectCharacter_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainGameMenu main = new MainGameMenu();
            main.Show();
            this.Hide();
        }
    }
}
