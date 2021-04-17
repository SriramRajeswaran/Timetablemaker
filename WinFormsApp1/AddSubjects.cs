using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class AddSubjects : Form
    {
        FormManage fm = null;
        public AddSubjects()
        {
            InitializeComponent();
        }

        public AddSubjects(FormManage f)
        {
            InitializeComponent();
            this.fm = f;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void FormStatic_Load(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void ViewSubbutton_Click(object sender, EventArgs e)
        {
            if (fm == null || fm.IsDisposed)
            {
                fm = new FormManage();
            }
            fm.Show();
            this.Hide();
        }

        private void SaveLecbutton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Success!!");
           // this.Hide();
        }
    }
}
