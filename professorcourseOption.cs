using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Assignment
{
    public partial class professorcourseOption : Form
    {
        public professorcourseOption()
        {
            InitializeComponent();
        }

        private void AddCourse_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Offering Added Successfully");
        }

        private void professorcourseOption_Load(object sender, EventArgs e)
        {

        }
    }
}
