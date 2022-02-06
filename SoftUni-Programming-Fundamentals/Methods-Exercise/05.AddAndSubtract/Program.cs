using System;

namespace _05.AddAndSubtract
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());
            int sum = GetSum(first, second);
            int diff = GetSubtract(sum, third);
            Console.WriteLine(diff);
        }

        private static int GetSubtract(int sum, int third)
        {
            return sum - third;
        }

        private static int GetSum(int first, int second)
        {
            return first + second;
        }
    }
}
