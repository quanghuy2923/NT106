using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data.SqlClient;

namespace lab1
{
    public partial class Bai2 : Form
    {
        public Bai2()
        {
            InitializeComponent();
        }

        private void num1_TextChanged(object sender, EventArgs e)
        {
            string tString = num1.Text;
            if (tString.Trim() == "") return;
            for (int i = 0; i < tString.Length; i++)
            {
                if (!char.IsNumber(tString[i]))
                {
                    MessageBox.Show("Please enter a valid number");
                    num1.Text = "";
                    return;
                }
            }
            string tString2 = num2.Text;
            if (tString.Trim() == "") return;
            for (int i = 0; i < tString.Length; i++)
            {
                if (!char.IsNumber(tString[i]))
                {
                    MessageBox.Show("Please enter a valid number");
                    num2.Text = "";
                    return;
                }
            }
            string tString3 = num3.Text;
            if (tString.Trim() == "") return;
            for (int i = 0; i < tString.Length; i++)
            {
                if (!char.IsNumber(tString[i]))
                {
                    MessageBox.Show("Please enter a valid number");
                    num3.Text = "";
                    return;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double.TryParse(num1.Text, out double nb1);
            double.TryParse(num2.Text, out double nb2);
            double.TryParse(num3.Text, out double nb3);
            double max = nb1;
            if (max < nb2)
            {
                max = nb2;
            }

            if (max < nb3)
            {
                max = nb3;
            }
            double min = nb1;
            switch (min < nb2)
            {
                case true:
                    switch (min < nb3)
                    {
                        case false:
                            min = nb3;
                            break;
                    }
                    break;
                case false:
                    min = nb2;
                    break;
            }
            Min.Text=min.ToString();
            Max.Text=max.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            num1.Text = "";
            num2.Text = "";
            num3.Text = "";
            Min.Text = "";
            Max.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.ExitThread();
        }
    }
}
