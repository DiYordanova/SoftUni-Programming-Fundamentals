using System;

namespace _12.ArrayExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                int current = int.Parse(Console.ReadLine());
                arr[i] = current;
                sum += current;
            }

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine(sum);
        }
    }
}

