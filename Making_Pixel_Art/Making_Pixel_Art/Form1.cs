using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Making_Pixel_Art
{
    public partial class Form1 : Form
    {        
        private List<Button> colorButtons;
        private Button currentColorButton;
        private Color currentColor;

        public Form1()
        {
            InitializeComponent();

            this.colorButtons = GetAllButtons(this.gbxPalette);
        }

        private List<Button> GetAllButtons(Control control)     // 해당 group 내의 버튼들을 가져옴.
        {
            List<Button> buttons = new List<Button>();

            foreach (Control c in control.Controls)
            {
                if(c is Button && c.Text != "Edit")
                {
                    c.BackColor = Color.White;
                    buttons.Add((Button)c);
                }
            }

            return buttons;
        }

        private void btnColor01_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;

            if(clickedButton != null )
            {
                foreach(Button button in colorButtons)
                {
                    button.FlatStyle = FlatStyle.Standard;
                    button.FlatAppearance.BorderSize = 0;
                }

                clickedButton.FlatStyle = FlatStyle.Flat;
                clickedButton.FlatAppearance.BorderSize = 3;
            }

            currentColorButton = clickedButton;
            currentColor = clickedButton.BackColor;
            lblColorValue.Text = "현재 색상 : ( " + currentColor.R + " . " + currentColor.G + " . " + currentColor.B + " )";
        }

        private void btnColorEdit_Click(object sender, EventArgs e)
        {
            cld.Color = currentColorButton.BackColor;
            cld.ShowDialog();
            currentColorButton.BackColor = cld.Color;
            currentColor = currentColorButton.BackColor;
            lblColorValue.Text = "현재 색상 : ( " + currentColor.R + " . " + currentColor.G + " . " + currentColor.B + " )";
        }
    }
}
