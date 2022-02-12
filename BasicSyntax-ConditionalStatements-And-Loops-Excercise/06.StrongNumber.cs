using System;

namespace _06.StrongNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int sum = 0;
            int originNumber = number;
            while (number > 0)
            {
                int lastDigit =number % 10;
                int factoriel = 1;
                for (int i = 1; i <= lastDigit; i++)
                {
                    factoriel = factoriel * i;
                }

                sum += factoriel;
                number /= 10;
            }

            if (originNumber == sum)
            {
                Console.WriteLine("yes");
            }

            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
