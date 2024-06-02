using System;

namespace TicketPriceCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your age: ");
            string input = Console.ReadLine();
            int age;

            // Validate the input to ensure it is a valid integer
            if (int.TryParse(input, out age))
            {
                double ticketPrice;

                // Correctly check for age ranges
                if (age >= 65 || age <= 12)
                {
                    ticketPrice = 7;
                }
                else
                {
                    ticketPrice = 10;
                }

                Console.WriteLine("Your ticket price is: GHC" + ticketPrice);
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid age.");
            }
        }
    }
}
