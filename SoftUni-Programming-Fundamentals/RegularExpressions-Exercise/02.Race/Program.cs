using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] participans = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
            Dictionary<string, int> dict = new Dictionary<string, int>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "end of race")
                {
                    break;
                }

                string namePattern = @"[A-Za-z]*";
                string distance = @"\d";
                MatchCollection nameMatch = Regex.Matches(input, namePattern);
                MatchCollection distanceMatches = Regex.Matches(input, distance);

                var name = String.Concat(nameMatch);
                var sumDistance = distanceMatches.Select(x => int.Parse(x.Value)).Sum();

                if (participans.Contains(name))
                {
                    if (!dict.ContainsKey(name))
                    {
                        dict.Add(name, sumDistance);
                    }

                    else
                    {
                        dict[name] += sumDistance;
                    }
                }
            }

            var sorted = dict.OrderByDescending(x => x.Value).Select(x => x.Key).Take(3).ToList();

            Console.WriteLine($"1st place: {sorted[0]}");
            Console.WriteLine($"2nd place: {sorted[1]}");
            Console.WriteLine($"3rd place: {sorted[2]}");
        }
    }
}

