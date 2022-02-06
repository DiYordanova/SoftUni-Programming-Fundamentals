﻿using System;

namespace _05.Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            int countProduct = int.Parse(Console.ReadLine());            
            PriceProducts(product, countProduct);            
        }

        static void PriceProducts(string product, int countProduct)
        {
            double price = 0;
            switch (product)
            {
                case "coffee":
                    price = 1.50;
                    break;
                case "water":
                    price = 1;
                    break;
                case "coke":
                    price = 1.40;
                    break;
                case "snacks":
                    price = 2.00;
                    break;                   
            }

            double totalPrice = price * countProduct;
            Console.WriteLine($"{totalPrice:f2}");
        }
    }
}
