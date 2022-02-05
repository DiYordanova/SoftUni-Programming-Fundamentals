using System;
using System.Linq;

namespace _05
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split();

            string[] evenWords = words.Where(n => n.Length % 2 == 0).ToArray();

            foreach (var item in evenWords)
            {
                Console.WriteLine(item);
            }
        }
    }
}
