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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Bai1_Click(object sender, EventArgs e)
        {
            Bai2 form2 = new Bai2();
            form2.ShowDialog();
        }

        private void Bai2_Click(object sender, EventArgs e)
        {
            Bai1 form3 = new Bai1();
            form3.ShowDialog();
        }

        private void Bai3_Click(object sender, EventArgs e)
        {
             Bai3 form4 = new Bai3();
            form4.ShowDialog();
        }

        private void Bai4_Click(object sender, EventArgs e)
        {
            Bai4 form5 = new Bai4();
               form5.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Bai5 form6 = new Bai5();
            form6.ShowDialog();
        }
    }
}
