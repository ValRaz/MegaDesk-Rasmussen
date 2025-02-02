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
    public partial class DisplayQuote : Form
    {
        private DeskQuote _quote;
        public DisplayQuote(DeskQuote quote)
        {
            InitializeComponent();

            _quote = quote;
        }

        private void DisplayQuote_Load(object sender, EventArgs e)
        {
            lblCustomerName.Text = $"Customer: {_quote.CustomerName}";
            lblQuoteDate.Text = $"Quote Date: {_quote.QuoteDate.ToShortDateString()}";
            lblMaterial.Text = $"Material: {_quote.Desk.Material}";
            lblWidth.Text = $"Width: {_quote.Desk.Width} inches";
            lblDepth.Text = $"Depth: {_quote.Desk.Depth} inches";
            lblDrawers.Text = $"Drawers: {_quote.Desk.NumDrawers}";
            lblRushOrder.Text = $"Rush Order: {_quote.RushDays} days";
            lblTotal.Text = $"Total: {_quote.CalculateQuote():C}";  // Display total in currency format
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
            this.Close();
        }
    }
}
