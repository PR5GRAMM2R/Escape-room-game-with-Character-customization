using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EscapeGame
{
    public partial class Tic_Tac_Toe : Form
    {
        private bool isPlayerTurn = true;
        private int turnCount = 0;
        private int[] ticTac = new int[9];
        private Room3 room3; // 부모 Room2를 저장하는 변수

        public Tic_Tac_Toe(Room3 room)
        {
            InitializeComponent();
            room3 = room;
        }
        private void button_Click(object sender, EventArgs e)
        {
            if (isPlayerTurn)
            {
                Button button = (Button)sender;


                if (button.Tag == null)
                {
                    button.Tag = "X";
                    //button.Image = 



                    // heart

                    button.Image = Properties.Resources.x;
                    turnCount++;
                    isPlayerTurn = false;

                    if (CheckForWinner())
                    {
                        MessageBox.Show("Player Wins!", "Game Over");

                        room3.tictactoeGameWon();

                        this.Close();
                    }
                    else if (turnCount == 9)
                    {
                        MessageBox.Show("Draw!", "Game Over");
                        ResetGame();
                    }
                    else
                    {
                        ComputerMakeMove();
                    }
                }
            }
        }

        private void ComputerMakeMove()
        {
            Random rand = new Random();
            Button[] buttons = { button1, button2, button3, button4, button5, button6, button7, button8, button9 };

            Button move = buttons.Where(b => b.Tag == null).OrderBy(b => rand.Next()).FirstOrDefault();

            if (move != null)
            {
                move.Tag = "O";
                move.Image = Properties.Resources.o;
                turnCount++;
                isPlayerTurn = true;

                if (CheckForWinner())
                {
                    MessageBox.Show("Computer Wins!", "Game Over");
                    ResetGame();
                }
                else if (turnCount == 9)
                {
                    MessageBox.Show("Draw!", "Game Over");
                    ResetGame();
                }
            }
        }

        private bool CheckForWinner()
        {
            // Horizontal checks
            if ((button1.Tag == button2.Tag) && (button2.Tag == button3.Tag) && (button1.Tag != null))
                return true;
            if ((button4.Tag == button5.Tag) && (button5.Tag == button6.Tag) && (button4.Tag != null))
                return true;
            if ((button7.Tag == button8.Tag) && (button8.Tag == button9.Tag) && (button7.Tag != null))
                return true;

            // Vertical checks
            if ((button1.Tag == button4.Tag) && (button4.Tag == button7.Tag) && (button1.Tag != null))
                return true;
            if ((button2.Tag == button5.Tag) && (button5.Tag == button8.Tag) && (button2.Tag != null))
                return true;
            if ((button3.Tag == button6.Tag) && (button6.Tag == button9.Tag) && (button3.Tag != null))
                return true;

            // Diagonal checks
            if ((button1.Tag == button5.Tag) && (button5.Tag == button9.Tag) && (button1.Tag != null))
                return true;
            if ((button3.Tag == button5.Tag) && (button5.Tag == button7.Tag) && (button3.Tag != null))
                return true;

            return false;
        }

        private void ResetGame()
        {
            isPlayerTurn = true;
            turnCount = 0;

            foreach (Control c in Controls)
            {
                if (c is Button)
                {
                    ((Button)c).Image = null;
                    c.Tag = null;
                }
            }
        }
    }


}

