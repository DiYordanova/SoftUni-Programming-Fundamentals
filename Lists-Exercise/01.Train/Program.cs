using System;
using System.Collections.Generic;
using System.Linq;

namespace _18._ListExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> train = Console.ReadLine().Split().Select(int.Parse).ToList();
            int maxCapacity = int.Parse(Console.ReadLine());
            while (true)
            {
                string line = Console.ReadLine();
                if (line == "end")
                {
                    break;
                }

                string[] parts = line.Split();
                if (parts.Length == 2)
                {
                    int pasenger = int.Parse(parts[1]);
                    train.Add(pasenger);
                }

                else
                {
                    int pasenger = int.Parse(parts[0]);

                    for (int i = 0; i < train.Count; i++)
                    {
                        if (train[i] + pasenger <= maxCapacity)
                        {
                            train[i] = train[i] + pasenger;
                            break;
                        }
                    }
                }
            }

            Console.WriteLine(string.Join(" ", train));
        }
    }
}

