using System;
using System.Text.RegularExpressions;

namespace _03
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"^[^|$%\.]*%(?<name>[A-z][a-z]+)%[^|$%\.]*<(?<product>\w+)>[^|$%\.]*\|(?<count>\d+)\|[^|$%\.]*?(?<price>\d+\.?\d*)[^|$%\.]*\$$";
            double totalIncomeCustemer = 0;
            double income = 0;

            while (true)
            {
                string line = Console.ReadLine();
                if (line == "end of shift")
                {
                    break;
                }

                Match match = Regex.Match(line, pattern);

                if (!match.Success)
                {
                    continue;
                }

                string name = match.Groups["name"].Value;
                string product = match.Groups["product"].Value;
                int count = int.Parse(match.Groups["count"].Value);
                double price = double.Parse(match.Groups["price"].Value);
                totalIncomeCustemer = price * count;
                income += totalIncomeCustemer;

                Console.WriteLine($"{name}: {product} - {totalIncomeCustemer:f2}");
            }

            Console.WriteLine($"Total income: {income:f2}");
        }
    }
}
