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
                    return 125;
                case DesktopMaterial.Pine:
                    return 50;
                case DesktopMaterial.Rosewood:
                    return 300;
                default:
                    return 0;
            }
        }

        private int GetSurfaceArea()
        {
            return Desk.Width * Desk.Depth;
        }

        // Get rush order cost based on rush days
        private decimal GetRushOrderCost()
        {
            if (RushDays == 0)
                return 0; 

            if (RushDays == 3)
            {
                if (GetSurfaceArea() < 1000) return 60;
                if (GetSurfaceArea() <= 2000) return 70;
                return 80;
            }
            if (RushDays == 5)
            {
                if (GetSurfaceArea() < 1000) return 40;
                if (GetSurfaceArea() <= 2000) return 50;
                return 60;
            }
            if (RushDays == 7)
            {
                if (GetSurfaceArea() < 1000) return 30;
                if (GetSurfaceArea() <= 2000) return 35;
                return 40;
            }

            return 0; 
        }

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
