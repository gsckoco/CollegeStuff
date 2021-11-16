using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookTaxi
{
    public partial class frmMainMenu : Form
    {
        List<string[]> listAllBookings = new List<string[]>();
        public frmMainMenu()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtBookingNumber.Text = null;
            txtCustomerName.Text = null;
            txtStartLocation.Text = null;
            txtEndLocation.Text = null;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string strBookingNumber = txtBookingNumber.Text;
            string strCustomerName = txtCustomerName.Text;
            string strStartLocation = txtStartLocation.Text;
            string strEndLocation = txtEndLocation.Text;
            btnClear_Click(sender, e);
            string[] row = { strBookingNumber, strCustomerName, strStartLocation, strEndLocation };
            listAllBookings.Add(row);
            MessageBox.Show("Booking has been saved", "Saved");

            //btnSave.Hide();
        }

        private void lblViewAll_Click(object sender, EventArgs e)
        {
            lstAllBookings.Items.Clear();
            for (int i = 0; i < listAllBookings.Count; i++)
            {
                string row = "#" + listAllBookings[i][0] + " " + listAllBookings[i][1] + " " + listAllBookings[i][2] + " -> " + listAllBookings[i][3];
                lstAllBookings.Items.Add(row);
            }
        }
    }
}
