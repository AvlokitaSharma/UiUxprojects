using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sharma_Avlokita_ListBox
{
    public partial class frmMainForm : Form
    {
        public frmMainForm()
        {
            InitializeComponent();
        }

        private void frmMainForm_Load(object sender, EventArgs e)
        {
            lstLeft.Items.Clear();
            lstLeft.Items.Add("Alabama");
            lstLeft.Items.Add("Alaska");
            lstLeft.Items.Add("California");
            lstLeft.Items.Add("Delaware");
            lstLeft.Items.Add("Florida");
            lstLeft.Items.Add("Georgia");
            lstLeft.Items.Add("Hawaii");
            lstLeft.Items.Add("Iowa");
            lstLeft.Items.Add("Maine");
            lstLeft.Items.Add("Nevada");
            lstLeft.Items.Add("Virgina");
            lstLeft.Items.Add("Alabama");
        }

        private void btnMove_Click(object sender, EventArgs e)
        {
            while (lstLeft.SelectedItems.Count != 0)
            {
                lstRight.Items.Add(lstLeft.Items[lstLeft.SelectedIndices[0]]);
                lstLeft.Items.RemoveAt(lstLeft.SelectedIndices[0]);
            }
        }

        private void lstRight_DoubleClick(object sender, EventArgs e)
        {
            if(lstRight.Items.Count != 0)
            {
                lstLeft.Items.Add(lstRight.Items[lstRight.SelectedIndex]);
                lstRight.Items.RemoveAt(lstRight.SelectedIndex);
                lstLeft.Sorted= true;
            }
        }

        private void frmMainForm_CausesValidationChanged(object sender, EventArgs e)
        {

        }
    }
}
