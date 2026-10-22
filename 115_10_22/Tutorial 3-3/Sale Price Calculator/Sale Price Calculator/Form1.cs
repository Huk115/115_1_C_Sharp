using System;
using System.Windows.Forms;

namespace Sale_Price_Calculator
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// 初始化表單元件。
        /// </summary>
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 計算按鈕事件：讀取輸入並計算售價。
        /// </summary>
        private void calculateButton_Click(object sender, EventArgs e)
        {
            decimal originalPrice;       // 原價
            decimal discountPercentage;  // 折扣百分比
            decimal salePrice;           // 售價

            originalPrice = decimal.Parse(
                originalPriceTextBox.Text); // 讀取原價

            discountPercentage = decimal.Parse(
                discountPercentageTextBox.Text); // 讀取折扣百分比

            salePrice = originalPrice *
                (1 - discountPercentage / 100.0m); // 計算售價

            salePriceLabel.Text = salePrice.ToString("C"); // 顯示售價
        }

        /// <summary>
        /// 離開按鈕事件：關閉目前視窗。
        /// </summary>
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void originalPriceTextBox_TextChanged(
            object sender, EventArgs e)
        {
        }

        private void salePriceLabel_Click(object sender, EventArgs e)
        {

        }

        private void outputDescriptionLabel_Click(object sender, EventArgs e)
        {

        }

        private void discPercentagePromptLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
