using System;

namespace _08.BeerKegs
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            string biggestKeg = "";
            double biggestVolume = double.MinValue;
            for (int i = 0; i < number; i++)
            {
                string nameKeg = Console.ReadLine();
                double radius = double.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());
                double volume = Math.PI * Math.Pow(radius, 2) * height;
                if (volume > biggestVolume)
                {
                    biggestVolume = volume;
                    biggestKeg = nameKeg;
                }
            }

            Console.WriteLine($"{biggestKeg}");
        }
    }
}
