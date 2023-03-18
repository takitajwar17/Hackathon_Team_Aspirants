using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hackathon1
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Email = textBox1.Text;
            string Password = textBox2.Text;

            foreach(User u in Utility.users)
            {
               if(u.email != Email || u.password != Password)
                {
                    MessageBox.Show("Wrong Email or Password");
                }
               else
                {
                   createcv c = new createcv();
                    c.Show();
                    this.Hide();
                }
            }
           
           

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Signup su = new Signup();
            su.Show();
            this.Hide();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
