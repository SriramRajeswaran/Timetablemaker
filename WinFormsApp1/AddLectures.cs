using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class AddLectures : Form
    {
        private AddLectures addLocation;
        public static string managelocation = "";
        ManageLectures m1 = null;
        public AddLectures()
        {
            InitializeComponent();
        }
        
        public static string[,] LocationDetails = new string[100, 8];
        private string FileName = "";
        int NoOfUsers = 0;
        
        public AddLectures(ManageLectures m)
        {
            InitializeComponent();
            this.m1 = m;
        }
        private void ResetControls()
        {/*
            this.textBoxBuilding.Text = "";
            this.textBoxRoom.Text = "";
            this.textBoxCapacity.Text = "";
            */
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AddLocations_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void labelRoom_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            

        }

        private void textBoxCapacity_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonView_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void sidePanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void buttonView_Click_1(object sender, EventArgs e)
        {
            if (m1 == null || m1.IsDisposed)
            {
                m1 = new ManageLectures();
            }
            m1.Show();
            this.Hide();
        }

        private void buttonAdd_Click_1(object sender, EventArgs e)
        {
            

            LocationDetails[NoOfUsers, 0] = textBoxName.Text;
            LocationDetails[NoOfUsers, 1] = textBoxID.Text.ToString();
            LocationDetails[NoOfUsers, 2] = comboBoxFaculty.Text;
            LocationDetails[NoOfUsers, 3] = comboBoxDepartment.SelectedItem.ToString();
            LocationDetails[NoOfUsers, 4] = comboBoxCenter.SelectedItem.ToString();
            LocationDetails[NoOfUsers, 5] = comboBoxBulding.SelectedItem.ToString();
            LocationDetails[NoOfUsers, 6] = comboBoxLevel.SelectedItem.ToString();
            LocationDetails[NoOfUsers, 7] = textBoxRank.Text.ToString();

            NoOfUsers++;
            
            MessageBox.Show("Successfully registered!!!");
            //this.Hide();
            
           
            
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
           // ResetControls();
        }
    }
}
