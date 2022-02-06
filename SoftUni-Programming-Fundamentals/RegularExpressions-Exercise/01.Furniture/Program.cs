using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _31.RegexExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> furniture = new List<string>();
            string pattern = @">>([A-Za-z]+)<<(\d+\.?\d*)!(\d+)";
            double totalPrice = 0;

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "Purchase")
                {
                    break;
                }

                Match match = Regex.Match(input, pattern);

                if (match.Success)
                {
                    furniture.Add(match.Groups[1].Value);
                    totalPrice += double.Parse(match.Groups[2].Value) * int.Parse(match.Groups[3].Value);
                }
            }

            Console.WriteLine("Bought furniture:");

            if (furniture.Count > 0)
            {
                Console.WriteLine(string.Join(Environment.NewLine, furniture));
            }

            Console.WriteLine($"Total money spend: {totalPrice:f2}");
        }
    }
}
