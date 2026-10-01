namespace Tutorial2_3
{
    partial class translateLabel
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.translateLabel2 = new System.Windows.Forms.Label();
            this.germanButton_Click = new System.Windows.Forms.Label();
            this.spanishButton_Click = new System.Windows.Forms.Label();
            this.italiButton_Click = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("新細明體", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(69, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(870, 94);
            this.label1.TabIndex = 0;
            this.label1.Text = "選擇一個語言，我告訴你怎麼說\'\'早安\'\'";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // translateLabel2
            // 
            this.translateLabel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.translateLabel2.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.translateLabel2.Location = new System.Drawing.Point(351, 211);
            this.translateLabel2.Name = "translateLabel2";
            this.translateLabel2.Size = new System.Drawing.Size(282, 68);
            this.translateLabel2.TabIndex = 1;
            this.translateLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.translateLabel2.Click += new System.EventHandler(this.label2_Click);
            // 
            // germanButton_Click
            // 
            this.germanButton_Click.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.germanButton_Click.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.germanButton_Click.Location = new System.Drawing.Point(709, 431);
            this.germanButton_Click.Name = "germanButton_Click";
            this.germanButton_Click.Size = new System.Drawing.Size(204, 66);
            this.germanButton_Click.TabIndex = 2;
            this.germanButton_Click.Text = "德國";
            this.germanButton_Click.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.germanButton_Click.Click += new System.EventHandler(this.label3_Click);
            // 
            // spanishButton_Click
            // 
            this.spanishButton_Click.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.spanishButton_Click.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.spanishButton_Click.Location = new System.Drawing.Point(389, 431);
            this.spanishButton_Click.Name = "spanishButton_Click";
            this.spanishButton_Click.Size = new System.Drawing.Size(204, 66);
            this.spanishButton_Click.TabIndex = 3;
            this.spanishButton_Click.Text = "西班牙";
            this.spanishButton_Click.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.spanishButton_Click.Click += new System.EventHandler(this.label4_Click);
            // 
            // italiButton_Click
            // 
            this.italiButton_Click.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.italiButton_Click.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.italiButton_Click.Location = new System.Drawing.Point(78, 431);
            this.italiButton_Click.Name = "italiButton_Click";
            this.italiButton_Click.Size = new System.Drawing.Size(204, 66);
            this.italiButton_Click.TabIndex = 4;
            this.italiButton_Click.Text = "義大利";
            this.italiButton_Click.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.italiButton_Click.Click += new System.EventHandler(this.label5_Click);
            // 
            // translateLabel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 612);
            this.Controls.Add(this.italiButton_Click);
            this.Controls.Add(this.spanishButton_Click);
            this.Controls.Add(this.germanButton_Click);
            this.Controls.Add(this.translateLabel2);
            this.Controls.Add(this.label1);
            this.Name = "translateLabel";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label translateLabel2;
        private System.Windows.Forms.Label germanButton_Click;
        private System.Windows.Forms.Label spanishButton_Click;
        private System.Windows.Forms.Label italiButton_Click;
    }
}

