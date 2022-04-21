using System;
using System.Linq;

namespace _07.MxSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int countMax = 0;
            int bestNumber = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                int currentNumber = numbers[i];
                int count = 1;
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    int rightNumber = numbers[j];
                    if (currentNumber == rightNumber)
                    {
                        count++;
                    }

                    else
                    {
                        break;
                    }
                    if (count > countMax)
                    {
                        countMax = count;
                        bestNumber = currentNumber;
                    }
                }
            }

            for (int i = 0; i < countMax; i++)
            {
                Console.Write($"{bestNumber} ");
            }
        }
    }
}

