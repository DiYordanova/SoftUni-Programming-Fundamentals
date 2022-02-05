using System;
using System.Text.RegularExpressions;

namespace _30.RegexLab
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = @"\b[A-Z][a-z]+ [A-Z][a-z]+\b";
            Regex regex = new Regex(pattern);
            var matches = regex.Matches(input);
            foreach (Match match in matches)
            {
                Console.Write($"{match.Groups[0]} ");
            }
        }
    }
}

