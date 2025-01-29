using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Skills_International_2._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string username = txt_username.Text;
            string password = txt_password.Text;

            if (username == "Admin" && password == "Skills@123")
            {
                MessageBox.Show("Login Successfull");
                Form2 reg = new Form2();
                this.Hide();
                reg.Show();
            }
            else
            {
                MessageBox.Show("Login Not Successfull");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txt_username.Clear();
            txt_password.Clear();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Are You Want to Exit", "Update", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
            Application.Exit();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
