using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EscapeGame
{
    public partial class Form1 : Form
    {
        int numCells = 32;
        int frameNum = 0;

        private SoundPlayer backgroundMusicPlayer;
        private HashSet<Keys> pressedKeys = new HashSet<Keys>();
        private Timer movementTimer;
        private const int step = 10; // 캐릭터 이동 거리
        private bool hasReachedTarget = false; // 목표 위치 도달 여부를 추적
        public bool hasKeyToRoom2 = false;
        public bool hasKeyToRoom3 = false;
        public bool hasKeyToRoom4 = false;
        public bool hasKeyToEscape = false;

        public List<Image> images = new List<Image>();     //// gif처럼 나타낼 이미지를 저장하는 List
        private int imgClock = 0;                           //// 

        public Form1()
        {
            InitializeComponent();
            
            this.KeyDown += new KeyEventHandler(Form1_KeyDown);
            this.KeyUp += new KeyEventHandler(Form1_KeyUp);
            this.KeyPreview = true;

            // 방향키 두 개를 동시에 눌렀을 때 대각선으로 이동시키기 위함
            movementTimer = new Timer();
            movementTimer.Interval = 20; // 20ms 간격으로 움직임을 업데이트
            movementTimer.Tick += MovementTimer_Tick;
            movementTimer.Start();

            //LoadImages();   //// 이미지 불러오기
            //pbPlayer.Image = images[0];     //// 초기 이미지 설정

            pbPlayer.BackColor = Color.FromArgb(0, 255, 255, 255);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            var musicStream = Properties.Resources.sample;
            backgroundMusicPlayer = new SoundPlayer(musicStream);
            // 폼이 로드될 때 음악 재생
            backgroundMusicPlayer.PlayLooping();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            pressedKeys.Add(e.KeyCode);
            tmrImage.Start();      //// 이미지 변환 시작
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            pressedKeys.Remove(e.KeyCode);
            tmrImage.Stop();       //// 이미지 변환을 멈춤
        }

        private void MovementTimer_Tick(object sender, EventArgs e)
        {
            MovePlayer();
            MoveRoom1();
            MoveRoom2();
            MoveRoom3();
            MoveRoom4();
            MoveEscape();
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

        private void MoveRoom1()
        {
            if (hasReachedTarget == false && hasKeyToRoom2 == false && pbPlayer.Bounds.IntersectsWith(pbRoom1p.Bounds)) // 1번방
            {
                hasReachedTarget = true; // 플래그를 설정하여 이벤트가 한 번만 발생하도록 함
                Room1 room1 = new Room1(this);
                room1.Show();
                this.Hide();
            }
            else if (hasKeyToRoom2 == true && pbPlayer.Bounds.IntersectsWith(pbRoom1p.Bounds))
            {
                movementTimer.Stop(); // 타이머 멈춤으로써 플레이어 이동 멈춤
                MessageBox.Show("여긴 더 볼 필요 없을 거 같아.");
                pbPlayer.Left -= 20;
                movementTimer.Start(); // 타이머 시작
                pressedKeys.Clear(); // 입력된 키 초기화
            }
        }
        private void MoveRoom2()
        {
            pictures();
            if (hasReachedTarget == false && pbPlayer.Bounds.IntersectsWith(pbRoom2p.Bounds)) // 2번방
            {
                if (hasKeyToRoom2 == true && hasKeyToRoom3 == false)
                {
                    hasReachedTarget = true;
                    Room2 room2 = new Room2(this);
                    room2.Show();
                    this.Hide();
                }
                else if (hasKeyToRoom3 == true)
                {
                    movementTimer.Stop();
                    MessageBox.Show("여긴 더 볼 필요 없을 거 같아.");
                    pbPlayer.Left += 20;
                    movementTimer.Start();
                    pressedKeys.Clear();
                }
                else
                {
                    movementTimer.Stop();
                    MessageBox.Show("잠겨있다.");
                    pbPlayer.Left += 20;
                    movementTimer.Start();
                    pressedKeys.Clear();
                }
            }
        }
        private void MoveRoom3()
        {
            pictures();
            if (hasReachedTarget == false && pbPlayer.Bounds.IntersectsWith(pbRoom3p.Bounds)) // 3번방
            {
                if (hasKeyToRoom3 == true && hasKeyToRoom4 == false)
                {
                    hasReachedTarget = true;
                    Room3 room3 = new Room3(this);
                    room3.Show();
                    this.Hide();
                }
                else if (hasKeyToRoom4 == true)
                {
                    movementTimer.Stop();
                    MessageBox.Show("여긴 더 볼 필요 없을 거 같아.");
                    pbPlayer.Top += 20;
                    movementTimer.Start();
                    pressedKeys.Clear();
                }
                else
                {
                    movementTimer.Stop();
                    MessageBox.Show("잠겨있다.");
                    pbPlayer.Top += 20;
                    movementTimer.Start();
                    pressedKeys.Clear();
                }
            }
        }
        private void MoveRoom4()
        {
            pictures();
            if (hasReachedTarget == false && pbPlayer.Bounds.IntersectsWith(pbRoom4p.Bounds)) // 4번방
            {
                if (hasKeyToRoom4 == true && hasKeyToEscape == false)
                {
                    hasReachedTarget = true;
                    Room4 room4 = new Room4(this);
                    room4.Show();
                    this.Hide();
                }
                else if (hasKeyToEscape == true)
                {
                    movementTimer.Stop();
                    MessageBox.Show("여긴 더 볼 필요 없을 거 같아.");
                    pbPlayer.Top += 20;
                    movementTimer.Start();
                    pressedKeys.Clear();
                }
                else
                {
                    movementTimer.Stop();
                    MessageBox.Show("잠겨있다.");
                    pbPlayer.Top += 20;
                    movementTimer.Start();
                    pressedKeys.Clear();
                }
            }
        }
        private void rest()
        {
            hasReachedTarget = false; // 목표 위치 도달 여부를 추적
            hasKeyToRoom2 = false;
            hasKeyToRoom3 = false;
            hasKeyToRoom4 = false;
            hasKeyToEscape = false;
        }
        private void MoveEscape()
        {
            pictures();
            if (hasReachedTarget == false && pbPlayer.Bounds.IntersectsWith(pbEscape.Bounds)) // 현관문
            {
                if (hasKeyToEscape == true)
                {
                    hasReachedTarget = true;
                    movementTimer.Stop();
                    MessageBox.Show("문이 열렸다. 어서 나가자.");
                    MainGameMenu main = new MainGameMenu();
                    rest();
                    main.Show();
                    this.Close();
                }
                else
                {
                    movementTimer.Stop();
                    MessageBox.Show("문이 잠겨있다. 열쇠가 필요해보인다.");
                    pbPlayer.Top -= 20;
                    movementTimer.Start();
                    pressedKeys.Clear();
                }
            }
        }
        public void SetPlayerPosition(int x, int y)
        {
            pbPlayer.Location = new Point(x, y);
            pressedKeys.Clear();
            hasReachedTarget = false;
        }
        public void pictures()
        {
            if (hasKeyToRoom2 == true)
            {
                pbRoom2p.Image = Properties.Resources.열린_문;
            }
            if (hasKeyToRoom3 == true)
            {
                pbRoom3p.Image = Properties.Resources.열린_문;
            }
            if (hasKeyToRoom4 == true)
            {
                pbRoom4p.Image = Properties.Resources.열린_문;
            }
            if (hasKeyToEscape == true)
            {
                pbEscape.Image = Properties.Resources.열린_문;
            }

        }

        // images List에 이미지를 저장
        private void LoadImages()
        {
            images.Add(Image.FromFile("..\\..\\Resources\\c1.png"));
            images.Add(Image.FromFile("..\\..\\Resources\\c2.png"));
            images.Add(Image.FromFile("..\\..\\Resources\\c3.png"));
            images.Add(Image.FromFile("..\\..\\Resources\\c4.png"));
            images.Add(Image.FromFile("..\\..\\Resources\\c5.png"));
            images.Add(Image.FromFile("..\\..\\Resources\\c6.png"));
            images.Add(Image.FromFile("..\\..\\Resources\\c7.png"));
            images.Add(Image.FromFile("..\\..\\Resources\\c8.png"));
            images.Add(Image.FromFile("..\\..\\Resources\\c9.png"));
            images.Add(Image.FromFile("..\\..\\Resources\\c10.png"));
        }

        // gif 움직일 때 사용할 타이머
        private void tmrImage_Tick(object sender, EventArgs e)
        {
            pbPlayer.Invalidate();
            frameNum = (frameNum + 1) % GlobalSettings.Instance.frameCount;
        }

        private void pbPlayer_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            int cellSizeX = pbPlayer.Width / numCells;
            int cellSizeY = pbPlayer.Height / numCells;

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
