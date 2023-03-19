using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hackathon1
{
    public partial class MakeTemp : Form
    {
        public static string firstname = textBox1.Text;
        public static string surname = textBox2.Text;
        public static string city = textBox3.Text;
        public static string country = textBox4.Text;
        public static int postcode = Convert.ToInt32(textBox5.Text);
        public static double phone = Convert.ToInt32(textBox6.Text);
        public static string email = textBox7.Text;
        public static string school = textBox8.Text;
        public static string college = textBox10.Text;
        public static string uni = textBox12.Text;
        public static string exp = textBox14.Text;
        public static string skills = textBox18.Text;
        public MakeTemp()
        {
            InitializeComponent();
        }

        

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
              



            FinalCV f1 = new FinalCV();
            f1.Show();
            this.Hide();



        }
    }
}
