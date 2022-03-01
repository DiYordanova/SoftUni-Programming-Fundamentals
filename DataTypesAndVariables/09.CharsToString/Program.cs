using System;

namespace _09.CharsToString
{
    class Program
    {
        static void Main(string[] args)
        {
            char numberOne = char.Parse(Console.ReadLine());
            char numberTwo = char.Parse(Console.ReadLine());
            char numberThree = char.Parse(Console.ReadLine());

            Console.WriteLine($"{numberOne}{numberTwo}{numberThree}");
        }
    }
}
