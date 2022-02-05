using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.ChangeList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split().Select(int.Parse).ToList();

            while (true)
            {
                string line = Console.ReadLine();
                if (line == "end")
                {
                    break; 
                }

                string[] parts = line.Split();
                if (parts[0] == "Delete")
                {
                    int current = int.Parse(parts[1]);
                    input.RemoveAll(i => i == current);
                }

                else if (parts[0] == "Insert")
                {
                    int current = int.Parse(parts[1]);
                    int position = int.Parse(parts[2]);
                    input.Insert(position, current);
                }
            }
                Console.WriteLine(string.Join(" ", input));
        }
    }
}
