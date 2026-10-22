using System;
using System.Windows.Forms;

namespace Fuel_Economy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            double kilometers; // 儲存行駛公里數。
            double liters; // 儲存使用汽油公升數。
            double kilometersPerLiter; // 儲存每公升汽油行駛公里數。

            kilometers = double.Parse(milesTextBox.Text); // 取得使用者輸入的行駛公里數。
            liters = double.Parse(gallonsTextBox.Text); // 取得使用者輸入的使用汽油公升數。
            kilometersPerLiter = kilometers / liters; // 計算每公升汽油行駛公里數。

            mpgLabel.Text = kilometersPerLiter.ToString("F2") + " 公里/公升";
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉表單。
            this.Close();
        }
    }
}
