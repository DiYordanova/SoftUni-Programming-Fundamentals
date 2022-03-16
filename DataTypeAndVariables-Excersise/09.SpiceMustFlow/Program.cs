using System;

namespace _09.SpiceMustFlow
{
    class Program
    {
        static void Main(string[] args)
        {
            int yield = int.Parse(Console.ReadLine());
            int day = 0;
            long totalSpice = 0;
            if (yield < 100)
            {
                Console.WriteLine(0);
                Console.WriteLine(0);
                return;
            }

            while (yield >= 100)
            {
                day++;
                totalSpice += yield - 26;
                yield = yield - 10;
            }

            totalSpice = totalSpice - 26;
            Console.WriteLine(day);
            Console.WriteLine(totalSpice);
        }
    }
}
