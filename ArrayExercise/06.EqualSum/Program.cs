using System;
using System.Linq;

namespace _06.EqualSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] number = Console.ReadLine()
                .Split()
                .Select(int.Parse)
            .ToArray();

            bool flag = false;
            for (int i = 0; i < number.Length; i++)
            {
                int leftSum = 0;

                for (int j = i - 1; j >= 0; j--)
                {
                    leftSum += number[j];
                }

                int rightSum = 0;
                for (int k = i + 1; k < number.Length; k++)
                {
                    rightSum += number[k];
                }

                if (leftSum == rightSum)
                {
                    Console.WriteLine(i);
                    flag = true;
                    break;
                }
            }
            if (!flag)
            {
                Console.WriteLine("no");
            }
        }
    }
}
