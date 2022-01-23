using System;
using System.Collections.Generic;
using System.Linq;

namespace _03
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> legendaryItems = new Dictionary<string, int>
             {
                 {"shards", 0},
                 {"fragments", 0 },
                 {"motes", 0 }
             };

            Dictionary<string, int> junkItems = new Dictionary<string, int>();
            string winner = " ";
            bool isRunning = true;

            while (isRunning)
            {
                string input = Console.ReadLine();
                string[] parts = input.Split();

                for (int i = 0; i < parts.Length; i += 2)
                {
                    int quantity = int.Parse(parts[i]);
                    string item = parts[i + 1].ToLower();

                    if (legendaryItems.ContainsKey(item))
                    {
                        legendaryItems[item] += quantity;

                        if (legendaryItems[item] >= 250)
                        {
                            legendaryItems[item] -= 250;
                            winner = item;
                            isRunning = false;
                            break;
                        }
                    }

                    else
                    {
                        if (junkItems.ContainsKey(item))
                        {
                            junkItems[item] += quantity;
                        }

                        else
                        {
                            junkItems.Add(item, quantity);
                        }
                    }
                }
            }

            if (winner == "shards")
            {
                Console.WriteLine("Shadowmourne obtained!");
            }

            else if (winner == "fragments")
            {
                Console.WriteLine("Valanyr obtained!");
            }

            else
            {
                Console.WriteLine("Dragonwrath obtained!");
            }

            Dictionary<string, int> sortedLegendary = legendaryItems.OrderByDescending(x => x.Value)
                 .ThenBy(x => x.Key)
                 .ToDictionary(x => x.Key, x => x.Value);

            foreach (var pair in sortedLegendary)
            {
                Console.WriteLine($"{pair.Key}: {pair.Value}");
            }

            Dictionary<string, int> sortedJunk = junkItems.OrderBy(x => x.Key)
                 .ToDictionary(x => x.Key, x => x.Value);

            foreach (var pair in sortedJunk)
            {
                Console.WriteLine($"{pair.Key}: {pair.Value}");
            }
        }
    }
}
