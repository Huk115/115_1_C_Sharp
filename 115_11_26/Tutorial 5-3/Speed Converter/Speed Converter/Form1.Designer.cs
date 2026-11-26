namespace Speed_Converter
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
            this.outputListBox = new System.Windows.Forms.ListBox();
            this.displayButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // outputListBox
            // 
            this.outputListBox.Font = new System.Drawing.Font("Microsoft JhengHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.outputListBox.FormattingEnabled = true;
            this.outputListBox.ItemHeight = 30;
            this.outputListBox.Location = new System.Drawing.Point(30, 30);
            this.outputListBox.Name = "outputListBox";
            this.outputListBox.Size = new System.Drawing.Size(420, 214);
            this.outputListBox.TabIndex = 0;
            // 
            // displayButton
            // 
            this.displayButton.Font = new System.Drawing.Font("Microsoft JhengHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.displayButton.Location = new System.Drawing.Point(30, 270);
            this.displayButton.Name = "displayButton";
            this.displayButton.Size = new System.Drawing.Size(190, 65);
            this.displayButton.TabIndex = 1;
            this.displayButton.Text = "顯示速度";
            this.displayButton.UseVisualStyleBackColor = true;
            this.displayButton.Click += new System.EventHandler(this.displayButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Microsoft JhengHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.exitButton.Location = new System.Drawing.Point(260, 270);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(190, 65);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "離開";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 370);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.displayButton);
            this.Controls.Add(this.outputListBox);
            this.Font = new System.Drawing.Font("Microsoft JhengHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(7);
            this.Name = "Form1";
            this.Text = "速度轉換器";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox outputListBox;
        private System.Windows.Forms.Button displayButton;
        private System.Windows.Forms.Button exitButton;
    }
}

