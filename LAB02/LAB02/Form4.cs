using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB02
{
    public partial class Bai3 : Form
    {
        public Bai3()
        {
            InitializeComponent();
        }
        private string _path;

        private void Bai3_Load(object sender, EventArgs e)
        {

        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            try
            {
                var openFileDialog = new OpenFileDialog
                {
                    Filter = "Txt Files| *.txt"
                };
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    _path = Path.GetDirectoryName(openFileDialog.FileName);
                    var streamReader = new StreamReader(openFileDialog.FileName);
                    txtScreen.Text = streamReader.ReadToEnd();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCal_Click_1(object sender, EventArgs e)
        {
            try
            {
                txtScreen.Text = "";
                foreach (var expression in txtCalScreen.Lines)
                {
                    var result = new DataTable().Compute(expression, null);
                    txtScreen.Text += $"{expression} = {result:0.##}{Environment.NewLine}";
                }
                var outputPath = $"{_path}/output3.txt";
                File.WriteAllText(outputPath, txtScreen.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

