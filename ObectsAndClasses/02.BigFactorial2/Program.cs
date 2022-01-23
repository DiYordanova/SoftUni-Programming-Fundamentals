using System;
using System.Numerics;

namespace _02.BigFactorial2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(Factorial.Calculate(n));
        }
    }

    public class Factorial
    {
        public static BigInteger Calculate(int n)
        {
            BigInteger factorial = 1;            

            for (int i = 1; i <= n; i++)
            {
                factorial = factorial * i;
            }
            return factorial;
        }
    }
}
