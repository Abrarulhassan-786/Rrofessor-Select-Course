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
    public partial class AddCoursing : Form
    {
        public bool chek = false;
        public AddCoursing()
        {
            InitializeComponent();
        }

        private void AddCoursing_Load(object sender, EventArgs e)
        {

        }

        private void oopcb_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void btnsubmit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Course Has Been Added");
            professorcourseOption pro = new professorcourseOption();
            pro.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
