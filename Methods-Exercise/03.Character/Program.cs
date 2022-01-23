using System;

namespace _03.Character
{
    class Program
    {
        static void Main(string[] args)
        {
            char ch1 = char.Parse(Console.ReadLine());
            char ch2 = char.Parse(Console.ReadLine());
            PrintCharacterBetween(ch1, ch2);
        }

        private static void PrintCharacterBetween(char ch1, char ch2)
        {
            
            if (ch1 < ch2)
            {
                for (int i = ch1+ 1; i < ch2; i++)
                {
                    Console.Write($"{(char)i} ");
                }
            }

            else
            {
                for (int i = ch2 + 1; i < ch1; i++)
                {
                    Console.Write($"{(char)i} ");
                }
            }
        }
    }
}
