using kursee;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kursova
{
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Showbtn_Click(object sender, EventArgs e)
        {
            fMain fmain = new fMain();
            fmain.Show();
            this.Hide();
        }
    }
}
