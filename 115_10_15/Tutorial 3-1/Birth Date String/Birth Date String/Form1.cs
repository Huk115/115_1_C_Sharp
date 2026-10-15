using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Birth_Date_String
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void showDateButton_Click(object sender, EventArgs e)
        {
            string dayOfWeek = dayOfWeekTextBox.Text;
            string month = monthTextBox.Text;
            string dayOfMonth = dayOfMonthTextBox.Text;
            string year = yearTextBox.Text;

            // Validate and format the date
            try
            {
                DateTime birthDate = new DateTime(
                    int.Parse(year),
                    DateTime.ParseExact(month, "MMMM", System.Globalization.CultureInfo.InvariantCulture).Month,
                    int.Parse(dayOfMonth));

                // Output the formatted date
                dateOutputLabel.Text = "您輸入的日期是: " + birthDate.ToString("yyyy年MM月dd日（dddd）");
            }
            catch (Exception ex)
            {
                MessageBox.Show("錯誤: " + ex.Message, "日期格式錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            dayOfWeekTextBox.Text = "";
           monthTextBox.Text = ""; 
            dayOfMonthTextBox.Text = "";
            yearTextBox.Text = "";

            dateOutputLabel.Text = "";
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dayOfMonthPromptLabel_Click(object sender, EventArgs e)
        {

        }

        private void dayOfWeekTextBox_TextChanged(object sender, EventArgs e)
        {
            string output;

            output = dayOfWeekTextBox.Text + " " + monthTextBox.Text + " " + dayOfMonthTextBox.Text + " " + yearTextBox.Text;   

            dateOutputLabel.Text = output;
        }
    }
}
