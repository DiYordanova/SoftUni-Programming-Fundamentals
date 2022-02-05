using System;
using System.Collections.Generic;

namespace _03.HouseParty
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberCommand = int.Parse(Console.ReadLine());
            List<string> party = new List<string>();

            for (int i = 0; i < numberCommand; i++)
            {
                string[] parts = Console.ReadLine()
                    .Split();
                string name = parts[0];
                if (parts.Length == 3)
                {
                    if (party.Contains(parts[0]))
                    {
                        Console.WriteLine($"{name} is already in the list!");
                    }

                    else
                    {
                        party.Add(name);
                    }
                }

                if (parts.Length == 4)
                {
                    if (party.Contains(parts[0]))
                    {
                        party.Remove(name);
                    }

                    else
                    {
                        Console.WriteLine($"{ name} is not in the list!");
                    }
                }
            }

            foreach (var item in party)
            {
                Console.WriteLine(item);
            }
        }
    }
}
