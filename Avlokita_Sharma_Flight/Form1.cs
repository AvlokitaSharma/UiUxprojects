using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Avlokita_Sharma_Flight
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

        private void frmMainForm_Load(object sender, EventArgs e)
        {
            lstCities.Items.Clear();
            lstCities.Items.Add(" San Diego");
            lstCities.Items.Add(" Los Angeles");
            lstCities.Items.Add(" Long Beach");
            lstCities.Items.Add(" Sacramento");
            lstCities.Items.Add(" Ventura");
            lstCities.Items.Add(" Palm Spring");
            lstCities.Items.Add(" Valencia");

            cboSeat.Items.Add("Aisle");
            cboSeat.Items.Add("Middle");
            cboSeat.Items.Add("Window");
            cboSeat.SelectedIndex= 0;


            cboMeal.Items.Add("Chicken");
            cboMeal.Items.Add("Vegetarian");
            cboMeal.Items.Add("Beef");
            cboMeal.Items.Add("Fish");
            cboMeal.Text = "No Preference";





        }

        private void btnAssign_Click(object sender, EventArgs e)
        {
            string message;
            message = $"Destination: {lstCities.Text} \r \n";
            message += $"Seat Selection : {cboSeat.Text} \r \n";
            message += $" Meal Selection : {cboMeal.Text}";
            MessageBox.Show(message);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
