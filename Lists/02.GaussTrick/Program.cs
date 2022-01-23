using System;
using System.Collections.Generic;
using System.Linq;

namespace _17.ListFundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> newList = new List<int>();
            for (int i = 0; i < list.Count / 2; i++)
            {

                newList.Add(list[i] + list[list.Count - i - 1]);
            }

            if (list.Count % 2 == 1)
            {
                newList.Add(list[list.Count / 2]);
            }
            Console.WriteLine(String.Join(" ", newList));
        }
    }
}

