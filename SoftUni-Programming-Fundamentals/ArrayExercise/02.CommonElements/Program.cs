using System;

namespace _02.CommonElements
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] firstArray = Console.ReadLine().Split(); 
            string[] secondArray = Console.ReadLine().Split();
            foreach (string secondElement in secondArray)
            {
                foreach (string firstElement in firstArray)
                {
                    if (firstElement == secondElement)
                    {
                        Console.Write(firstElement +" ");
                    }
                }
            }
        }
    }
}
