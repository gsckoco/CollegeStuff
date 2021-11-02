using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserLoginWPF
{
    public partial class frmLogin : Form
    {
        private string strUsername = "username1";
        private string strPassword = "pass1";
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit", "", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbxUsername.Text = null;
            tbxPassword.Text = null;
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            if (tbxUsername.Text == strUsername)
            {
                if (tbxPassword.Text == strPassword)
                {
                    this.Hide();
                    frmMainMenu mainMenu = new frmMainMenu();
                    mainMenu.Show();
                    btnClear_Click(sender, null);
                    return;
                    //Application.Run(new frmMainMenu());
                    //frmLoggedIn.
                } else
                {
                    MessageBox.Show("Incorrect password");
                }
            } else
            {
                MessageBox.Show("Incorrect username");
            }
            btnClear_Click(sender, null);
        }
    }
}
