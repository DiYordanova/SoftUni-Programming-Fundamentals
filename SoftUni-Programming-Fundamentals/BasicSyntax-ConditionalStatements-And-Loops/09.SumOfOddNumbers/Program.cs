using System;

namespace _09.SumOfOddNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int sum = 0;
            double counter = 0;
            for (int i = 1; i <= 100; i++)
            {
                if (i % 2 != 0)
                {
                    sum += i;
                    Console.WriteLine($"{i}");
                    counter++;
                    if (counter >= number)
                    {
                        Console.WriteLine($"Sum: {sum}");
                        return;
                    }
                }
            }
        }
    }
}
