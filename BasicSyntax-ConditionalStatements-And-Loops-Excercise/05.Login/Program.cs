using System;

namespace _05.Login
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string password = "";
            int count = 0;
            for (int i = username.Length - 1; i >= 0; i--)
            {
                password += username[i];
            }

            bool isValue = false;
            while (!isValue)
            {
                string inputPassword = Console.ReadLine();
                if (inputPassword == password)
                {
                    Console.WriteLine($"User {username} logged in.");
                    isValue = true;
                    break;
                }

                else

                    if (inputPassword != password && count == 3)
                {
                    Console.WriteLine($"User {username} blocked!");
                    break;
                }
                {
                    if (inputPassword != password)
                    {
                        Console.WriteLine("Incorrect password. Try again.");
                        count++;
                    }
                }
            }
        }
    }
}

