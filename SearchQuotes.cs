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
            listViewMaterialSearchResults.View = View.Details;
            listViewMaterialSearchResults.FullRowSelect = true;
            listViewMaterialSearchResults.ItemActivate += listViewMaterialSearchResults_ItemActivate;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cmbMaterialSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
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

                foreach (var quote in allQuotes)
                {
                    if (Enum.TryParse(typeof(DesktopMaterial), quote.Desk.Material.ToString(), out var parsedMaterial))
                    {
                        quote.Desk.Material = (DesktopMaterial)parsedMaterial;
                    }
                }
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
            }
            else
            {
                foreach (var quote in filteredQuotes)
                {
                    var item = new ListViewItem(quote.CustomerName); 
                    listViewMaterialSearchResults.Items.Add(item);
                }
            }
        }

        private void listViewMaterialSearchResults_ItemActivate(object? sender, EventArgs e)
        {
            if (listViewMaterialSearchResults.SelectedItems.Count > 0)
            {
                var selectedItem = listViewMaterialSearchResults.SelectedItems[0];

                string selectedCustomerName = selectedItem.Text;

                DeskQuote selectedQuote = allQuotes.FirstOrDefault(q =>
                    q.CustomerName == selectedCustomerName);

                if (selectedQuote != null)
                {
                    DisplayQuote displayQuoteForm = new DisplayQuote(selectedQuote);
                    displayQuoteForm.Show();
                    this.Hide();
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
