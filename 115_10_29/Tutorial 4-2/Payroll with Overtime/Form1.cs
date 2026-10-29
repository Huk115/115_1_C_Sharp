using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Payroll_with_Overtime
{
    /// <summary>
    /// 薪資計算表單，提供工作時數、每小時薪資與總薪資的操作功能。
    /// </summary>
    public partial class Form1 : Form
    {
        /// <summary>
        /// 建立薪資計算表單，並初始化表單上的所有元件。
        /// </summary>
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 按下「計算總薪資」按鈕時執行。
        /// </summary>
        /// <param name="sender">觸發事件的元件。</param>
        /// <param name="e">事件資料。</param>
            private void calculateButton_Click(object sender, EventArgs e)
        {
            const int BASE_HOURS = 40; // 基本工時
            const decimal OVERTIME_RATE = 1.5m; // 加班費率
            decimal hoursWorked; // 工作時數
            decimal hourlyPayRate; // 每小時薪資
            decimal grossPay; // 總薪資

            try
            {
                hoursWorked = decimal.Parse(hoursWorkedTextBox.Text);
                hourlyPayRate = decimal.Parse(hourlyPayRateTextBox.Text);
                // 取得工作時數與每小時薪資

                // 計算總薪資
                if (hoursWorked <= BASE_HOURS)
                {
                    grossPay = hoursWorked * hourlyPayRate;
                }
                else
                {
                    decimal overtimeHours = hoursWorked - BASE_HOURS;
                    grossPay = (BASE_HOURS * hourlyPayRate) + (overtimeHours * hourlyPayRate * OVERTIME_RATE);
                }

                grossPayLabel.Text = grossPay.ToString("C"); // 顯示總薪資，格式化為貨幣

            }
            catch (Exception ex)
            {
                MessageBox.Show("請輸入有效的數字。", "輸入錯誤");
            }
            // 此處加入工作時數與每小時薪資的計算邏輯。
        }

        /// <summary>
        /// 按下「清除」按鈕時，清除所有輸入內容與計算結果。
        /// </summary>
        /// <param name="sender">觸發事件的元件。</param>
        /// <param name="e">事件資料。</param>
        private void clearButton_Click(object sender, EventArgs e)
        {
            // 清除工作時數輸入欄位。
            hoursWorkedTextBox.Text = "";

            // 清除每小時薪資輸入欄位。
            hourlyPayRateTextBox.Text = "";

            // 清除總薪資顯示內容。
            grossPayLabel.Text = "";

            // 將游標重新放回工作時數輸入欄位。
            hoursWorkedTextBox.Focus();
        }

        /// <summary>
        /// 按下「離開」按鈕時關閉目前的表單。
        /// </summary>
        /// <param name="sender">觸發事件的元件。</param>
        /// <param name="e">事件資料。</param>
        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉目前的薪資計算表單。
            this.Close();
        }
    }
}
