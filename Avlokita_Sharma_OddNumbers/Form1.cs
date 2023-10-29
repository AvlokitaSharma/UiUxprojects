using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Avlokita_Sharma_OddNumbers
{
    public partial class frmMainForm : Form
    {
        public frmMainForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void frmMainForm_Load(object sender, EventArgs e)
        {

        }

        private void txtTargetSum_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNumberOfintegers_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSum_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSumIntegers_Click(object sender, EventArgs e)
        {
            int targetSum;
            int numberIntegers = 1;
            int sum = 1;
            int currentInteger = 1;

            targetSum = Convert.ToInt32(txtTargetSum.Text);

            while(sum < targetSum)
            {
                numberIntegers++;
                currentInteger += 2;
                sum += currentInteger;
            }

            txtNumberOfintegers.Text = numberIntegers.ToString();
            txtSum.Text = sum.ToString();
        }
    }
}
