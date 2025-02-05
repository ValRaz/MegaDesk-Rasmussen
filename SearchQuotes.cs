using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;

namespace MegaDesk_Rasmussen
{
    public partial class SearchQuotes : Form
    {
        private List<DeskQuote> allQuotes;
        public SearchQuotes()
        {
            InitializeComponent();
        }

        private void SearchQuotes_Load(object sender, EventArgs e)
        {
            cmbMaterialSearch.DataSource = Enum.GetValues(typeof(DesktopMaterial));
            LoadQuotesFromJson();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cmbMaterialSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbMaterialSearch.DataSource = Enum.GetValues(typeof(DesktopMaterial));
        }

        private void btnMaterialSearch_Click(object sender, EventArgs e)
        {
            if (cmbMaterialSearch.SelectedItem != null)
            {
                DesktopMaterial selectedMaterial = (DesktopMaterial)cmbMaterialSearch.SelectedItem;

                List<DeskQuote> filteredQuotes = FilterQuotesByMaterial(selectedMaterial);

                DisplayFilteredQuotes(filteredQuotes);
            }
            else
            {
                MessageBox.Show("Please select a material to search.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadQuotesFromJson()
        {
            string filePath = "quotes.json";
            if (File.Exists(filePath))
            {
                string jsonContent = File.ReadAllText(filePath);
                allQuotes = JsonConvert.DeserializeObject<List<DeskQuote>>(jsonContent) ?? new List<DeskQuote>();
            }
            else
            {
                allQuotes = new List<DeskQuote>();
            }
        }

        private List<DeskQuote> FilterQuotesByMaterial(DesktopMaterial material)
        {
            return allQuotes?.Where(quote => quote.Desk.Material == material).ToList() ?? new List<DeskQuote>();
        }

        private void DisplayFilteredQuotes(List<DeskQuote> filteredQuotes)
        {
            listViewMaterialSearchResults.Items.Clear();

            if (filteredQuotes.Count == 0)
            {
                listViewMaterialSearchResults.Items.Add(new ListViewItem("No quotes found for the selected material"));
                listViewMaterialSearchResults.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            }
            else
            {
                foreach (var quote in filteredQuotes)
                {
                    var item = new ListViewItem(quote.CustomerName);
                    item.SubItems.Add(quote.QuoteDate.ToShortDateString());
                    item.SubItems.Add(quote.Desk.Material.ToString());
                    item.SubItems.Add(quote.CalculateQuote().ToString("C"));

                    listViewMaterialSearchResults.Items.Add(item);
                }
            }
        }

        private void listViewMaterialSearchResults_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewMaterialSearchResults.SelectedItems.Count > 0)
            {
                var selectedItem = listViewMaterialSearchResults.SelectedItems[0];

                string selectedCustomerName = selectedItem.Text;
                DateTime selectedQuoteDate = DateTime.Parse(selectedItem.SubItems[1].Text);

                DeskQuote selectedQuote = allQuotes.FirstOrDefault(q =>
                    q.CustomerName == selectedCustomerName && q.QuoteDate == selectedQuoteDate);

                if (selectedQuote != null)
                {
                    DisplayQuote displayQuoteForm = new DisplayQuote(selectedQuote);
                    displayQuoteForm.Show();
                }
            }
        }

        private void btnBackToMain_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
            this.Close();
        }
    }
}
