using System;

namespace _09.FundamentalDataTypeExcersise
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondtNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());
            int fourthNumber = int.Parse(Console.ReadLine());
            long rezult = (firstNumber + 0L + secondtNumber) / thirdNumber * fourthNumber;
            Console.WriteLine($"{rezult}");
        }
    }
}

