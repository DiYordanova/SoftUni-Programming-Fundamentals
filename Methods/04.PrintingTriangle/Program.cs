using System;

namespace _04.PrintingTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Triangle(n);
        }

        static void Triangle(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                PrintNumberFrom1(i);
            }

            for (int j = n - 1; j > 0; j--)
            {
                PrintNumberFrom1(j);
            }
        }

        static void PrintNumberFrom1(int to)
        {
            for (int i = 1; i <= to; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }
}
