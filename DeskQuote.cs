using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace MegaDesk_Rasmussen
{
    public class DeskQuote
    {
        public Desk Desk { get; set; }
        public int RushDays { get; set; }
        public string CustomerName { get; set; }
        public DateTime QuoteDate { get; set; }

        private const string FilePath = "quotes.json";

        // Constructor
        public DeskQuote(Desk desk, int rushDays, string customerName)
        {
            Desk = desk;
            RushDays = rushDays;
            CustomerName = customerName;
            QuoteDate = DateTime.Now; // Set the current date as the quote date
        }

        // Method to calculate the quote total
        public decimal CalculateQuote()
        {
            decimal basePrice = 200; // base price for a desk
            decimal surfaceMaterialCost = GetMaterialCost();
            decimal drawerCost = Desk.NumDrawers * 50; // $50 per drawer
            decimal rushOrderCost = GetRushOrderCost();

            // Formula for total price
            decimal totalPrice = basePrice + surfaceMaterialCost + drawerCost + rushOrderCost;
            return totalPrice;
        }

        // Get material cost based on selected material
        private decimal GetMaterialCost()
        {
            switch (Desk.Material)
            {
                case DesktopMaterial.Laminate:
                    return 100;
                case DesktopMaterial.Wood:
                    return 200;
                case DesktopMaterial.Veneer:
                    return 150;
                case DesktopMaterial.Pine:
                    return 50;
                default:
                    return 0;
            }
        }

        // Get rush order cost based on rush days
        private decimal GetRushOrderCost()
        {
            if (RushDays == 3)
                return 50; // Rush order for 3 days
            else if (RushDays == 5)
                return 40; // Rush order for 5 days
            else if (RushDays == 7)
                return 30; // Rush order for 7 days
            else
                return 0; // No rush order
        }

        // Save the quote to a JSON file
        public void SaveQuote()
        {
            List<DeskQuote> quotes = new List<DeskQuote>();

            // Ensure file exists and read existing quotes
            if (File.Exists(FilePath))
            {
                string existingJson = File.ReadAllText(FilePath);
                if (!string.IsNullOrWhiteSpace(existingJson))
                {
                    quotes = JsonConvert.DeserializeObject<List<DeskQuote>>(existingJson) ?? new List<DeskQuote>();
                }
            }

            // Add the new quote
            quotes.Add(this);

            // Serialize and write back to file
            File.WriteAllText(FilePath, JsonConvert.SerializeObject(quotes, Formatting.Indented));

            Console.WriteLine("Quote saved successfully!");
        }
    }
}
