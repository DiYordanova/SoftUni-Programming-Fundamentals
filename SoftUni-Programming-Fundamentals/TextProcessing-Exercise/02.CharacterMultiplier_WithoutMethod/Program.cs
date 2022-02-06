using System;

namespace _02
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string first = input[0];
            string second = input[1];
            int minLenghtFirst = input[0].Length;
            int minLenghtSecond = input[1].Length;
            int min = Math.Min(minLenghtFirst, minLenghtSecond);
            int sum = 0;

            for (int i = 0; i < min; i++)
            {
                sum += first[i] * second[i];
            }

            if (first.Length < second.Length)
            {
                for (int i = min; i < second.Length; i++)
                {
                    sum += second[i];
                }
            }

            else if (second.Length < first.Length)
            {
                for (int i = min; i < first.Length; i++)
                {
                    sum += first[i];
                }
            }

            Console.WriteLine(sum);
        }
    }
}
