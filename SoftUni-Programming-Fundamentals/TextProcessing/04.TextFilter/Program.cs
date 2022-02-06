using System;

namespace _04
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] word = Console.ReadLine().Split(", ");
            string text = Console.ReadLine();

            for (int i = 0; i < word.Length; i++)
            {
                text = text.Replace(word[i], new string('*', word[i].Length));
            }

            Console.WriteLine(text);
        }
    }
}

