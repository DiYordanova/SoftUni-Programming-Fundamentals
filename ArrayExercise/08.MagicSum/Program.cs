using System;
using System.Linq;

namespace _08.MagicSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int number = int.Parse(Console.ReadLine());
            for (int i = 0; i < numbers.Length; i++)
            {
                int currentNumber = numbers[i];
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    int rightNumber = numbers[j];
                    if (number == currentNumber + rightNumber)
                    {
                        Console.WriteLine($"{currentNumber} {rightNumber}");
                    }
                }
            }
        }
    }
}
