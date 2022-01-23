using System;

namespace _02.VowelsCoint
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int vowelCount = GetVowelCount(text);

            Console.WriteLine(vowelCount);
        }

        private static int GetVowelCount(string text)
        {
            int count = 0;
            text = text.ToLower();
            foreach (char letter in text)
            {
                if( letter == 97 ||
                    letter == 101 ||
                    letter == 105 ||
                    letter == 111 ||
                    letter == 117 ||
                    letter == 121)
                {
                    count++; 
                }
            }       
            return count;
        }
    }    
}
