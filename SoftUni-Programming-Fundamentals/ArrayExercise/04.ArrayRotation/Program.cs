using System;

namespace _04.ArrayRotation
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array = Console.ReadLine().Split();
            int n = int.Parse(Console.ReadLine());

            n = n % array.Length;
            for (int i = 0; i < n; i++)
            {
                string firstElement = array[0];
                for (int j = 1; j < array.Length; j++)
                {
                    array[j - 1] = array[j];
                }

                array[array.Length - 1] = firstElement;
            }

            foreach (var element in array)
            {
                Console.Write($"{element} ");
            }
        }
    }
}






