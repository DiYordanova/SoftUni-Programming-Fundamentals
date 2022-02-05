using System;
using System.Collections.Generic;

namespace _21.ObectAndClasses_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] phrases = { "Excellent product.", "Such a great product.", "I always use that product.", "Best product of its category.", "Exceptional product.", "I can’t live without this product." };
            string[] events = { "Now I feel good.", "I have succeeded with this product.", "Makes miracles. I am happy of the results!", "I cannot believe but now I feel awesome.", "Try it yourself, I am very satisfied.", "I feel great!" };
            string[] authors = { "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva" };
            string[] cities = { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };

            for (int i = 0; i < n; i++)
            {
                Random rnd = new Random();
                int positionPhrases = rnd.Next(0, phrases.Length);
                int positionEvents = rnd.Next(0, events.Length);
                int positionAuthors = rnd.Next(0, authors.Length);
                int positionCities = rnd.Next(0, cities.Length);
                string result = $"{ phrases[positionPhrases] } {events[positionEvents]} {authors[positionAuthors]} – {cities[positionCities]}";
                Console.WriteLine(result);
            }
        }
    }
}

