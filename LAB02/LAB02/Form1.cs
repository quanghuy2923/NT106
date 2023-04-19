using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB02
{
    public partial class LAB02 : Form
    {
        public LAB02()
        {
            InitializeComponent();
        }

        private void btnBai1_Click(object sender, EventArgs e)
        {
            Bai1 bai1 = new Bai1();
            bai1.ShowDialog();
        }

        private void btnBai2_Click(object sender, EventArgs e)
        {
            Bai2 bai2 = new Bai2();
            bai2.ShowDialog();
        }

        private void btnBai3_Click(object sender, EventArgs e)
        {
           Bai3 bai3 = new Bai3();
            bai3.ShowDialog();
        }

        private void btnBai4_Click(object sender, EventArgs e)
        {
            Bai4 bai4 = new Bai4();
            bai4.ShowDialog();
        }
    }
}
