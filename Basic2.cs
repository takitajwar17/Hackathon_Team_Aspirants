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
    public partial class Basic2 : Form
    {
        public Basic2()
        {
            InitializeComponent();
        }

        private void Basic2_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Basic b1 = new Basic();
            b1.Show();
            this.Hide();
        }
    }
}
