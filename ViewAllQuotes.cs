using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;

namespace MegaDesk_Rasmussen
{
    public partial class ViewAllQuotes : Form
    {
        public ViewAllQuotes()
        {
            InitializeComponent();
        }

        private void ViewAllQuotes_Load(object sender, EventArgs e)
        {
            LoadQuotes();
        }

        private void LoadQuotes()
        {
            string filePath = "quotes.json";

            if (File.Exists(filePath))
            {
                string jsonContent = File.ReadAllText(filePath);

                List<DeskQuote> allQuotes = JsonConvert.DeserializeObject<List<DeskQuote>>(jsonContent);

                if (allQuotes == null || allQuotes.Count == 0)
                {
                    MessageBox.Show("No saved quotes found.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                DataTable table = new DataTable();

                table.Columns.Add("Customer Name", typeof(string));
                table.Columns.Add("Quote Date", typeof(string));
                table.Columns.Add("Material", typeof(string));
                table.Columns.Add("Price", typeof(string));

                foreach (var quote in allQuotes)
                {
                    table.Rows.Add(
                        quote.CustomerName,
                        quote.QuoteDate.ToShortDateString(),
                        quote.Desk.Material.ToString(),
                        quote.CalculateQuote().ToString("C")
                    );
                }

                dataViewAll.DataSource = table;

                dataViewAll.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            }
            else
            {
                MessageBox.Show("Quotes file not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLoadQuotes_Click(object sender, EventArgs e)
        {
            LoadQuotes();
        }

        private void btnBackToMain_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
            this.Close();
        }
    }
}
