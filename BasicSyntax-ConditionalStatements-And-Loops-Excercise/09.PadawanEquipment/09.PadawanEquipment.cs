using System;

namespace _09.PadawanEquopmant
{
    class Program
    {
        static void Main(string[] args)
        {
            double budjet = double.Parse(Console.ReadLine());
            int student = int.Parse(Console.ReadLine());
            double lightSibers = double.Parse(Console.ReadLine());
            double robes = double.Parse(Console.ReadLine());
            double belts = double.Parse(Console.ReadLine());
            double price = lightSibers * Math.Ceiling(student + student * 0.1) + robes * student + belts * (student - student / 6);
            if (budjet >= price)
            {
                Console.WriteLine($"The money is enough - it would cost {price:f2}lv.");
            }

            else
            {
                Console.WriteLine($"John will need {price - budjet:f2}lv more.");
            }
        }
    }
}
