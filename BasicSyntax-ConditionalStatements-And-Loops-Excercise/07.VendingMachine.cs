using System;

namespace _07.VendingMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            double sumCoint = 0;
            while (input != "Start")
            {
                double coint = double.Parse(input);
                if (coint == 0.1 || coint == 0.2 || coint == 0.5 || coint == 1 || coint == 2)
                {
                    sumCoint += coint;
                }

                else
                {
                    Console.WriteLine($"Cannot accept {coint}");
                }
                input = Console.ReadLine();
            }

            input = Console.ReadLine();
            double price = 0;

            while (input != "End")
            {
                if (input == "Nuts")
                {
                    price = 2.0;
                }

                else if (input == "Water")
                {
                    price = 0.7;
                }

                else if (input == "Crisps")
                {
                    price = 1.5;
                }

                else if (input == "Soda")
                {
                    price = 0.8;
                }

                else if (input == "Coke")
                {
                    price = 1.0;
                }

                else
                {
                    Console.WriteLine("Invalid product");
                    input = Console.ReadLine();
                    continue;
                }

                if (sumCoint >= price)
                {
                    Console.WriteLine($"Purchased {input.ToLower()}");
                    sumCoint -= price;
                }

                else
                {
                    Console.WriteLine("Sorry, not enough money");
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"Change: {sumCoint:f2}");
        }
    }
}
