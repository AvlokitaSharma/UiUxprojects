using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Avlokita_Sharma_PictureBox
{
    public partial class frmMainForm : Form
    {
        public frmMainForm()
        {
            InitializeComponent();
        }

    

        int width;
        int height;
        private void btnSelect_Click(object sender, EventArgs e)
        {
            picAutoSize.Width = picNormal.Width;
            picAutoSize.Height = picNormal.Height;
            Width = width; 
            Height = height;

            if (dIgOpen.ShowDialog() == DialogResult.OK)
            {
                picNormal.Image=Image.FromFile(dIgOpen.FileName);
                picCenter.Image = Image.FromFile(dIgOpen.FileName);
                picAutoSize.Image = Image.FromFile(dIgOpen.FileName);
                picStretch.Image = Image.FromFile(dIgOpen.FileName);
                picZoom.Image = Image.FromFile(dIgOpen.FileName);
                txtSize.Text = picAutoSize.Width.ToString() +"x" + picAutoSize.Height.ToString();
            }
        }

        private void frmMainForm_Load(object sender, EventArgs e)
        {
            width = Width;
            height = Height;

        }
    }
}
