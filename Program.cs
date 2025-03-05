using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] inventory = {
                {"Laptop", "Electronics", "85000", "5"},
                {"Bluetooth Speaker", "Electronics", "6000", "15"},
                {"T-Shirt", "Clothing", "1500", "25"},
                {"Running Shoes", "Footwear", "7000", "12"},
                {"Pen", "Stationery", "50", "100"}
            };

            Console.WriteLine("Product Inventory:\n");
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine("Product\t\tCategory\t\tPrice\tStock");
            Console.WriteLine("------------------------------------------------------");

            int rowCount = inventory.GetLength(0);
            int colCount = inventory.GetLength(1);

            foreach (int i in Enumerable.Range(0, rowCount))
            {
                foreach (int j in Enumerable.Range(0, colCount))
                {
                    Console.Write(inventory[i, j] + "\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\nTotal Stock Value for Each Product:\n");

            foreach (int i in Enumerable.Range(0, rowCount))
            {
                double price = Convert.ToDouble(inventory[i, 2]);
                int stock = Convert.ToInt32(inventory[i, 3]);
                double totalValue = price * stock;
                Console.WriteLine("{0}: {1:C}", inventory[i, 0], totalValue);
            }

            Console.ReadKey();
        }
    }
}
