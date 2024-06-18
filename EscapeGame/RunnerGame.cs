using System;                           // 조윤호, 강동호
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace EscapeGame
{
    public partial class RunnerGame : Form
    {
        int numCells = 32;
        int frameNum = 0;

        bool isTowardToRight = true;

        bool jumping = false;
        int jumpSpeed;
        int force = 12;
        int score = 0;
        int obstacleSpeed = 10;
        Random rand = new Random();
        int position;
        bool isGameOver = false;

        //int frameNum = 0;
        List<System.Drawing.Image> images = new List<System.Drawing.Image>();

        public static int Score { get; set; } // 점수를 저장할 정적 변수

        public RunnerGame()
        {
            InitializeComponent();
            GameReset();
            //LoadImage();
            //trex.Image = images[0];
            tmrImage.Start();
        }

        private void MainGameTimerEvent(object sender, EventArgs e)
        {
            txtScore.Text = "Score: " + score;

            if (jumping && force < 0)
            {
                jumping = false;
            }

            if (jumping)
            {
                jumpSpeed = -12;
                force -= 1;
            }
            else
            {
                jumpSpeed = 12;
            }

            trex.Top += jumpSpeed;

            if (trex.Top >= 335 && !jumping)
            {
                force = 12;
                trex.Top = 335;
                jumpSpeed = 0;
            }

            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "obstacle")
                {
                    x.Left -= obstacleSpeed;

                    if (x.Left + x.Width < -120)
                    {
                        x.Left = this.ClientSize.Width + rand.Next(200, 800);
                        score++;
                    }

                    if (trex.Bounds.IntersectsWith(x.Bounds))
                    {
                        gameTimer.Stop();
                        //trex.Image = Properties.Resources.dead;
                        isGameOver = true;
                        EndGame(score); // 게임 종료 시 점수를 전달
                    }
                }
            }
        }

        private void keyisdown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space && jumping == false)
            {
                jumping = true;
            }
        }

        private void keyisup(object sender, KeyEventArgs e)
        {
            if (jumping == true)
            {
                jumping = false;
            }

            if (e.KeyCode == Keys.R && isGameOver == true)
            {
                GameReset();
            }
        }

        private void GameReset()
        {
            force = 12;
            jumpSpeed = 0;
            jumping = false;
            score = 0;
            obstacleSpeed = 10;
            txtScore.Text = "Score: " + score;
            //trex.Image = Properties.Resources.running;
            isGameOver = false;
            trex.Top = 335;

            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "obstacle")
                {
                    position = this.ClientSize.Width + rand.Next(500, 800) + (x.Width * 10);
                    x.Left = position;
                }
            }

            gameTimer.Start();
        }

        private void EndGame(int finalScore)
        {
            Score = finalScore;
            this.Close();
        }

        private void LoadImage()
        {
            for (int i = 0;i<GlobalSettings.Instance.frameCount;i++)
            {
                images.Add(System.Drawing.Image.FromFile("..\\..\\Resources\\Customize\\" + GlobalSettings.Instance.characterNum + "\\frame" + (i + 1) + ".png"));
            }
        }

        private void tmrImage_Tick(object sender, EventArgs e)
        {
            /*trex.Invalidate();
            frameNum = (frameNum + 1) % GlobalSettings.Instance.frameCount;
            trex.Image = images[frameNum];*/

            trex.Invalidate();
            frameNum = (frameNum + 1) % GlobalSettings.Instance.frameCount;
        }

        private void trex_Paint(object sender, PaintEventArgs e)
        {
            trex.BackColor = Color.FromArgb(0, 255, 255, 255);

            Graphics g = e.Graphics;

            int cellSizeX = trex.Width / numCells;
            int cellSizeY = trex.Height / numCells;

            if (isTowardToRight)
            {
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
            else
            {
                for (int x = 0; x < numCells; x++)
                {
                    for (int y = 0; y < numCells; y++)
                    {
                        using (SolidBrush brush = new SolidBrush(GlobalSettings.Instance.frames[frameNum][x, y]))
                        {
                            e.Graphics.FillRectangle(brush, (numCells - 1 - x) * cellSizeX, y * cellSizeY, cellSizeX, cellSizeY);
                        }
                    }
                }
            }
        }
    }
}


