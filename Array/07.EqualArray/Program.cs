using System;
using System.Linq;

namespace _07.EqualArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrFirst = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] arrSecond = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int sum = 0;
            bool isIdentical = true;
            for (int i = 0; i < arrFirst.Length; i++)
            {
                if (arrFirst[i] != arrSecond[i])
                {
                    Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
                    isIdentical = false;
                    break;
                }

                else
                {
                    int current = arrFirst[i];
                    sum += current;
                }
            }

            if (isIdentical)
            {
                Console.WriteLine($"Arrays are identical. Sum: {sum}");
            }
        }
    }
}

