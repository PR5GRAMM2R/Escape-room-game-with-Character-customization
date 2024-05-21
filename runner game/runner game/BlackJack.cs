using System;
using System.Drawing;
using System.Windows.Forms;

namespace runner_game
{
    public partial class BlackJack : Form
    {
        GameManager gameManager;
        public BlackJack()
        {
            InitializeComponent();
        }
        private void Game_Paint(object sender, PaintEventArgs e)
        {
            string strScore;

            if (gameManager.showResult == false)
                strScore = string.Format("Dealer");
            else
                strScore = string.Format("Dealer, Score : {0}", gameManager.computer.CalcScore());
            e.Graphics.DrawString(strScore, Font, Brushes.Black, GBDealer.Left, GBDealer.Top);
            int OffsetX = 105;
            for (int i = 0; i < gameManager.computer.CardCount; i++)
            {
                if ((gameManager.user.IsStand == false) && (i == gameManager.computer.CardCount - 1))
                {
                    Bitmap bitmapComputer = Properties.Resources.cardback_red;
                    e.Graphics.DrawImage(bitmapComputer, (i * OffsetX) + GBDealer.Left + 5, GBDealer.Top + 15);
                }
                else
                {
                    Bitmap bitmapComputer = GetCardBitmap(gameManager.computer.GetCard(i).iShape, gameManager.computer.GetCard(i).iIndex);
                    e.Graphics.DrawImage(bitmapComputer, (i * OffsetX) + GBDealer.Left + 5, GBDealer.Top + 15);
                }

            }

            if (gameManager.showResult == false)
                strScore = string.Format("Player");
            else
                strScore = string.Format("Player, Score : {0}", gameManager.user.CalcScore());
            e.Graphics.DrawString(strScore, Font, Brushes.Black, GBPlayer.Left, GBPlayer.Top);
            for (int i = 0; i < gameManager.user.CardCount; i++)
            {
                Bitmap bitmapUser = GetCardBitmap(gameManager.user.GetCard(i).iShape, gameManager.user.GetCard(i).iIndex);
                e.Graphics.DrawImage(bitmapUser, (i * OffsetX) + GBPlayer.Left + 5, GBPlayer.Top + 15);
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            
        }


        private void btnhit_Click(object sender, EventArgs e)
        {
            gameManager.Hit();

            if (gameManager.user.CardCount >= 5)
                btnhit.Enabled = false;
            Invalidate();
        }

        private void btnStand_Click(object sender, EventArgs e)
        {
            btnhit.Enabled = false;
            btnStand.Enabled = false;
            Invalidate();

            gameManager.Stand();

            Invalidate();
        }

        private void Game_Load(object sender, EventArgs e)
        {
            gameManager = new GameManager();

            btnhit.Enabled = false;
            btnStand.Enabled = false;
        }

        private Bitmap GetCardBitmap(int iShape, int iIndex)
        {
            Bitmap retBitmap = null;

            // heart
            if (iShape == 0 && iIndex == 0) // heart a
                retBitmap = Properties.Resources.h1;
            else if (iShape == 0 && iIndex == 1)
                retBitmap = Properties.Resources.h2;
            else if (iShape == 0 && iIndex == 2)
                retBitmap = Properties.Resources.h3;
            else if (iShape == 0 && iIndex == 3)
                retBitmap = Properties.Resources.h4;
            else if (iShape == 0 && iIndex == 4)
                retBitmap = Properties.Resources.h5;
            else if (iShape == 0 && iIndex == 5)
                retBitmap = Properties.Resources.h6;
            else if (iShape == 0 && iIndex == 6)
                retBitmap = Properties.Resources.h7;
            else if (iShape == 0 && iIndex == 7)
                retBitmap = Properties.Resources.h8;
            else if (iShape == 0 && iIndex == 8)
                retBitmap = Properties.Resources.h9;
            else if (iShape == 0 && iIndex == 9)
                retBitmap = Properties.Resources.h10;
            else if (iShape == 0 && iIndex == 10)
                retBitmap = Properties.Resources.hj;
            else if (iShape == 0 && iIndex == 11)
                retBitmap = Properties.Resources.hq;
            else if (iShape == 0 && iIndex == 12)
                retBitmap = Properties.Resources.hk;
            // diamond
            else if (iShape == 1 && iIndex == 0) // diamond a
                retBitmap = Properties.Resources.d1;
            else if (iShape == 1 && iIndex == 1)
                retBitmap = Properties.Resources.d2;
            else if (iShape == 1 && iIndex == 2)
                retBitmap = Properties.Resources.d3;
            else if (iShape == 1 && iIndex == 3)
                retBitmap = Properties.Resources.d4;
            else if (iShape == 1 && iIndex == 4)
                retBitmap = Properties.Resources.d5;
            else if (iShape == 1 && iIndex == 5)
                retBitmap = Properties.Resources.d6;
            else if (iShape == 1 && iIndex == 6)
                retBitmap = Properties.Resources.d7;
            else if (iShape == 1 && iIndex == 7)
                retBitmap = Properties.Resources.d8;
            else if (iShape == 1 && iIndex == 8)
                retBitmap = Properties.Resources.d9;
            else if (iShape == 1 && iIndex == 9)
                retBitmap = Properties.Resources.d10;
            else if (iShape == 1 && iIndex == 10)
                retBitmap = Properties.Resources.dj;
            else if (iShape == 1 && iIndex == 11)
                retBitmap = Properties.Resources.dq;
            else if (iShape == 1 && iIndex == 12)
                retBitmap = Properties.Resources.dk;
            // clover
            else if (iShape == 2 && iIndex == 0) // clover a
                retBitmap = Properties.Resources.c1;
            else if (iShape == 2 && iIndex == 1)
                retBitmap = Properties.Resources.c2;
            else if (iShape == 2 && iIndex == 2)
                retBitmap = Properties.Resources.c3;
            else if (iShape == 2 && iIndex == 3)
                retBitmap = Properties.Resources.c4;
            else if (iShape == 2 && iIndex == 4)
                retBitmap = Properties.Resources.c5;
            else if (iShape == 2 && iIndex == 5)
                retBitmap = Properties.Resources.c6;
            else if (iShape == 2 && iIndex == 6)
                retBitmap = Properties.Resources.c7;
            else if (iShape == 2 && iIndex == 7)
                retBitmap = Properties.Resources.c8;
            else if (iShape == 2 && iIndex == 8)
                retBitmap = Properties.Resources.c9;
            else if (iShape == 2 && iIndex == 9)
                retBitmap = Properties.Resources.c10;
            else if (iShape == 2 && iIndex == 10)
                retBitmap = Properties.Resources.cj;
            else if (iShape == 2 && iIndex == 11)
                retBitmap = Properties.Resources.cq;
            else if (iShape == 2 && iIndex == 12)
                retBitmap = Properties.Resources.ck;
            // spade
            else if (iShape == 3 && iIndex == 0) // spade a
                retBitmap = Properties.Resources.s1;
            else if (iShape == 3 && iIndex == 1)
                retBitmap = Properties.Resources.s2;
            else if (iShape == 3 && iIndex == 2)
                retBitmap = Properties.Resources.s3;
            else if (iShape == 3 && iIndex == 3)
                retBitmap = Properties.Resources.s4;
            else if (iShape == 3 && iIndex == 4)
                retBitmap = Properties.Resources.s5;
            else if (iShape == 3 && iIndex == 5)
                retBitmap = Properties.Resources.s6;
            else if (iShape == 3 && iIndex == 6)
                retBitmap = Properties.Resources.s7;
            else if (iShape == 3 && iIndex == 7)
                retBitmap = Properties.Resources.s8;
            else if (iShape == 3 && iIndex == 8)
                retBitmap = Properties.Resources.s9;
            else if (iShape == 3 && iIndex == 9)
                retBitmap = Properties.Resources.s10;
            else if (iShape == 3 && iIndex == 10)
                retBitmap = Properties.Resources.sj;
            else if (iShape == 3 && iIndex == 11)
                retBitmap = Properties.Resources.sq;
            else if (iShape == 3 && iIndex == 12)
                retBitmap = Properties.Resources.sk;

            return retBitmap;
        }

        private void btnStart_Click_1(object sender, EventArgs e)
        {
            gameManager.Start();

            btnhit.Enabled = true;
            btnStand.Enabled = true;
            Invalidate();

        }
    }
}
