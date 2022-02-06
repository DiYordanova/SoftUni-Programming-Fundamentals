using System;

namespace _20.ObectsAndClasses_Fundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(' ');
            Random rnd = new Random();
            for (int i = 0; i < words.Length; i++)
            {
                int randomPosition = rnd.Next(0, words.Length);
                string temp = words[i];
                words[i] = words[randomPosition];
                words[randomPosition] = temp;
            }

            Console.WriteLine(string.Join(Environment.NewLine, words));
        }
    }
}

