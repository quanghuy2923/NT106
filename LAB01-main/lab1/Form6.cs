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
    public partial class Bai5 : Form
    {
        public Bai5()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() == "") return;
            for (int i = 0; i < textBox1.Text.Length; i++)
            {
                if (!char.IsNumber(textBox1.Text[i]))
                {
                    MessageBox.Show("Please enter a valid number");
                    textBox1.Text = "";
                    return;
                }
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text.Trim() == "") return;
            for (int i = 0; i < textBox2.Text.Length; i++)
            {
                if (!char.IsNumber(textBox2.Text[i]))
                {
                    MessageBox.Show("Please enter a valid number");
                    textBox2.Text = "";
                    return;
                }
            }
        }
        public double GiaiThua(double n)
        {
            double gt=1;
            for(int i = 1; i <= n; i++)
            {
                gt = gt * i;
            }
        return gt;
        }
        public double SumLv(double n)
        {
            double sl = 0;
            for (int i=1; i <= n; i++)
            {
                sl = sl + i;
            }
            return sl;
        }
        private void cal_Click(object sender, EventArgs e)
        {
            double.TryParse(textBox1.Text, out double numA);
            double.TryParse(textBox2.Text, out double numB);
            double numAgt=GiaiThua((double)numA);
            double numBgt=GiaiThua(((double)numB));
            textBox3.Text= numAgt.ToString();
            textBox4.Text= numBgt.ToString();
            double S1 = SumLv(numA);
            double S2 = SumLv(numB);
            textBox5.Text="1+2+3+4+..+A= " +S1.ToString();
            textBox6.Text= "1+2+3+4+...+B= "+S2.ToString();
           
            double ans=0;
            for(int i = 1; i <= numB; i++)
            {
                ans += Math.Pow(numA, i);            
            }
            s.Text="A^1+A^2+A^3+A^4+...+A^B= "+ans.ToString();          
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
