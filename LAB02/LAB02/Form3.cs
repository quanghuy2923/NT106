using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LAB02
{
    public partial class Bai2 : Form
    {
        public Bai2()
        {
            InitializeComponent();
        }

        private void Bai2_Load(object sender, EventArgs e)
        {

        }
        private void btnRead_Click(object sender, EventArgs e)
        {

            txtWordscount.ReadOnly = true;
            txtUrl.ReadOnly = true;
            txtSize.ReadOnly = true;
            txtLinecount.ReadOnly = true;
            txtFilename.ReadOnly = true;
            txtCharactercount.ReadOnly = true;
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            FileStream fs = new FileStream(ofd.FileName, FileMode.OpenOrCreate);
            StreamReader sr = new StreamReader(fs);
            txtScreen.Text = sr.ReadToEnd();          
            txtLinecount.Text = txtScreen.Lines.Count().ToString();
            var textSplit = txtScreen.Text.Split(new char[] { ' ', '\r', '\n', ',', '.' }, StringSplitOptions.RemoveEmptyEntries);
            txtWordscount.Text=textSplit.Length.ToString();                     
            txtSize.Text = fs.Length.ToString() + " bytes";            
            txtFilename.Text = ofd.SafeFileName.ToString();
            txtUrl.Text = fs.Name.ToString();
            txtCharactercount.Text=txtScreen.Text.Length.ToString();
            fs.Close();
        }
    }
}
