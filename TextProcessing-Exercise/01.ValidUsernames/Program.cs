using System;
using System.Collections.Generic;

namespace _28TextProcessingExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
            List<string> userName = new List<string>();

            for (int i = 0; i < input.Length; i++)
            {
                string currentName = input[i];

                if (currentName.Length >= 3 && currentName.Length <= 16)
                {
                    bool isValid = true;

                    for (int j = 0; j < currentName.Length; j++)
                    {
                        if (!(char.IsLetterOrDigit(currentName[j]) || currentName[j] == '-' || currentName[j] == '_'))
                        {
                            isValid = false;
                        }
                    }

                    if (isValid)
                    {
                        userName.Add(currentName);
                    }
                }
            }

            Console.WriteLine(string.Join(Environment.NewLine, userName));
        }
    }
}


