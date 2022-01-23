using System;

namespace _03.Calculation
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            int numFirst = int.Parse(Console.ReadLine());
            int numSecond = int.Parse(Console.ReadLine());
            Add(command, numFirst, numSecond);
            Multiply(command, numFirst, numSecond);
            Subtract(command, numFirst, numSecond);
            Divide(command, numFirst, numSecond);
        }

        static void Add(string add, int num1, int num2)
        {
            int rezult = 0;
            if (add == "add")
            {
                rezult = num1 + num2;
                Console.WriteLine($"{rezult}");
            }
        }

        static void Multiply(string multiply, int num1, int num2)
        {
            int rezult = 0;
            if (multiply == "multiply")
            {
                rezult = num1 * num2;
                Console.WriteLine($"{rezult}");
            }
        }

        static void Subtract(string subtract, int num1, int num2)
        {
            int rezult = 0;
            if (subtract == "subtract")
            {
                rezult = num1 - num2;
                Console.WriteLine($"{rezult}");
            }
        }

        static void Divide(string divide, int num1, int num2)
        {
            int rezult = 0;
            if (divide == "divide")
            {
                rezult = num1 / num2;
                Console.WriteLine($"{rezult}");
            }
        }
    }
}
