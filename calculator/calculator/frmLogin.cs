using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.tbxForename.Text = null;
            this.tbxSurname.Text = null;
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            string forename = this.tbxForename.Text.Trim();
            string surname = this.tbxSurname.Text.Trim();

            if (forename.Length > 0 && surname.Length > 0)
            {
                frmMainMenu mainMenu = new frmMainMenu(forename, surname);
                mainMenu.Show();
                this.Hide();
            } else
            {
                btnEnter_Click(sender, null);
                MessageBox.Show("Forename or surname cannot be empty", "Error");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
