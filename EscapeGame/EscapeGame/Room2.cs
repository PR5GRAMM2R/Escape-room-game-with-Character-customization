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
    public partial class Room2 : Form
    {
        int numCells = 32;
        int frameNum = 0;

        bool isTowardToRight = true;

        private HashSet<Keys> pressedKeys = new HashSet<Keys>();
        private Timer movementTimer;
        private const int step = 10; // 캐릭터 이동 거리
        private bool hasReachedTarget = false; // 목표 위치 도달 여부를 추적
        private bool hasKeyToRoom3 = false; // Room3 열쇠 획득 여부
        private Form1 mainForm; // Form1 인스턴스를 저장

        private Rectangle[] walls;

        public Room2(Form1 form)
        {
            InitializeComponent();
            this.mainForm = form; // 전달된 Form1 인스턴스를 저장
            this.KeyDown += new KeyEventHandler(Room2_KeyDown);
            this.KeyUp += new KeyEventHandler(Room2_KeyUp);
            this.KeyPreview = true;

            // 방향키 두 개를 동시에 눌렀을 때 대각선으로 이동시키기 위함
            movementTimer = new Timer();
            movementTimer.Interval = 25; // 25ms 간격으로 움직임을 업데이트
            movementTimer.Tick += MovementTimer_Tick;
            movementTimer.Start();

            walls = new Rectangle[]
           {
                new Rectangle(0, 0, 1000, 30),
                new Rectangle(0, 0, 2, 600),
                new Rectangle(0, 440, 1000, 2),
                new Rectangle(850, 0, 2, 600)

           };

            //images = form.images;           //// 이미지 불러오기
            //pbPlayer.Image = images[0];     //// 초기 이미지 설정

            pbPlayer.BackColor = Color.FromArgb(0, 255, 255, 255);
            //this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
        }

        private void Room2_KeyDown(object sender, KeyEventArgs e)
        {
            pressedKeys.Add(e.KeyCode);
            tmrImage.Start();      //// 이미지 변환 시작
        }

        private void Room2_KeyUp(object sender, KeyEventArgs e)
        {
            pressedKeys.Remove(e.KeyCode);
            tmrImage.Stop();       //// 이미지 변환을 멈춤
        }

        private void MovementTimer_Tick(object sender, EventArgs e)
        {
            MovePlayer();
            MoveMainRoom();
            MoveHint();
            MoveGameMachine();
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
        public void BlackjackGameWon()
        {
            hasKeyToRoom3 = true;
            mainForm.hasKeyToRoom3 = true;
            MessageBox.Show("어디선가 문이 열리는 소리가 들린다.");
        }
        private void MoveHint()
        {
            if (pbPlayer.Bounds.IntersectsWith(pbHint.Bounds))
            {
                movementTimer.Stop();
                MessageBox.Show("게임에서 승리하라.");
                pbPlayer.Top += 30;
                movementTimer.Start();
                pressedKeys.Clear();
            }
        }
        private void MoveGameMachine()
        {
            if (pbPlayer.Bounds.IntersectsWith(pbRunnerGameMachine.Bounds))
            {
                if (hasKeyToRoom3 == false)
                {
                    movementTimer.Stop();
                    Blackjack blackjackgame = new Blackjack(this);
                    blackjackgame.Show();
                    pbPlayer.Top += 40;
                    movementTimer.Start();
                    pressedKeys.Clear();
                }
                else
                {
                    movementTimer.Stop();
                    MessageBox.Show("이럴 시간 없어. 어서 열린 곳으로 가보자.");
                    pbPlayer.Top += 40;
                    movementTimer.Start();
                    pressedKeys.Clear();
                }
            }
        }
        private void MoveMainRoom()
        {
            if (hasReachedTarget == false && pbPlayer.Bounds.IntersectsWith(pbMainp.Bounds))
            {
                hasReachedTarget = true;
                mainForm.SetPlayerPosition(128, 211);
                mainForm.Show();
                this.Hide();
            }
        }

        // gif 움직일 때 사용할 타이머
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

        private void Room2_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainGameMenu main = new MainGameMenu();
            GlobalSettings.Instance.backgroundMusicPlayer.Stop();
            main.Show();
            this.Hide();
        }
    }
}