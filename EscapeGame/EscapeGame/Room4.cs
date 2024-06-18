using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EscapeGame
{
    public partial class Room4 : Form
    {
        int numCells = 32;
        int frameNum = 0;

        bool isTowardToRight = true;

        private HashSet<Keys> pressedKeys = new HashSet<Keys>();
        private Timer movementTimer;
        private const int step = 10; // 캐릭터 이동 거리
        private bool hasReachedTarget = false; // 목표 위치 도달 여부를 추적
        private Form1 mainForm;
        private string correctPassword = "1052"; //금고 비밀번호
        private bool hasKeyToEscape = false;

        private Rectangle[] walls;

        public Room4(Form1 form)
        {
            InitializeComponent();
            this.mainForm = form;
            this.KeyDown += new KeyEventHandler(Room1_KeyDown);
            this.KeyUp += new KeyEventHandler(Room1_KeyUp);
            this.KeyPreview = true;

            // 방향키 두 개를 동시에 눌렀을 때 대각선으로 이동시키기 위함
            movementTimer = new Timer();
            movementTimer.Interval = 25; // 25ms 간격으로 움직임을 업데이트
            movementTimer.Tick += MovementTimer_Tick;
            movementTimer.Start();

            walls = new Rectangle[]
            {
                new Rectangle(0, 0, 1000, 10),
                new Rectangle(0, 0, 2, 600),
                new Rectangle(0, 440, 1000, 2),
                new Rectangle(850, 0, 2, 600)
            };

            //images = form.images;           //// 이미지 불러오기
            //pbPlayer.Image = images[0];     //// 초기 이미지 설정

            pbPlayer.BackColor = Color.FromArgb(0, 255, 255, 255);
            //this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
        }

        private void Room1_KeyDown(object sender, KeyEventArgs e)
        {
            pressedKeys.Add(e.KeyCode);
            tmrImage.Start();      //// 이미지 변환 시작
        }

        private void Room1_KeyUp(object sender, KeyEventArgs e)
        {
            pressedKeys.Remove(e.KeyCode);
            tmrImage.Stop();       //// 이미지 변환을 멈춤
        }

        private void MovementTimer_Tick(object sender, EventArgs e)
        {
            MovePlayer();
            MoveMainRoom();
            MoveHint();
            MoveKeyBox();
        }

        private void MovePlayer()
        {
            Point newPosition = pbPlayer.Location;

            if (pressedKeys.Contains(Keys.Up))
            {
                newPosition.Y -= step;
            }
            if (pressedKeys.Contains(Keys.Down))
            {
                newPosition.Y += step;
            }
            if (pressedKeys.Contains(Keys.Left))
            {
                newPosition.X -= step;
                isTowardToRight = false;
            }
            if (pressedKeys.Contains(Keys.Right))
            {
                newPosition.X += step;
                isTowardToRight = true;
            }

            bool collision = false;
            foreach (var wall in walls)
            {
                if (new Rectangle(newPosition, pbPlayer.Size).IntersectsWith(wall))
                {
                    collision = true;
                    break;
                }
            }

            if (!collision)
            {
                pbPlayer.Location = newPosition;
            }
        }
        private void MoveHint()
        {
            if (pbPlayer.Bounds.IntersectsWith(pbQ1.Bounds))
            {
                movementTimer.Stop();
                MessageBox.Show("멈춘다는 것은 냄비와 같고\n살아있다는 것은 악마와 같다.\n그렇다면, 그물은 무엇일까? \n\n Hint: 영어로 생각해보자."); // stop->pots, live->evil, net->ten 정답 10
                pbPlayer.Top += 30;
                movementTimer.Start();
                pressedKeys.Clear();
            }
            else if (pbPlayer.Bounds.IntersectsWith(pbQ2.Bounds))
            {
                movementTimer.Stop();
                MessageBox.Show("0123 = 1\n8472 = 2\n6854 = 3\n9481 = 3\n8803 = ?\n\n HInt: 숫자의 생김새를 따져보자."); //숫자에 들어가는 동그라미의 개수 정답 5
                pbPlayer.Top += 30;
                movementTimer.Start();
                pressedKeys.Clear();
            }
            else if (pbPlayer.Bounds.IntersectsWith(pbQ3.Bounds))
            {
                movementTimer.Stop();
                MessageBox.Show("오늘은 무슨 요일일까요?\n\n어제가 내일이었으면 좋겠다.\n그럼 오늘이 금요일일 텐데..\n\n 1. 토요일 2. 일요일 3. 월요일 4. 화요일"); // 일요일
                pbPlayer.Top += 30;
                movementTimer.Start();
                pressedKeys.Clear();
            }
        }

        private void MoveKeyBox()
        {
            if (pbPlayer.Bounds.IntersectsWith(pbKeyBox.Bounds))
            {
                movementTimer.Stop();

                if (hasKeyToEscape == false)
                {
                    string inputPassword = ShowPasswordInputBox();
                    if (inputPassword == correctPassword)
                    {
                        MessageBox.Show("금고가 열렸습니다! 열쇠를 획득했습니다.");
                        hasKeyToEscape = true;
                        mainForm.hasKeyToEscape = true;
                    }
                    else
                    {
                        MessageBox.Show("비밀번호가 틀렸습니다. 다시 시도하세요.");
                    }
                }
                else
                {
                    movementTimer.Stop();
                    MessageBox.Show("이미 열쇠를 얻었어. 밖으로 나가자");
                    //pbPlayer.Top += 30;
                    movementTimer.Start();
                    pressedKeys.Clear();
                }

                pbPlayer.Top += 30;
                movementTimer.Start();
                pressedKeys.Clear();
            }
        }

        private string ShowPasswordInputBox()
        {
            Form prompt = new Form();
            prompt.Width = 250;
            prompt.Height = 150;
            prompt.Text = "금고";

            Label textLabel = new Label() { Left = 20, Top = 20, Text = "비밀번호" };
            TextBox inputBox = new TextBox() { Left = 20, Top = 50, Width = 200 };
            Button confirmation = new Button() { Text = "확인", Left = 150, Width = 70, Top = 80 };

            confirmation.Click += (sender, e) => { prompt.Close(); };
            prompt.Controls.Add(confirmation);
            prompt.Controls.Add(textLabel);
            prompt.Controls.Add(inputBox);
            prompt.AcceptButton = confirmation;

            prompt.ShowDialog();
            return inputBox.Text;
        }

        private void MoveMainRoom()
        {
            if (hasReachedTarget == false && pbPlayer.Bounds.IntersectsWith(pbMainp.Bounds))
            {
                hasReachedTarget = true;
                mainForm.SetPlayerPosition(562, 107);
                mainForm.Show();
                this.Hide();
            }
        }

        private void tmrImage_Tick(object sender, EventArgs e)
        {
            //pbPlayer.BackColor = Color.FromArgb(0, 255, 255, 255);
            pbPlayer.Invalidate();
            frameNum = (frameNum + 1) % GlobalSettings.Instance.frameCount;
        }

        private void pbPlayer_Paint(object sender, PaintEventArgs e)
        {
            pbPlayer.BackColor = Color.FromArgb(0, 255, 255, 255);

            Graphics g = e.Graphics;

            int cellSizeX = pbPlayer.Width / numCells;
            int cellSizeY = pbPlayer.Height / numCells;

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

        private void Room4_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainGameMenu main = new MainGameMenu();
            main.Show();
            this.Hide();
        }
    }
}
