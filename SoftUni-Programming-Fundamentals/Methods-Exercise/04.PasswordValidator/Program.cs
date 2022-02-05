using System;

namespace _04.PasswordValidator
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();
            bool isValid = true;

            if (HasValidLength(password))
            {
                Console.WriteLine($"Password must be between 6 and 10 characters");
                isValid = false;
            }

            if (ContainsValidCharacter(password))
            {
                Console.WriteLine($"Password must consist only of letters and digits");
                isValid = false;
            }

            if (!ContainsDigit(password, 2))
            {
                Console.WriteLine($"Password must have at least 2 digits");
                isValid = false;
            }

            if (isValid)
            {
                Console.WriteLine($"Password is valid");
            }

        }

        private static bool ContainsDigit(string password, int count)
        {
            int counter = 0;
            foreach (var symbol in password)
            {
                if (char.IsDigit(symbol))
                {
                    counter++;
                }

                if (counter == 2)
                {
                    return true;
                }
            }

            return false;
        }

        private static bool ContainsValidCharacter(string password)
        {
            foreach (var symbol in password)
            {
                if (!char.IsLetterOrDigit(symbol))
                {
                    return true;
                }
            }

            return false;
        }

        private static bool HasValidLength(string password)
        {
            return password.Length <= 6 || password.Length >= 10;
        }
    }
}
