using System;

namespace _07.ConcatName
{
    class Program
    {
        static void Main(string[] args)
        {
            string nameFirst = Console.ReadLine();
            string nameSecond = Console.ReadLine();
            string symbol = Console.ReadLine();
            Console.WriteLine($"{nameFirst}{symbol}{nameSecond}");
        }
    }
}
