/* Programmer: Blake Murdock
 * Due Date: October 10th, 2014
 * Purpose: 
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoCentre
{
    public partial class autoCentreForm : Form
    {
        // Constant Variables
        const decimal TAX_RATE_Decimal = .15m;
        //Accessories
        const double STEREO_SYSTEM_Double = 425.76d;
        const double LEATHER_INTERIOR_Double = 987.41d;
        const double COMPUTER_NAVIGATION_Double = 1741.23d;
        //Exterior Finish
        const double STANDARD_Double = 0.00d;
        const double PERALIZED_Double = 345.72d;
        const double CUSTOMIZED_DETAILING_Double = 599.99d;


        public autoCentreForm()
        {
            InitializeComponent();
        }

        private void autoCentreForm_Load(object sender, EventArgs e)
        {
            standardRadioButton.Checked = true;
            tradeInAllowanceTextBox.Text = "$0.00";
            carSalesPriceTextBox.Select();
            carSalesPriceTextBox.Focus();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {

        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            DialogResult returnDialogResult;
            returnDialogResult = MessageBox.Show("Clear the Auto Centre?", "Clear the Auto Centre?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (returnDialogResult == DialogResult.Yes)
            {
                tradeInAllowanceTextBox.Text = "$0.00"; 
                standardRadioButton.Checked = true;
                carSalesPriceTextBox.Clear();
                accessoriesFinishTextBox.Clear();
                subtotalTextBox.Clear();
                salesTaxTextBox.Clear();
                totalTextBox.Clear(); 
                amountDueTextBox.Clear();
                stereoSystemCheckBox.Checked = false;
                leatherInteriorCheckBox.Checked = false;
                computerNavigationCheckBox.Checked = false;
                carSalesPriceTextBox.Select();
                carSalesPriceTextBox.Focus();
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Exit the application
            this.Close();
        }
    }
}
