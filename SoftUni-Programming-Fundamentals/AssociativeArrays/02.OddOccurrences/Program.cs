using System;
using System.Collections.Generic;

namespace _02
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split();
            Dictionary<string, int> counts = new Dictionary<string, int>();
            foreach (var word in words)
            {
                string wordInLower = word.ToLower();

                if (counts.ContainsKey(wordInLower))
                {
                    counts[wordInLower]++;
                }

                else
                {
                    counts.Add(wordInLower, 1);
                }
            }

            foreach (var pair in counts)
            {
                if (pair.Value % 2 != 0)
                {
                    Console.Write(pair.Key + " ");

                }
            }
        }
    }
}

