using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Color_Theme
{
    public partial class Form1 : Form
    {

        const int Yellow = 1;
        const int Red = 2;
        const int White = 3;
        const int Normal = 4;

        private int colorChoice = Normal;
        public Form1()
        {
            InitializeComponent();
        }

        private void yellowRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            colorChoice = Yellow;
        }

        private void redRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            colorChoice = Red;
        }

        private void whiteRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            colorChoice = White;
        }

        private void normalRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            colorChoice = Normal;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (colorChoice)
            {
          case Yellow:
                    this.BackColor = Color.Yellow;
                    break;
                case Red:
                    this.BackColor = Color.Red;
                    break;
                case White:
                    this.BackColor = Color.White;
                    break;
                case Normal:
                    this.BackColor = SystemColors.Control;
                    break;
            }
        }
    }
}
