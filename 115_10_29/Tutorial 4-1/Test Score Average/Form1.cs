using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_Score_Average
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// 建立表單並初始化所有視覺化元件。
        /// </summary>
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 按下「計算平均值」按鈕時執行。
        /// </summary>
        /// <param name="sender">觸發事件的物件。</param>
        /// <param name="e">事件資料。</param>
        private void calculateButton_Click(object sender, EventArgs e)
        {
            // 設定高分標準，供後續成績判斷使用。
            const double HIGH_SCORE = 95.0;

            const double PASSING_SCORE = 60.0;

            // 宣告三次測驗成績以及平均值變數。
            double test1, test2, test3, average;

            try
            {
                test1 = double.Parse(test1TextBox.Text);
                test2 = double.Parse(test2TextBox.Text);
                test3 = double.Parse(test3TextBox.Text);

                average = (test1 + test2 + test3) / 3.0;
                averageLabel.Text = average.ToString("F1");

                if (average >= HIGH_SCORE)
                {
                    MessageBox.Show("恭喜！平均分數達到高分標準！");
                }
                else if (average >= PASSING_SCORE)
                {
                    MessageBox.Show("平均分數及格。");
                }
                else
                {
                    MessageBox.Show("平均分數不及格。");
                }
            }
            catch (Exception ex)
            {
                // 顯示錯誤訊息。
                //MessageBox.Show(ex.Message, "輸入錯誤" , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// 按下「清除」按鈕時，清除所有輸入與計算結果。
        /// </summary>
        /// <param name="sender">觸發事件的物件。</param>
        /// <param name="e">事件資料。</param>
        private void clearButton_Click(object sender, EventArgs e)
        {
            // 清除三個成績輸入欄位。
            test1TextBox.Text = "";
            test2TextBox.Text = "";
            test3TextBox.Text = "";

            // 清除平均值顯示欄位。
            averageLabel.Text = "";

            // 將輸入焦點移回第一個成績輸入欄位。
            test1TextBox.Focus();
        }

        /// <summary>
        /// 按下「離開」按鈕時關閉目前表單。
        /// </summary>
        /// <param name="sender">觸發事件的物件。</param>
        /// <param name="e">事件資料。</param>
        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉目前的表單。
            this.Close();
        }

        /// <summary>
        /// 第一個測驗分數標籤被點選時執行。
        /// </summary>
        /// <param name="sender">觸發事件的物件。</param>
        /// <param name="e">事件資料。</param>
        private void test1promptLabel_Click(object sender, EventArgs e)
        {
            // 此事件目前不需要執行其他動作。
        }

        /// <summary>
        /// 測驗分數群組框取得焦點時執行。
        /// </summary>
        /// <param name="sender">觸發事件的物件。</param>
        /// <param name="e">事件資料。</param>
        private void testScoreGroupBox_Enter(object sender, EventArgs e)
        {
            // 此事件目前不需要執行其他動作。
        }
    }
}
