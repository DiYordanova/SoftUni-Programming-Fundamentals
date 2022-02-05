using System;

namespace _15.MethodExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            int min = GetSmallestNumber(num1, num2, num3);

            Console.WriteLine(min);
        }

        private static int GetSmallestNumber(int num1, int num2, int num3)
        {
            int min = Math.Min(Math.Min(num1, num2), num3);
            return min;
        }
    }
}

