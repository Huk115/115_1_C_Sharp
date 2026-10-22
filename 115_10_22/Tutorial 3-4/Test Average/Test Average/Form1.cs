using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_Average
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// 初始化表單與所有控制項。
        /// </summary>
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 按下「計算平均」按鈕時，計算三次測驗成績的平均值。
        /// </summary>
        /// <param name="sender">觸發事件的控制項。</param>
        /// <param name="e">事件資料。</param>
        private void calculateButton_Click(object sender, EventArgs e)
        {
            // 宣告三個測驗成績與平均值變數。
            double test1, test2, test3, average;

            try
            {
            // 從第一個測驗輸入欄位取得成績。
            test1 = double.Parse(test1TextBox.Text);

            // 從第二個測驗輸入欄位取得成績。
            test2 = double.Parse(test2TextBox.Text);

            // 從第三個測驗輸入欄位取得成績。
            test3 = double.Parse(test3TextBox.Text);

                average = (test1 + test2 + test3) / 3;

                averageLabel.Text = average.ToString("F1");
            }
            catch (FormatException)
            {
                // 如果輸入的不是有效的數字，顯示錯誤訊息並結束方法。
                MessageBox.Show("請輸入有效的數字。", "輸入錯誤");
                return;
            }

            // 計算三個測驗成績的平均值。
            average = (test1 + test2 + test3) / 3;

            // 將平均值顯示在結果標籤中，並格式化為小數點一位。
            averageLabel.Text = average.ToString("F1");
        }

        /// <summary>
        /// 按下「清除」按鈕時，清除所有輸入內容與計算結果。
        /// </summary>
        /// <param name="sender">觸發事件的控制項。</param>
        /// <param name="e">事件資料。</param>
        private void clearButton_Click(object sender, EventArgs e)
        {
            // 清除所有輸入欄位與平均值顯示。
            test1TextBox.Text = "";
            test2TextBox.Text = "";
            test3TextBox.Text = "";
            averageLabel.Text = "";
        }

        /// <summary>
        /// 按下「離開」按鈕時關閉表單。
        /// </summary>
        /// <param name="sender">觸發事件的控制項。</param>
        /// <param name="e">事件資料。</param>
        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉目前的表單。
            this.Close();
        }

        /// <summary>
        /// 第三次測驗輸入欄位內容變更時執行。
        /// </summary>
        /// <param name="sender">觸發事件的控制項。</param>
        /// <param name="e">事件資料。</param>
        private void test3TextBox_TextChanged(object sender, EventArgs e)
        {
            // 目前不需要在文字變更時執行其他處理。
        }

        /// <summary>
        /// 第一次測驗輸入欄位內容變更時執行。
        /// </summary>
        /// <param name="sender">觸發事件的控制項。</param>
        /// <param name="e">事件資料。</param>
        private void test1TextBox_TextChanged(object sender, EventArgs e)
        {
            // 目前不需要在文字變更時執行其他處理。
        }
    }
}
