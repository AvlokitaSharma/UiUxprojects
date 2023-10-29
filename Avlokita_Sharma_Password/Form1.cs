using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Avlokita_Sharma_Password
{
    public partial class Avlokita_Sharma_Password : Form
    {
        public Avlokita_Sharma_Password()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text == txtPassword.Tag.ToString())
            {
                MessageBox.Show("Password Correct");
            }

            else
            {
                MessageBox.Show("Password Incorrect");
            }
        }
    }
}
