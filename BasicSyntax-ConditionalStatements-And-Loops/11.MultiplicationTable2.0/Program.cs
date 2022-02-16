using System;

namespace _10.MultiplicationTable2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            for (int i = 1; i <= 10; i++)
            {
                if (m > 10)
                {
                    Console.WriteLine($"{n} X {m} = {n * m}");
                    return;
                }
                else if (i >= m)
                {
                    Console.WriteLine($"{n} X {i} = {n * i}");
                }
            }
        }
    }
}

