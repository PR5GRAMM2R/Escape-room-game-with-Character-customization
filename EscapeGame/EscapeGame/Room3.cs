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
    public partial class Room3 : Form
    {
        private HashSet<Keys> pressedKeys = new HashSet<Keys>();
        private Timer movementTimer;
        private const int step = 10; // 캐릭터 이동 거리
        private bool hasReachedTarget = false; // 목표 위치 도달 여부를 추적
        private bool hasKeyToRoom4 = false; // Room2 열쇠 획득 여부
        private Form1 mainForm; // Form1 인스턴스를 저장

        private List<System.Drawing.Image> images = new List<System.Drawing.Image>();     //// gif처럼 나타낼 이미지를 저장하는 List
        private int imgClock = 0;

        public Room3(Form1 form)
        {
            InitializeComponent();
            this.mainForm = form; // 전달된 Form1 인스턴스를 저장
            this.KeyDown += new KeyEventHandler(Room3_KeyDown);
            this.KeyUp += new KeyEventHandler(Room3_KeyUp);
            this.KeyPreview = true;

            // 방향키 두 개를 동시에 눌렀을 때 대각선으로 이동시키기 위함
            movementTimer = new Timer();
            movementTimer.Interval = 20; // 20ms 간격으로 움직임을 업데이트
            movementTimer.Tick += MovementTimer_Tick;
            movementTimer.Start();

            images = form.images;           //// 이미지 불러오기
            pbPlayer.Image = images[0];     //// 초기 이미지 설정
        }

        private void Room3_KeyDown(object sender, KeyEventArgs e)
        {
            pressedKeys.Add(e.KeyCode);
            tmrImage.Start();      //// 이미지 변환 시작
        }

        private void Room3_KeyUp(object sender, KeyEventArgs e)
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
            if (pressedKeys.Contains(Keys.Up))
            {
                pbPlayer.Top -= step;
            }
            if (pressedKeys.Contains(Keys.Down))
            {
                pbPlayer.Top += step;
            }
            if (pressedKeys.Contains(Keys.Left))
            {
                pbPlayer.Left -= step;
            }
            if (pressedKeys.Contains(Keys.Right))
            {
                pbPlayer.Left += step;
            }
        }
        public void tictactoeGameWon()
        {
            hasKeyToRoom4 = true;
            mainForm.hasKeyToRoom4 = true;
            MessageBox.Show("어디선가 문이 열리는 소리가 들린다.");
        }

        private void MoveHint()
        {
            if (pbPlayer.Bounds.IntersectsWith(pbHint.Bounds))
            {
                movementTimer.Stop();
                MessageBox.Show("게임에서 승리한다면..");
                pbPlayer.Top += 20;
                movementTimer.Start();
                pressedKeys.Clear();
            }
        }

        private void MoveGameMachine()
        {
            if (pbPlayer.Bounds.IntersectsWith(pbRunnerGameMachine.Bounds))
            {
                if (hasKeyToRoom4 == false)
                {
                    movementTimer.Stop();
                    Tic_Tac_Toe tic_Tac_Toe = new Tic_Tac_Toe(this);
                    tic_Tac_Toe.Show();
                    pbPlayer.Top += 20;
                    movementTimer.Start();
                    pressedKeys.Clear();
                }
                else
                {
                    movementTimer.Stop();
                    MessageBox.Show("어서 열린 곳으로 가보자.");
                    pbPlayer.Top += 20;
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
                mainForm.SetPlayerPosition(307, 116);
                mainForm.Show();
                this.Hide();
            }
        }

        private void tmrImage_Tick(object sender, EventArgs e)
        {
            imgClock++;
            pbPlayer.Image = images[imgClock % 10];
            if (imgClock % 10 == 0) { imgClock = 0; }
        }
    }
}