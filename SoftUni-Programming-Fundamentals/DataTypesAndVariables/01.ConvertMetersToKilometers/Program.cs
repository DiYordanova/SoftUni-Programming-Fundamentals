using System;

namespace _08.FundamentalsDataTypesAndVariables
{
    class Program
    {
        static void Main(string[] args)
        {
            int meters = int.Parse(Console.ReadLine());
            float kilometres = meters * 0.001f;
            Console.WriteLine($"{kilometres:f2}");
        }
    }
}

