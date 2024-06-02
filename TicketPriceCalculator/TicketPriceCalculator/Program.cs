using System;

namespace TicketPriceCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your age: ");
            int age = int.Parse(Console.ReadLine());

            int ticketPrice = 10;

            if (age <= 12 || age >= 65)
            {
                ticketPrice = 7;
            }

            Console.WriteLine($"The ticket price is: GHC{ticketPrice}");
        }
    }
}
