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
    public partial class frmMainMenu : Form
    {
        private string forename, surname;

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.OpenForms["frmLogin"].Show();
            this.Close();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            float number1, number2;
            try
            {
                number1 = float.Parse(this.tbxNumber1.Text);
                number2 = float.Parse(this.tbxNumber2.Text);
            } catch (FormatException _)
            {
                MessageBox.Show("Input has to be a number");
                return;
            }

            float result = 0;

            switch (this.tbxSymbol.Text.ToLower())
            {
                case ("x"):
                case ("*"):
                    result = number1 * number2;
                    break;
                case ("/"):
                    result = number1 / number2;
                    break;
                case ("**"):
                case ("^"):
                    result = (float)Math.Pow((double)number1, (double)number2);
                    break;
                case ("+"):
                    result = number1 + number2;
                    break;
                case ("-"):
                    result = number1 - number2;
                    break;
            }

            this.lblResult.Text = "= " + result;
        }

        public frmMainMenu(string forename, string surname)
        {
            this.forename = forename;
            this.surname = surname;
            InitializeComponent();
        }
    }
}
