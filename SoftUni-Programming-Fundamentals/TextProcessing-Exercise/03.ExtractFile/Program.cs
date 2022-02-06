using System;

namespace _03
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split('\\', StringSplitOptions.RemoveEmptyEntries);
            string[] lastInput = input[input.Length - 1].Split(".");

            Console.WriteLine($"File name: {lastInput[0]}");
            Console.WriteLine($"File extension: {lastInput[1]}");
        }
    }
}

