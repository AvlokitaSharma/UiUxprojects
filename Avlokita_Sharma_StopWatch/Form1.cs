using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Avlokita_Sharma_StopWatch
{
    public partial class frmMainForm : Form
    {
        public frmMainForm()
        {
            InitializeComponent();
        }

        DateTime start;
        DateTime stop;
        TimeSpan elapsedTime;
        private void btnStart_Click(object sender, EventArgs e)
        {
            start = DateTime.Now;
            txtStart.Text = start.ToLongTimeString();
            txtStop.Text = "";
            txtElapsedTime.Text = ""; 

        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            stop = DateTime.Now;
            txtStop.Text = stop.ToLongTimeString();
            elapsedTime= stop - start;
            txtElapsedTime.Text = elapsedTime.Seconds.ToString();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
