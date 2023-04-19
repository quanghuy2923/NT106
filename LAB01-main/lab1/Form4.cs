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
    public partial class Bai3 : Form
    {
        public Bai3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string tString = num.Text;
            int.TryParse(num.Text, out int nb);
            if (tString.Trim() == "") return;
            for (int i = 0; i < tString.Length; i++)
            {
                if (!char.IsNumber(tString[i]))
                {
                    MessageBox.Show("Please enter a valid number");
                    num.Text = "";
                    return;
                }
            }
            int.TryParse(num.Text, out int value);
            if (value == 0)
            {
                kq.Text = "không";
            }
            else if(value == 1)
            {
                kq.Text = "Một";
            }
            else if (value == 2)
            {
                kq.Text = "Hai";
            }
            else if (value == 3)
            {
                kq.Text = "Ba";
            }
            else if (value == 4)
            {
                kq.Text = "Bốn";
            }
            else if (value == 5)
            {
                kq.Text = "Năm";
            }
            else if (value == 6)
            {
                kq.Text = "Sáu";
            }
            else if (value == 7)
            {
                kq.Text = "Bảy";
            }
            else if (value == 8)
            {
                kq.Text = "Tám";
            }
            else { kq.Text = "chín"; }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            num.Text = "";
            kq.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Bai3_Load(object sender, EventArgs e)
        {

        }
    }
}
