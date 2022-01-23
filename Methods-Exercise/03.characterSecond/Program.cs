using System;

namespace _03.characterSecond
{
    class Program
    {
        static void Main(string[] args)
        {
            char ch1 = char.Parse(Console.ReadLine());
            char ch2 = char.Parse(Console.ReadLine());
            char start = ch1;
            char end = ch2;
            if (ch2 < ch1)
            {
                start = ch2;
                end = ch1;
            }

            PrintCharacterInRange(start, end);
        }

        private static void PrintCharacterInRange(char start, char end)
        {
            for (int i = start +1; i < end; i++)
            {
                Console.Write($"{i} ");
            }
        }
    }
}
