using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace runner_game
{
    public partial class mainPlay : Form
    {
        
        bool jumping = false, goleft = false, goright =false;
        int playerspeed = 7;
        int jumpSpeed;
        int force = 12;
        int score = 0;
        int obstacleSpeed = 10;
        Random rand = new Random();
        int position;
        bool isGameOver = false;



        public mainPlay()
        {
            InitializeComponent();

            GameReset();
        }
        
        private void GameTimerEvent(object sender, EventArgs e)
        {
            pbRunner.Top += jumpSpeed;

            lblScore.Text = "점수: " + score;

            //점프 한다.
            if(jumping == true && force < 0) //힘이 0이고 점프 중이라면 점핑을 바꾼다.?
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

            if (pbRunner.Top > 334 && jumping == false) // 러너의 최고 점을 알려준다.
            {
                force = 12;
                pbRunner.Top = 335;
                jumpSpeed = 0;
            }
            if (goleft)
            {
                pbRunner.Left -= playerspeed;
            }
            if (goright)
            {
                pbRunner.Left += playerspeed;
            }

            //여기에서는 타임 부분에다가 했는데 하다가 에러나면 바꾸어야함. 키 다운 쪽으로 옮겨야함
            /*foreach (Control x in this.Controls)
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
            }*/
        }

        //키 다운 키가 움직이면 작용
        private void keyisdown(object sender, KeyEventArgs e)
        {

                if (e.KeyCode == Keys.Space && jumping == false)
            {
                jumping = true;
            }
            if (e.KeyCode == Keys.Left)
            {
                goleft = true;
            }
            if (e.KeyCode == Keys.Right)
            {
                goright = true;
            }
            foreach (Control control in this.Controls)
            {
                if (control is PictureBox)
                {
                    if ((string)control.Tag == "obstacle")
                    {
                        if (pbRunner.Bounds.IntersectsWith(control.Bounds))
                        {
                            BlackJack blackJack = new BlackJack();
                            blackJack.Show();

                            this.Hide();

                        }
                    }

                }
            }
        }

        private void pbObstacle1_Click(object sender, EventArgs e)
        {

        }

        //점프를 한 다음 다시 점프가 가능하게 만들어줌
        private void keyisup(object sender, KeyEventArgs e)
        {
            if (jumping == true)
            {
                jumping = false;
            }
            if (e.KeyCode == Keys.Left)
            {
                goleft = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                goright = false;
            }

            //게임 재 시작
            if (e.KeyCode == Keys.R && isGameOver == true)
            {
                GameReset();
            }
        }

        //게임 시작 시 초기화 부분
        private void GameReset()
        {
            force = 12;
            jumpSpeed = 0;
            jumping = false;
            score = 0;
            obstacleSpeed = 10; //장애물 스피드
            lblScore.Text = "점수: " + score;
            pbRunner.Image = Properties.Resources.running;
            isGameOver = false;
            pbRunner.Top = 335; //러너의 최고점?


            /*foreach (Control control in this.Controls)
            {

                if (control is PictureBox && (string)control.Tag == "obstacle")
                {
                    position = this.ClientSize.Width + rand.Next(500, 800) + (control.Width * 10);

                    control.Left = position;
                }
            }*/
           

            gameTimer.Start();

        }
    }
}
