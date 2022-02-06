using System;

namespace _01
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string text = Console.ReadLine();
                string result = "";

                if (text == "end")
                {
                    break;
                }

                for (int i = text.Length - 1; i >= 0; i--)
                {
                    result += text[i];
                }

                Console.WriteLine($"{text} = {result}");
            }
        }
    }
}
