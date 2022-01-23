using System;

namespace _03.Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            int countPeople = int.Parse(Console.ReadLine());  
            string typeOfGroup = Console.ReadLine();  
            string day = Console.ReadLine();
            double price = 0;
            switch (typeOfGroup)
            {
                case "Students":
                    if (day == "Friday")
                    {
                        price = 8.45;
                    }

                    else if (day == "Saturday")
                    {
                        price = 9.8;
                    }

                    else if (day == "Sunday")
                    {
                        price = 10.46;
                    }

                    if (countPeople >= 30)
                    {
                        price = price - price * 0.15;
                    }
                    break;
                case "Business":
                    if (day == "Friday")
                    {
                        price = 10.9;
                    }

                    else if (day == "Saturday")
                    {
                        price = 15.6;
                    }

                    else if (day == "Sunday")
                    {
                        price = 16;
                    }

                    if (countPeople >= 100)
                    {
                        countPeople -= 10;
                    }
                    break;
                case "Regular":
                    if (day == "Friday")
                    {
                        price = 15;
                    }

                    else if (day == "Saturday")
                    {
                        price = 20;
                    }

                    else if (day == "Sunday")
                    {
                        price = 22.50;
                    }

                    if (countPeople >= 10 && countPeople <= 20)
                    {
                        price = price - price * 0.05;
                    }
                    break;                 
            }
            double totalPrice = price * countPeople;
            Console.WriteLine($"Total price: {totalPrice:f2}");
        }
    }
}
