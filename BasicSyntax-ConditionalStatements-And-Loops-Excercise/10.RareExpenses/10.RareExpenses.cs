using System;

namespace _10.RareExpenses
{
    class Program
    {
        static void Main(string[] args)
        {
            int lostGames = int.Parse(Console.ReadLine());
            double headset = double.Parse(Console.ReadLine());
            double mice = double.Parse(Console.ReadLine());
            double keyboard = double.Parse(Console.ReadLine());
            double display = double.Parse(Console.ReadLine());
            int trashheadsets = 0;
            int trashhmice = 0;
            int trashkeyboard = 0;
            int trashdisplay = 0;
            for (int i = 1; i <= lostGames; i++)
            {
                if (i % 2 == 0)
                {
                    trashheadsets++;
                }

                if (i % 3 == 0)
                {
                    trashhmice++;
                }

                if (i % 6 == 0)
                {
                    trashkeyboard++;
                }

                if (i % 12 == 0)
                {
                    trashdisplay++;
                }
            }

            double price = headset * trashheadsets + mice * trashhmice + keyboard * trashkeyboard + display * trashdisplay;
            Console.WriteLine($"Rage expenses: {price:f2} lv.");
        }
    }
}
