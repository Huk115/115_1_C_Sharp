using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Birth_Date_String
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dayOfWeekTextBox = new System.Windows.Forms.TextBox();
            this.monthTextBox = new System.Windows.Forms.TextBox();
            this.dayOfMonthTextBox = new System.Windows.Forms.TextBox();
            this.yearTextBox = new System.Windows.Forms.TextBox();
            this.dayOfWeekPromptLabel = new System.Windows.Forms.Label();
            this.monthPromptLabel = new System.Windows.Forms.Label();
            this.dayOfMonthPromptLabel = new System.Windows.Forms.Label();
            this.yearPromptLabel = new System.Windows.Forms.Label();
            this.dateOutputLabel = new System.Windows.Forms.Label();
            this.showDateButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dayOfWeekTextBox
            // 
            this.dayOfWeekTextBox.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dayOfWeekTextBox.Location = new System.Drawing.Point(400, 34);
            this.dayOfWeekTextBox.Name = "dayOfWeekTextBox";
            this.dayOfWeekTextBox.Size = new System.Drawing.Size(220, 55);
            this.dayOfWeekTextBox.TabIndex = 0;
            this.dayOfWeekTextBox.TextChanged += new System.EventHandler(this.dayOfWeekTextBox_TextChanged);
            // 
            // monthTextBox
            // 
            this.monthTextBox.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.monthTextBox.Location = new System.Drawing.Point(400, 104);
            this.monthTextBox.Name = "monthTextBox";
            this.monthTextBox.Size = new System.Drawing.Size(220, 55);
            this.monthTextBox.TabIndex = 1;
            // 
            // dayOfMonthTextBox
            // 
            this.dayOfMonthTextBox.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dayOfMonthTextBox.Location = new System.Drawing.Point(400, 174);
            this.dayOfMonthTextBox.Name = "dayOfMonthTextBox";
            this.dayOfMonthTextBox.Size = new System.Drawing.Size(220, 55);
            this.dayOfMonthTextBox.TabIndex = 2;
            // 
            // yearTextBox
            // 
            this.yearTextBox.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.yearTextBox.Location = new System.Drawing.Point(400, 244);
            this.yearTextBox.Name = "yearTextBox";
            this.yearTextBox.Size = new System.Drawing.Size(220, 55);
            this.yearTextBox.TabIndex = 3;
            // 
            // dayOfWeekPromptLabel
            // 
            this.dayOfWeekPromptLabel.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dayOfWeekPromptLabel.Location = new System.Drawing.Point(40, 30);
            this.dayOfWeekPromptLabel.Name = "dayOfWeekPromptLabel";
            this.dayOfWeekPromptLabel.Size = new System.Drawing.Size(340, 44);
            this.dayOfWeekPromptLabel.TabIndex = 4;
            this.dayOfWeekPromptLabel.Text = "請輸入星期幾";
            this.dayOfWeekPromptLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // monthPromptLabel
            // 
            this.monthPromptLabel.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.monthPromptLabel.Location = new System.Drawing.Point(40, 100);
            this.monthPromptLabel.Name = "monthPromptLabel";
            this.monthPromptLabel.Size = new System.Drawing.Size(340, 44);
            this.monthPromptLabel.TabIndex = 5;
            this.monthPromptLabel.Text = "請輸入月份名稱";
            this.monthPromptLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dayOfMonthPromptLabel
            // 
            this.dayOfMonthPromptLabel.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dayOfMonthPromptLabel.Location = new System.Drawing.Point(40, 170);
            this.dayOfMonthPromptLabel.Name = "dayOfMonthPromptLabel";
            this.dayOfMonthPromptLabel.Size = new System.Drawing.Size(340, 44);
            this.dayOfMonthPromptLabel.TabIndex = 6;
            this.dayOfMonthPromptLabel.Text = "請輸入日期（數字）";
            this.dayOfMonthPromptLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.dayOfMonthPromptLabel.Click += new System.EventHandler(this.dayOfMonthPromptLabel_Click);
            // 
            // yearPromptLabel
            // 
            this.yearPromptLabel.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.yearPromptLabel.Location = new System.Drawing.Point(40, 240);
            this.yearPromptLabel.Name = "yearPromptLabel";
            this.yearPromptLabel.Size = new System.Drawing.Size(340, 44);
            this.yearPromptLabel.TabIndex = 7;
            this.yearPromptLabel.Text = "請輸入年份";
            this.yearPromptLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dateOutputLabel
            // 
            this.dateOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dateOutputLabel.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dateOutputLabel.Location = new System.Drawing.Point(40, 310);
            this.dateOutputLabel.Name = "dateOutputLabel";
            this.dateOutputLabel.Size = new System.Drawing.Size(580, 52);
            this.dateOutputLabel.TabIndex = 8;
            this.dateOutputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // showDateButton
            // 
            this.showDateButton.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.showDateButton.Location = new System.Drawing.Point(40, 380);
            this.showDateButton.Name = "showDateButton";
            this.showDateButton.Size = new System.Drawing.Size(160, 48);
            this.showDateButton.TabIndex = 9;
            this.showDateButton.Text = "顯示日期";
            this.showDateButton.UseVisualStyleBackColor = true;
            this.showDateButton.Click += new System.EventHandler(this.showDateButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.clearButton.Location = new System.Drawing.Point(240, 380);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(140, 48);
            this.clearButton.TabIndex = 10;
            this.clearButton.Text = "清除";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.exitButton.Location = new System.Drawing.Point(420, 380);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(140, 48);
            this.exitButton.TabIndex = 11;
            this.exitButton.Text = "離開";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(660, 460);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.showDateButton);
            this.Controls.Add(this.dateOutputLabel);
            this.Controls.Add(this.yearPromptLabel);
            this.Controls.Add(this.dayOfMonthPromptLabel);
            this.Controls.Add(this.monthPromptLabel);
            this.Controls.Add(this.dayOfWeekPromptLabel);
            this.Controls.Add(this.yearTextBox);
            this.Controls.Add(this.dayOfMonthTextBox);
            this.Controls.Add(this.monthTextBox);
            this.Controls.Add(this.dayOfWeekTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "生日日期字串";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox dayOfWeekTextBox;
        private System.Windows.Forms.TextBox monthTextBox;
        private System.Windows.Forms.TextBox dayOfMonthTextBox;
        private System.Windows.Forms.TextBox yearTextBox;
        private System.Windows.Forms.Label dayOfWeekPromptLabel;
        private System.Windows.Forms.Label monthPromptLabel;
        private System.Windows.Forms.Label dayOfMonthPromptLabel;
        private System.Windows.Forms.Label yearPromptLabel;
        private System.Windows.Forms.Label dateOutputLabel;
        private System.Windows.Forms.Button showDateButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
    }
}

