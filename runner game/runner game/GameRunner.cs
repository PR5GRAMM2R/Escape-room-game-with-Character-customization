using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace runner_game
{
    public partial class GameRunner : Form
    {
        bool jumping = false;
        int jumpSpeed;
        int force = 12;
        int score = 0;
        int obstacleSpeed = 10;
        Random rand = new Random();
        int position;
        bool isGameOver = false;

        public GameRunner()
        {
            InitializeComponent();

            GameReset();
        }
        
        private void GameTimerEvent(object sender, EventArgs e)
        {
            pbRunner.Top += jumpSpeed;

            lblScore.Text = "점수: " + score;

            if(jumping == true && force < 0)
            {
                jumping = false;
            }

            if (jumping == true)
            {
                jumpSpeed = -12;
                force -= 1;
            }
            else
            {
                jumpSpeed = 12;
            }

            if (pbRunner.Top > 334 && jumping == false)
            {
                force = 12;
                pbRunner.Top = 335;
                jumpSpeed = 0;
            }

            foreach(Control x in this.Controls)
            {
                if(x is PictureBox && (string)x.Tag == "obstacle")
                {
                    x.Left -= obstacleSpeed;

                    if(x.Left < -100)
                    {
                        x.Left = this.ClientSize.Width + rand.Next(200, 500) + (x.Width * 15);
                        score++;
                    }

                    if(pbRunner.Bounds.IntersectsWith(x.Bounds))
                    {
                        gameTimer.Stop();
                        pbRunner.Image = Properties.Resources.dead;
                        lblScore.Text += " 다시 시작하려면 R키를 누르세요.";
                        MessageBox.Show("Game Over!");
                        isGameOver = true;
                    }
                }
            }

            if (score > 5)
            {
                obstacleSpeed = 15;
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
            lblScore.Text = "점수: " + score;
            pbRunner.Image = Properties.Resources.running;
            isGameOver = false;
            pbRunner.Top = 335;

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
    }
}
