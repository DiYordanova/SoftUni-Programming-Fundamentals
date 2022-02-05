﻿using System;

namespace _14.MethodLab
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            PrintSign(n);
        }
        static void PrintSign(int n)
        {
            if (n > 0)
            {
                Console.WriteLine($"The number {n} is positive.");
            }

            else if (n < 0)
            {
                Console.WriteLine($"The number {n} is negative.");
            }

            else if (n == 0)
            {
                Console.WriteLine($"The number {n} is zero.");
            }
        }
    }
}
