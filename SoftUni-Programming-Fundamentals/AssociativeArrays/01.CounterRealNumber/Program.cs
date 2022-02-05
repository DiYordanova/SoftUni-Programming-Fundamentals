using System;
using System.Collections.Generic;
using System.Linq;

namespace _24.AssociateArrayFundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = Console.ReadLine().Split().Select(double.Parse).ToArray();

            var sortedDictinory = new SortedDictionary<double, int>();

            foreach (var number in numbers)
            {
                if (sortedDictinory.ContainsKey(number))
                {
                    sortedDictinory[number]++;
                }

                else
                {
                    sortedDictinory.Add(number, 1);
                }
            }

            foreach (var pair in sortedDictinory)
            {
                Console.WriteLine(pair.Key + " -> " + pair.Value);
            }
        }
    }
}
