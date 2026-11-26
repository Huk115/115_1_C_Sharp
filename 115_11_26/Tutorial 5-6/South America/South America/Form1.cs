using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace South_America
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void getCountriesButton_Click(object sender, EventArgs e)
        {
            try
            { StreamReader inputFile;
            
            inputFile = File.OpenText("C:\\Users\\m303\\Desktop\\Countries.txt");

                while (!inputFile.EndOfStream)
            {
                    string country = inputFile.ReadLine();
                    countriesListBox.Items.Add(country);
                }
            inputFile.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

            countriesListBox.Items.AddRange(new object[]
            {
                "阿根廷",
                "玻利維亞",
                "巴西",
                "智利",
                "哥倫比亞",
                "厄瓜多",
                "福克蘭群島",
                "法屬圭亞那",
                "蓋亞那",
                "巴拉圭",
                "秘魯",
                "蘇利南",
                "烏拉圭",
                "委內瑞拉"
            });
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉表單。
            this.Close();
        }
    }
}
