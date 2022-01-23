using System;

namespace _02.Article2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] articleData = Console.ReadLine().Split(", ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] commandParts = Console.ReadLine().Split(": ");
                string command = commandParts[0];
                string argument = commandParts[1];
                if (command == "Edit")
                {
                    articleData[1] = argument;
                }

                else if (command == "ChangeAuthor")
                {
                    articleData[2] = argument;
                }

                else
                {
                    articleData[0] = argument;
                }
            }
            Console.WriteLine($"{ articleData[0]} - { articleData[1]}: { articleData[2]}");
        }
    }
}

