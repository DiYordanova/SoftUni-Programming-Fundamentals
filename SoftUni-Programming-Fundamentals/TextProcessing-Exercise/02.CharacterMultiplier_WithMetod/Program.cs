using System;

namespace _02WithMetod
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine(CharMultiplier(input[0], input[1]));
        }

        static int CharMultiplier(string first, string second)
        {
            int sum = 0;
            int min = Math.Min(first.Length, second.Length);

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

            return sum;
        }
    }
}

