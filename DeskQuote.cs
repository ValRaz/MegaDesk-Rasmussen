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

        /// Method to calculate the quote total
        public decimal CalculateQuote()
        {
            decimal basePrice = 200; // base price for a desk
            decimal surfaceMaterialCost = GetMaterialCost();
            decimal drawerCost = Desk.NumDrawers * 50; // $50 per drawer
            decimal rushOrderCost = GetRushOrderCost();

            int surfaceArea = GetSurfaceArea(); // Get the surface area

            // Extra cost for surface area greater than 1000 in²
            decimal surfaceAreaCost = surfaceArea > 1000 ? (surfaceArea - 1000) * 1 : 0;

            // Formula for total price
            decimal totalPrice = basePrice + surfaceMaterialCost + drawerCost + rushOrderCost + surfaceAreaCost;
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
            int surfaceArea = Desk.Width * Desk.Depth;
            int rushPrice = 0;

            int[,] rushOptions = GetRushOrder();

            if (rushOptions == null)
            {
                System.Diagnostics.Debug.WriteLine("Error: rushOptions is null.");
                return 0;
            }

            // Print the value of rushOptions[0,0]
            Console.WriteLine($"rushOptions[0,0]: {rushOptions[0,0]}");

            if (RushDays == 3)
                switch (surfaceArea)
                {
                    case int n when (n < 1000):
                        rushPrice = rushOptions[0, 0];
                        break;
                    case int n when (n >= 1000 && n <= 2000):
                        rushPrice = rushOptions[0, 1];
                        break;
                    case int n when (n > 2000):
                        rushPrice = rushOptions[0, 2];
                        break;
                }
            else if (RushDays == 5)
                switch (surfaceArea)
                {
                    case int n when (n < 1000):
                        rushPrice = rushOptions[1, 0];
                        break;
                    case int n when (n >= 1000 && n <= 2000):
                        rushPrice = rushOptions[1, 1];
                        break;
                    case int n when (n > 2000):
                        rushPrice = rushOptions[1, 2];
                        break;
                }
            else if (RushDays == 7)
            {
                switch (surfaceArea)
                {
                    case int n when (n < 1000):
                        rushPrice = rushOptions[2, 0];
                        break;
                    case int n when (n >= 1000 && n <= 2000):
                        rushPrice = rushOptions[2, 1];
                        break;
                    case int n when (n > 2000):
                        rushPrice = rushOptions[2, 2];
                        break;
                }
            }
            else
            {
                rushPrice = 0;
            }
            return rushPrice;
        }

        static int[,] GetRushOrder()
        {
            try
            {

                string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "data", "rushOrderTxt.txt");
                //decimal rushPrice = 0;
                if (!File.Exists(filePath))
                {
                    System.Diagnostics.Debug.WriteLine("File not found");
                }

                // Read lines and remove empty ones
                string[] lines = File.ReadAllLines(filePath);

                int rowCount = 3;
                int columnCount = 3; ;

                if (lines.Length != rowCount * columnCount)
                {
                    System.Diagnostics.Debug.WriteLine($"Error: Expected {rowCount * columnCount} values, but found {lines.Length}");
                    return null;
                }

                int[,] rushOrderPrices = new int[rowCount, columnCount];

                int index = 0; //track the index of the array

                for (int i = 0; i < rowCount; i++)
                {

                    for (int j = 0; j < columnCount; j++)
                    {
                        if (!int.TryParse(lines[index].Trim(), out rushOrderPrices[i, j]))
                        {
                            System.Diagnostics.Debug.WriteLine($"Error: Cannot parse '{lines[index]}' at row {i + 1}, column {j + 1}");
                            return null;
                        }

                        System.Diagnostics.Debug.Write($"[{rushOrderPrices[i, j]}] ");
                        index++;
                    }

                };
                return rushOrderPrices;
            }

            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error reading file: {ex.Message}");
                return null;
            }

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
