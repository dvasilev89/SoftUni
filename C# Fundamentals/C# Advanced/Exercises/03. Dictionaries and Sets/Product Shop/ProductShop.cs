using System;
using System.Collections.Generic;
using System.Linq;

namespace Product_Shop
{
    class ProductShop
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, Dictionary<string, double>> shops = new SortedDictionary<string, Dictionary<string, double>>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "Revision")
                {
                    break;
                }

                string[] shopInfo = input
                    .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string shopName = shopInfo[0];
                string product = shopInfo[1];
                double price = double.Parse(shopInfo[2]);

                if (shops.ContainsKey(shopName) == false)
                {
                    shops.Add(shopName, new Dictionary<string, double>());
                }

                if (shops[shopName].ContainsKey(product) == false)
                {
                    shops[shopName].Add(product, price);
                }
            }

            foreach (var shop in shops)
            {
                Console.WriteLine($"{shop.Key}->");

                Dictionary<string, double> products = shop.Value;

                foreach (var product in products)
                {
                    Console.WriteLine($"Product: {product.Key}, Price: {product.Value}");
                }
            }
        }
    }
}
