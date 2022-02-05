using System;

namespace _01.RandomWithClass
{
    class Program
    {
        static void Main(string[] args)
        {
            StringRandomizer randomizer = new StringRandomizer();
            randomizer.words = Console.ReadLine().Split();
            randomizer.Randomise();
            randomizer.PrintWords();
        }
    }

    public class StringRandomizer
    {
        public string[] words;

        public void Randomise()
        {
            Random rnd = new Random();

            for (int i = 0; i < words.Length; i++)
            {
                int randomPosition = rnd.Next(0, words.Length);
                string temp = words[i];
                words[i] = words[randomPosition];
                words[randomPosition] = temp;
            }
        }
        public void PrintWords()
        {
            Console.WriteLine(string.Join(Environment.NewLine, words));
        }
    }
}
