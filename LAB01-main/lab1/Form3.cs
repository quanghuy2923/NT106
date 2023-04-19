using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab1
{
    public partial class Bai1 : Form
    {
        public Bai1()
        {
            InitializeComponent();
        }

        private void Bai1_Load(object sender, EventArgs e)
        {

        }

        private void num1_TextChanged(object sender, EventArgs e)
        {
            if (num1.Text.Trim() == "") return;
            for (int i = 0; i < num1.Text.Length; i++)
            {
                if (!char.IsNumber(num1.Text[i]))
                {
                    MessageBox.Show("Please enter a valid number");
                    num1.Text = "";
                    return;
                }
            }        
        }

        private void num2_TextChanged(object sender, EventArgs e)
        {
            if (num2.Text.Trim() == "") return;
            for (int i = 0; i < num2.Text.Length; i++)
            {
                if (!char.IsNumber(num2.Text[i]))
                {
                    MessageBox.Show("Please enter a valid number");
                    num2.Text = "";
                    return;
                }
            }
            double.TryParse(num1.Text, out double nb1);
            double.TryParse(num2.Text, out double nb2);
            double tong = nb1 + nb2;
            sum.Text = tong.ToString();
            sum.ReadOnly = true;
        }

        private void sum_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
