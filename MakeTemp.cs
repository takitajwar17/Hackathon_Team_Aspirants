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
       
        public MakeTemp()
        {
            InitializeComponent();
        }

        public static string firstname = "";
        public static string surname = "";
        public static string city ="";
        public static string country ="";
        public static string email = "";
        public static string school = "";
        public static string college = "";
        public static string uni ="";
        public static string exp ="";
        public static string skills = "";


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
            firstname = textBox1.Text;
            surname = textBox2.Text;
            city = textBox3.Text;
            country = textBox4.Text;
            email = textBox7.Text;
            school = textBox8.Text;
            college = textBox10.Text;
            uni = textBox12.Text;
            exp = textBox14.Text;
            skills = textBox18.Text;


            FinalCV f1 = new FinalCV();
            f1.Show();
            this.Hide();



        }
    }
}
