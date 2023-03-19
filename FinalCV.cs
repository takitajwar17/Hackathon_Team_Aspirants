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
    public partial class FinalCV : Form
    {
        public FinalCV()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void FinalCV_Load(object sender, EventArgs e)
        {
            label13.Text = MakeTemp.firstname;
            label14.Text = MakeTemp.surname;
            label15.Text = MakeTemp.city;
            label16.Text = MakeTemp.country;
            label19.Text = MakeTemp.email;
            label20.Text = MakeTemp.school;
            label21.Text = MakeTemp.college;
            label22.Text = MakeTemp.uni;
            label23.Text = MakeTemp.exp;
            label24.Text = MakeTemp.skills;

        }
    }
  
}
