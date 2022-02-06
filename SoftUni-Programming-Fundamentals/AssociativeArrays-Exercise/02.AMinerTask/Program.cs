using System;
using System.Collections.Generic;

namespace _02
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> resources = new Dictionary<string, int>();

            while (true)
            {
                string resource = Console.ReadLine();
                if (resource == "stop")
                {
                    break;
                }

                int quantity = int.Parse(Console.ReadLine());

                if (!resources.ContainsKey(resource))
                {
                    resources.Add(resource, quantity);
                }

                else
                {
                    resources[resource] += quantity;
                }
            }

            foreach (var pair in resources)
            {
                Console.WriteLine(pair.Key + " -> " + pair.Value);
            }
        }
    }
}

