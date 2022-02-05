using System;
using System.Text.RegularExpressions;

namespace _02
{
    class Program
    {
        static void Main(string[] args)
        {
            var phones = Console.ReadLine();
            var regex = @"((\+359 2 \d{3} \d{4})|(\+359-2-\d{3}-\d{4}\b))";
            var phoneMatches = Regex.Matches(phones, regex);

            Console.WriteLine(string.Join(", ", phoneMatches));
        }
    }
}
