using System;

namespace _07.WaterOverflow
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                int litre = int.Parse(Console.ReadLine());
                if (sum + litre > 255)
                {
                    Console.WriteLine($"Insufficient capacity!");                    
                }

                else
                {
                sum += litre;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
