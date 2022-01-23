using System;
using System.Collections.Generic;

namespace _03
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, List<string>> wordSynonym = new Dictionary<string, List<string>>();

            for (int i = 0; i < n; i++)
            {
                string word = Console.ReadLine();
                string synonym = Console.ReadLine();

                if (wordSynonym.ContainsKey(word))
                {
                    wordSynonym[word].Add(synonym);
                }

                else
                {
                    wordSynonym.Add(word, new List<string>());
                    wordSynonym[word].Add(synonym);
                }
            }
            foreach (var pair in wordSynonym)
            {
                Console.WriteLine(pair.Key + " - " + string.Join(", ", pair.Value));
            }
        }
    }
}

