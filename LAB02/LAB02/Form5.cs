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
    public partial class Bai4 : Form
    {

        [Serializable]
        internal class Student
        {
            public string Name { get; set; }
            public int ID { get; set; }
            public string Phone { get; set; }
            public double Score1 { get; set; }
            public double Score2 { get; set; }
            public double Score3 { get; set; }
            public double AverageScore { get; set; }
            public Student() { }

        }
        private List<Student> _students;

        private int _index = 0;
        public Bai4()
        {
            InitializeComponent();
            _students = new List<Student>();
        }

    }
}
