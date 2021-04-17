using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class ManageLectures : Form
    {
        AddSubjects s1 = null;
        public ManageLectures()
        {
           // People = GetPeople();
            InitializeComponent();
        }

        public ManageLectures(AddSubjects s)
        {
            
            InitializeComponent();
        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           // var People = this.People;
           // dataGridView1.DataSource = People;
        }

        private void manageLocation_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void labelManage_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void buttonManageDelete_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void buttonManageUpdate_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Update Successfully!!!");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (s1 == null || s1.IsDisposed)
            {
                s1 = new AddSubjects();
            }
            s1.Show();
            this.Hide();
        }
    }
}
