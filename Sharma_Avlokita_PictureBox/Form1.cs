using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sharma_Avlokita_PictureBox
{
    public partial class frmMainForm : Form
    {
        public frmMainForm()
        {
            InitializeComponent();
        }
        int width;
        int height;
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            picAutoSize.Width = picNormal.Width;
            picAutoSize.Height = picNormal.Height;
            Width= width; Height= height;

            if (dlgOpen.ShowDialog() == DialogResult.OK)
            {
                picNormal.Image = Image.FromFile(dlgOpen.FileName);
                picCenter.Image = Image.FromFile(dlgOpen.FileName);
                picAutoSize.Image = Image.FromFile(dlgOpen.FileName);
                picZoom.Image = Image.FromFile(dlgOpen.FileName);
                picStretch.Image = Image.FromFile(dlgOpen.FileName);
                txtSize.Text = picAutoSize.Width.ToString() + " x " + picAutoSize.Height.ToString();
                
            }
        }

        private void frmMainForm_Load(object sender, EventArgs e)
        {
            width = Width; height = Height; 
        }
    }
}
