using System;

namespace _12.EvenNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            bool isEven = false;
            while (!isEven)
            {
                if (n % 2 != 0)
                {
                    Console.WriteLine($"Please write an even number.");
                }

                else if (n % 2 == 0)
                {
                    Console.WriteLine($"The number is: {Math.Abs(n)}");
                    isEven = true;
                    break;
                }
                n = int.Parse(Console.ReadLine());
            }
        }
    }
}
