using System;
using System.Linq;

namespace _05.TopInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] number = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            for (int i = 0; i < number.Length; i++)
            {
                int currentNumber = number[i];
                bool isTopNumber = true;

                for (int j = i + 1; j < number.Length; j++)
                {
                    int rightNumber = number[j];
                    if (rightNumber >= currentNumber)
                    {
                        isTopNumber = false;
                        break;
                    }
                }

                if (isTopNumber)
                {
                    Console.Write($"{currentNumber} ");
                }
            }
        }
    }
}
