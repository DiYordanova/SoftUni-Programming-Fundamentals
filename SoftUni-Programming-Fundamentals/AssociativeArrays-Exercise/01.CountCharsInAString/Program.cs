using System;
using System.Collections.Generic;

namespace _25AssociateArrayFundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<char, int> charCounts = new Dictionary<char, int>();

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == ' ')
                {
                    continue;
                }

                if (!charCounts.ContainsKey(input[i]))
                {
                    charCounts.Add(input[i], 1);
                }

                else
                {
                    charCounts[input[i]]++;
                }
            }

            foreach (var pair in charCounts)
            {
                Console.WriteLine(pair.Key + " -> " + pair.Value);
            }
        }
    }
}
