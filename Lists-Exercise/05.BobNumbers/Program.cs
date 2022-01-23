using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.BobNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            int[] bobmData = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int bombNumber = bobmData[0];
            int bombPower = bobmData[1];
            while (true)
            {
                int idx = numbers.IndexOf(bombNumber);

                if (idx == -1)
                {
                    break;
                }

                int startIndex = idx - bombPower;

                if (startIndex < 0)
                {
                    startIndex = 0;
                }

                int count = bombPower * 2 + 1;

                if (count > numbers.Count - startIndex)
                {
                    count = numbers.Count - startIndex;
                }

                numbers.RemoveRange(startIndex, count);
            }
            int sum = 0;

            foreach (var number in numbers)
            {
                sum += number;
            }

            Console.WriteLine(sum);           
        }
    }
}
