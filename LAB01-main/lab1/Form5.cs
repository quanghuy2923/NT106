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
    public partial class Bai4 : Form
    {
        public Bai4()
        {
            InitializeComponent();
        }

        private void need_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double.TryParse(need.Text, out double monneed);
            double.TryParse(done.Text, out double mondone);
           
            if (Choose.Text == "EUR")
            {
                mondone = monneed * 28.132;
                quydoi.Text = "1 EUR = 28.132 k VND";
                quydoi.ReadOnly = true;
            }
            else if (Choose.Text == "GBP")
            {
                mondone = monneed * 31.538;
                quydoi.Text = "1 GBP = 31.538 k VND";
                quydoi.ReadOnly = true;
            }
            else if (Choose.Text == "SGD")
            {
                mondone = monneed * 17.286;
                quydoi.Text = "1 SGD = 17.286 k VND";
                quydoi.ReadOnly = true;
            }
            else if(Choose.Text =="JPY")
            {
                mondone = monneed * 214;
                quydoi.Text = "1 JPY = 214 k VND";
                quydoi.ReadOnly = true;
            }
            else
            {
                mondone = monneed * 22.772;
                quydoi.Text = "1 USD = 22.772 k VND";
                quydoi.ReadOnly = true;
            }
            done.Text=mondone.ToString()+" k";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Bai4_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
