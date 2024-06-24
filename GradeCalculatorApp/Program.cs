using System;

namespace GradeCalculatorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the DCIT 318 Grade Calculator!");
            Console.WriteLine("You can enter your grade (0-100) to see the letter grade.");
            Console.WriteLine("Type 'exit' to quit the application.");
            Console.WriteLine();

            while (true)
            {
                Console.Write("Enter your grade (0-100) or type 'exit' to quit: ");
                string input = Console.ReadLine();

                if (input.ToLower() == "exit")
                {
                    break;
                }

                int grade;
                if (int.TryParse(input, out grade) && grade >= 0 && grade <= 100)
                {
                    if (grade >= 90)
                    {
                        Console.WriteLine("Your grade is A.");
                    }
                    else if (grade >= 80)
                    {
                        Console.WriteLine("Your grade is B.");
                    }
                    else if (grade >= 70)
                    {
                        Console.WriteLine("Your grade is C.");
                    }
                    else if (grade >= 60)
                    {
                        Console.WriteLine("Your grade is D.");
                    }
                    else
                    {
                        Console.WriteLine("Your grade is F.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid grade or type 'exit' to quit.");
                }
                Console.WriteLine();
            }

            Console.WriteLine("Thank you for using the DCIT 318 Grade Calculator. Goodbye!");
        }
    }
}
