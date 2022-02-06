using System;
using System.Collections.Generic;

namespace _04.vtori
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, decimal> priceByProduct = new Dictionary<string, decimal>();
            Dictionary<string, int> quantityByProduct = new Dictionary<string, int>();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "buy")
                {
                    break;
                }

                string[] parts = input.Split();
                string name = parts[0];
                decimal price = decimal.Parse(parts[1]);
                int quantity = int.Parse(parts[2]);

                if (priceByProduct.ContainsKey(name))
                {
                    quantityByProduct[name] += quantity;
                    priceByProduct[name] = price;
                }

                else
                {
                    priceByProduct.Add(name, price);
                    quantityByProduct.Add(name, quantity);
                }
            }

            foreach (var pair in priceByProduct)
            {
                string product = pair.Key;
                decimal price = pair.Value;
                int quantity = quantityByProduct[product];
                decimal totalPrice = price * quantity;
                Console.WriteLine($"{product} -> {totalPrice:f2}");
            }
        }
    }
}

