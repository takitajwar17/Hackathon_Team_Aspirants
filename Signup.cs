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
using System.Xml.Linq;

namespace hackathon1
{
    public partial class Signup : Form
    {
        public Signup()
        {
            InitializeComponent();
            Utility.load_users();
            
        }
        


       

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string email = textBox2.Text;
            string password = textBox3.Text;
            string ConfirmPass = textBox4.Text;
            int count = password.Length;

            if (Utility.users.Count > 0)
            {
                foreach (User u in Utility.users)
                {
                    if (u.username != username)
                    {

                        
                        
                            if (password == ConfirmPass)
                            {
                                string path = @"C:\Users\User\Downloads\hackathon\bin\Debug\form\TextFile1.txt";
                                StreamWriter sw = File.AppendText(path);
                                User uu = new User(username, email, password);
                                Utility.users.Add(uu);
                                string ss = $"{username},{email},{password}";
                                sw.WriteLine(ss);
                                sw.Close();

                                Login lf = new Login();
                                lf.Show();
                                this.Hide();

                            }
                            else
                            {
                                MessageBox.Show("Passwords do not match");
                            }

                        
                        
                    }
                    else
                    {
                        MessageBox.Show("Username exists. Try another");
                    }
                }

            }
            else
            {
                string path = "TextFile1.txt";
                StreamWriter sw = File.AppendText(path);
                User uu = new User(username, email, password);
                Utility.users.Add(uu);
                string ss = $"{username},{email},{password}";
                sw.WriteLine(ss);
                sw.Close();

                Login lf = new Login();
                lf.Show();
                this.Hide();
            }



        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
