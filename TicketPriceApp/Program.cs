using System;

namespace TicketPriceApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the DCIT 318 Ticket Price Calculator!");
            Console.WriteLine("You can enter your age to see the ticket price.");
            Console.WriteLine("Type 'exit' to quit the application.");
            Console.WriteLine();

            while (true)
            {
                Console.Write("Enter your age or type 'exit' to quit: ");
                string input = Console.ReadLine();

                if (input.ToLower() == "exit")
                {
                    break;
                }

                int age;
                if (int.TryParse(input, out age) && age >= 0)
                {
                    int ticketPrice;
                    if (age <= 12 || age >= 65)
                    {
                        ticketPrice = 7;
                    }
                    else
                    {
                        ticketPrice = 10;
                    }

                    Console.WriteLine("Your ticket price is GHC" + ticketPrice + ".");
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid age or type 'exit' to quit.");
                }
                Console.WriteLine();
            }

            Console.WriteLine("Thank you for using the DCIT 318 Ticket Price Calculator. Goodbye!");
        }
    }
}
