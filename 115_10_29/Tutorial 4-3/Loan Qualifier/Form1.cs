using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loan_Qualifier
{
    /// <summary>
    /// 貸款資格審核表單。
    /// </summary>
    public partial class Form1 : Form
    {
        /// <summary>
        /// 建立貸款資格審核表單。
        /// </summary>
        public Form1()
        {
            // 初始化表單上的所有元件。
            InitializeComponent();
        }

        /// <summary>
        /// 按下「檢查資格」按鈕時執行貸款資格審核。
        /// </summary>
        /// <param name="sender">觸發事件的元件。</param>
        /// <param name="e">事件資料。</param>
        private void checkButton_Click(object sender, EventArgs e)
        {
            const decimal MIN_SALARY = 40000m; // 最低年薪要求
            const int MIN_YEARS = 2; // 最低工作年資要求

            decimal salary;
            int yearsOnJob;// 使用者輸入的工作年資
            // 此處撰寫貸款資格審核的相關程式。

            try
            {
                // 取得使用者輸入的年薪與工作年資。
                salary = decimal.Parse(salaryTextBox.Text);
                yearsOnJob = int.Parse(yearsTextBox.Text);
                // 判斷使用者是否符合貸款資格。
                if (salary >= MIN_SALARY)
                {
                    if (yearsOnJob >= MIN_YEARS)
                    {
                        decisionLabel.Text = "您符合貸款資格。";
                    }
                    else
                    {
                        decisionLabel.Text = "薪資符合但是年資不符合貸款資格";
                    }
                }
                else
                {
                    decisionLabel.Text = "薪資不符合貸款資格。";
                }
            }

            catch (Exception ex)
            {
                // 如果使用者輸入的資料格式不正確，顯示錯誤訊息。
                MessageBox.Show("請輸入有效的數字格式。", "輸入錯誤");
            }
        }

        /// <summary>
        /// 按下「清除」按鈕時清除輸入資料與審核結果。
        /// </summary>
        /// <param name="sender">觸發事件的元件。</param>
        /// <param name="e">事件資料。</param>
        private void clearButton_Click(object sender, EventArgs e)
        {
            // 清除年薪與工作年資輸入欄位。
            salaryTextBox.Text = "";
            yearsTextBox.Text = "";

            // 清除貸款資格審核結果。
            decisionLabel.Text = "";

            // 將輸入焦點移回年薪輸入欄位。
            salaryTextBox.Focus();
        }

        /// <summary>
        /// 按下「離開」按鈕時關閉表單。
        /// </summary>
        /// <param name="sender">觸發事件的元件。</param>
        /// <param name="e">事件資料。</param>
        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉目前的表單。
            this.Close();
        }
    }
}
