using System;
using System.Collections.Generic;

namespace _05
{
    class Program
    {
        static void Main(string[] args)
        {
            int numCommands = int.Parse(Console.ReadLine());
            Dictionary<string, string> onlineRegister = new Dictionary<string, string>();

            for (int i = 0; i < numCommands; i++)
            {
                string input = Console.ReadLine();
                string[] parts = input.Split();
                string command = parts[0];

                if (command == "register")
                {
                    string userName = parts[1];
                    string licensePlateNumber = parts[2];

                    if (onlineRegister.ContainsKey(userName))
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {licensePlateNumber}");
                        continue;
                    }

                    else
                    {
                        onlineRegister.Add(userName, licensePlateNumber);
                        Console.WriteLine($"{userName} registered {licensePlateNumber} successfully");
                    }
                }

                else if (command == "unregister")
                {
                    string userName = parts[1];

                    //if (onlineRegister.ContainsKey(userName))
                    //{
                    //    onlineRegister.Remove(userName);
                    //    Console.WriteLine($"{userName} unregistered successfully");
                    //}

                    //else
                    //{
                    //    Console.WriteLine($"ERROR: user { userName} not found");
                    //}

                    bool removed = onlineRegister.Remove(userName);

                    if (removed)
                    {
                        Console.WriteLine($"{userName} unregistered successfully");
                    }

                    else
                    {
                        Console.WriteLine($"ERROR: user { userName} not found");
                    }
                }
            }

            foreach (var pair in onlineRegister)
            {
                Console.WriteLine($"{pair.Key} => {pair.Value}");
            }
        }
    }
}

