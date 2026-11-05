namespace Test_Score_Average
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
            this.testScoreGroupBox = new System.Windows.Forms.GroupBox();
            this.outputDescriptionLabel = new System.Windows.Forms.Label();
            this.averageLabel = new System.Windows.Forms.Label();
            this.test3promptLabel = new System.Windows.Forms.Label();
            this.test2promptLabel = new System.Windows.Forms.Label();
            this.test1promptLabel = new System.Windows.Forms.Label();
            this.test3TextBox = new System.Windows.Forms.TextBox();
            this.test2TextBox = new System.Windows.Forms.TextBox();
            this.test1TextBox = new System.Windows.Forms.TextBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.testScoreGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // testScoreGroupBox
            // 
            this.testScoreGroupBox.Controls.Add(this.outputDescriptionLabel);
            this.testScoreGroupBox.Controls.Add(this.averageLabel);
            this.testScoreGroupBox.Controls.Add(this.test3promptLabel);
            this.testScoreGroupBox.Controls.Add(this.test2promptLabel);
            this.testScoreGroupBox.Controls.Add(this.test1promptLabel);
            this.testScoreGroupBox.Controls.Add(this.test3TextBox);
            this.testScoreGroupBox.Controls.Add(this.test2TextBox);
            this.testScoreGroupBox.Controls.Add(this.test1TextBox);
            this.testScoreGroupBox.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F);
            this.testScoreGroupBox.Location = new System.Drawing.Point(20, 20);
            this.testScoreGroupBox.Name = "testScoreGroupBox";
            this.testScoreGroupBox.Size = new System.Drawing.Size(560, 320);
            this.testScoreGroupBox.TabIndex = 0;
            this.testScoreGroupBox.TabStop = false;
            this.testScoreGroupBox.Text = "輸入三個測驗分數";
            this.testScoreGroupBox.Enter += new System.EventHandler(this.testScoreGroupBox_Enter);
            // 
            // outputDescriptionLabel
            // 
            this.outputDescriptionLabel.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F);
            this.outputDescriptionLabel.Location = new System.Drawing.Point(40, 250);
            this.outputDescriptionLabel.Name = "outputDescriptionLabel";
            this.outputDescriptionLabel.Size = new System.Drawing.Size(160, 40);
            this.outputDescriptionLabel.TabIndex = 7;
            this.outputDescriptionLabel.Text = "平均值";
            this.outputDescriptionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // averageLabel
            // 
            this.averageLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.averageLabel.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F);
            this.averageLabel.Location = new System.Drawing.Point(274, 250);
            this.averageLabel.Name = "averageLabel";
            this.averageLabel.Size = new System.Drawing.Size(280, 40);
            this.averageLabel.TabIndex = 6;
            this.averageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // test3promptLabel
            // 
            this.test3promptLabel.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F);
            this.test3promptLabel.Location = new System.Drawing.Point(-4, 185);
            this.test3promptLabel.Name = "test3promptLabel";
            this.test3promptLabel.Size = new System.Drawing.Size(276, 40);
            this.test3promptLabel.TabIndex = 5;
            this.test3promptLabel.Text = "第三次測驗分數";
            this.test3promptLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // test2promptLabel
            // 
            this.test2promptLabel.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F);
            this.test2promptLabel.Location = new System.Drawing.Point(-4, 120);
            this.test2promptLabel.Name = "test2promptLabel";
            this.test2promptLabel.Size = new System.Drawing.Size(276, 40);
            this.test2promptLabel.TabIndex = 4;
            this.test2promptLabel.Text = "第二次測驗分數";
            this.test2promptLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // test1promptLabel
            // 
            this.test1promptLabel.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F);
            this.test1promptLabel.Location = new System.Drawing.Point(-4, 61);
            this.test1promptLabel.Name = "test1promptLabel";
            this.test1promptLabel.Size = new System.Drawing.Size(280, 40);
            this.test1promptLabel.TabIndex = 3;
            this.test1promptLabel.Text = "第一次測驗分數";
            this.test1promptLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.test1promptLabel.Click += new System.EventHandler(this.test1promptLabel_Click);
            // 
            // test3TextBox
            // 
            this.test3TextBox.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F);
            this.test3TextBox.Location = new System.Drawing.Point(274, 185);
            this.test3TextBox.Name = "test3TextBox";
            this.test3TextBox.Size = new System.Drawing.Size(280, 53);
            this.test3TextBox.TabIndex = 2;
            // 
            // test2TextBox
            // 
            this.test2TextBox.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F);
            this.test2TextBox.Location = new System.Drawing.Point(274, 120);
            this.test2TextBox.Name = "test2TextBox";
            this.test2TextBox.Size = new System.Drawing.Size(280, 53);
            this.test2TextBox.TabIndex = 1;
            // 
            // test1TextBox
            // 
            this.test1TextBox.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F);
            this.test1TextBox.Location = new System.Drawing.Point(274, 55);
            this.test1TextBox.Name = "test1TextBox";
            this.test1TextBox.Size = new System.Drawing.Size(280, 53);
            this.test1TextBox.TabIndex = 0;
            // 
            // calculateButton
            // 
            this.calculateButton.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F);
            this.calculateButton.Location = new System.Drawing.Point(20, 365);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(180, 55);
            this.calculateButton.TabIndex = 1;
            this.calculateButton.Text = "計算平均值";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F);
            this.clearButton.Location = new System.Drawing.Point(220, 365);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(160, 55);
            this.clearButton.TabIndex = 2;
            this.clearButton.Text = "清除";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F);
            this.exitButton.Location = new System.Drawing.Point(400, 365);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(180, 55);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "離開";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(21F, 46F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 450);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.testScoreGroupBox);
            this.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "測驗分數平均值";
            this.testScoreGroupBox.ResumeLayout(false);
            this.testScoreGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox testScoreGroupBox;
        private System.Windows.Forms.Label outputDescriptionLabel;
        private System.Windows.Forms.Label averageLabel;
        private System.Windows.Forms.Label test3promptLabel;
        private System.Windows.Forms.Label test2promptLabel;
        private System.Windows.Forms.Label test1promptLabel;
        private System.Windows.Forms.TextBox test3TextBox;
        private System.Windows.Forms.TextBox test2TextBox;
        private System.Windows.Forms.TextBox test1TextBox;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
    }
}

