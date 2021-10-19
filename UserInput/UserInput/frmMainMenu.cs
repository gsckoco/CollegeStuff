using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows;
using System.Diagnostics;


namespace UserInput
{
    public partial class frmMainMenu : Form
    {
        public frmMainMenu()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            String forename = tbxForename.Text.Trim();
            String surname = tbxSurname.Text.Trim();
            String age = tbxAge.Text.Trim();
            int ageNumber = 0;
            bool isAgeANumber = int.TryParse(age, out ageNumber);
            if (forename.Length > 0 && surname.Length > 0 && age.Length > 0 && isAgeANumber)
            {
                MessageBox.Show("Your name is: " + forename + " " + surname + "\nAnd you are " + ageNumber + " years old", "Name");
            } else
            {
                if (!isAgeANumber)
                {
                    MessageBox.Show("Age has to be a number", "Error");
                    return;
                }
                MessageBox.Show("You have left a field blank", "Error");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to clear?", "Do you want to clear?", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                tbxSurname.Clear();
                tbxForename.Clear();
                tbxAge.Clear();
            }
        }

        private void randomPosition()
        {
            Random random = new Random();
            Point bounds = new Point();
            Rectangle size = Screen.GetBounds(bounds);
            this.SetDesktopLocation(random.Next(0, size.Width - this.Width), random.Next(0, size.Height - this.Height));

            /*Process[] runingProcess = Process.GetProcesses();
            for (int i = 0; i < runingProcess.Length; i++)
            {
                // compare equivalent process by their name
                if (runingProcess[i].ProcessName == "explorer")
                {
                    // kill  running process
                    runingProcess[i].Kill();
                }
            }*/
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            randomPosition();
            //this.Close();
        }

        private void frmMainMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            randomPosition();
        }

        private void frmMainMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            randomPosition();
            e.Cancel = true;
        }
    }
}
