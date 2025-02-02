using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_Rasmussen
{
    public partial class AddQuote : Form
    {
        public AddQuote()
        {
            InitializeComponent();
        }

        private void AddQuote_Load(object sender, EventArgs e)
        {
            cmbMaterial.DataSource = Enum.GetValues(typeof(DesktopMaterial));
        }

        private void numWidth_Validating(object sender, CancelEventArgs e)
        {
            if (numWidth.Value < 24 || numWidth.Value > 96)
            {
                MessageBox.Show("Width must be between 24 and 96 inches.", "Invalid Width", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Cancel = true;
            }
        }

        private void numDepth_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void backToMainMenu_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
            this.Close();
        }

        private void btnGetQuote_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtCustomerName.Text))
                {
                    MessageBox.Show("Please enter a customer name.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int rushOrderDays = (int)numRushOrder.Value;
                if (rushOrderDays != 3 && rushOrderDays != 5 && rushOrderDays != 7)
                {
                    MessageBox.Show("Please select a valid rush order option (3, 5, or 7 days).", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (cmbMaterial.SelectedItem == null)
                {
                    MessageBox.Show("Please select a desktop material.", "Invalid Material", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                DesktopMaterial material = (DesktopMaterial)cmbMaterial.SelectedItem;

                int numDrawers = (int)numNumDrawers.Value;
                if (numDrawers < 0 || numDrawers > 7)
                {
                    MessageBox.Show("Number of drawers must be between 0 and 7.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Desk desk = new Desk((int)numWidth.Value, (int)numDepth.Value, numDrawers, material);

                DeskQuote quote = new DeskQuote(desk, rushOrderDays, txtCustomerName.Text);

                decimal quoteTotal = quote.CalculateQuote();

                DisplayQuote displayQuoteForm = new DisplayQuote(quote);
                displayQuoteForm.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

