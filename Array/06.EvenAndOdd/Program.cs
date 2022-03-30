using System;
using System.Linq;

namespace _06.EvenAndOdd
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] number = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int sumEven = 0;
            for (int i = 0; i < number.Length; i++)
            {
                if (number[i] % 2 == 0)
                {
                    int currentSumEven = number[i];
                    sumEven += currentSumEven;
                }
            }

            int sumOdd = 0;
            for (int i = 0; i < number.Length; i++)
            {
                if (number[i] % 2 != 0)
                {
                    int currentSumOdd = number[i];
                    sumOdd += currentSumOdd;
                }
            }

            int rezult = sumEven - sumOdd;
            Console.WriteLine(rezult);
        }
    }
}
