using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace ProbaFundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            string result = "";

            for (int i = 0; i < input.Length; i++)
            {
                int length = input[i].Length;
                for (int j = 0; j < length; j++)
                {
                    result += input[i];
                }
            }

            Console.WriteLine(result);
        }
    }
}


