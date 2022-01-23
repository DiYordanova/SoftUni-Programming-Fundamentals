using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _04
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            Regex keyRegex = new Regex(@"[sStTaArR]");
            Regex regex = new Regex(@"@(?<Planet>[A-za-z]+)\d*[^@\-!:>]*:(?<Population>\d+)[^@\-!:>]*!(?<Action>[AD])![^@\-!:>]*->(?<Soldier>\d+)");
            List<string> attacked = new List<string>();
            List<string> destroyed = new List<string>();

            for (int i = 0; i < number; i++)
            {
                string input = Console.ReadLine();

                int key = keyRegex.Matches(input).Count;

                StringBuilder sb = new StringBuilder();

                foreach (var character in input)
                {
                    sb.Append((char)(character - key));
                }

                Match match = regex.Match(sb.ToString());

                if (!match.Success)
                {
                    continue;
                }

                string name = match.Groups[1].Value;
                string type = match.Groups[3].Value;

                if (type == "A")
                {
                    attacked.Add(name);
                }

                else
                {
                    destroyed.Add(name);
                }
            }

            Console.WriteLine($"Attacked planets: {attacked.Count}");

            List<string> sortedAttacked = attacked.OrderBy(x => x).ToList();

            foreach (var planet in sortedAttacked)
            {
                Console.WriteLine($"-> {planet}");
            }

            Console.WriteLine($"Destroyed planets: {destroyed.Count}");

            List<string> sortedDestroyed = destroyed.OrderBy(x => x).ToList();

            foreach (var planet in sortedDestroyed)
            {
                Console.WriteLine($"-> {planet}");
            }
        }
    }
}
