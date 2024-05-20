namespace move_game
{
    public partial class main : Form
    {
        int health = 100;
        int playerspeed = 5;

        bool goleft, goright;
        public main()
        {
            InitializeComponent();
        }

        //이동 방향을 정의 한 것 실제로 움직이게 해야함
        private void timer1_Tick(object sender, EventArgs e) //game main timer
        {
            if (goleft)
            {
                player.Left -= playerspeed;
            }
            if (goright)
            {
                player.Left += playerspeed;
            }
        }

        private void player_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {

        }

        //home에서 속성 처리
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Left)
            {
                goleft = true;
            }
            if(e.KeyCode == Keys.Right)
            {
                goright = true;
            }
            //장애물 만나면 동작
            foreach (Control control in this.Controls)
            {
                if (control is PictureBox)
                {
                    if ((string)control.Tag == "obstacle")
                    {   //player의 위치를 가져올 수 있다.
                        if (player.Bounds.IntersectsWith(control.Bounds))
                        {

                        }
                    }
                }
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goleft = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                goright = false;
            }

            
        }
    }
}
