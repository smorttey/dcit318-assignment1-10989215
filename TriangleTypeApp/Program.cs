using System;

namespace TriangleTypeApp
{
    class Program
    {
        static Random random = new Random();

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the DCIT 318 Triangle Type Identifier!");
            Console.WriteLine("You can enter the lengths of the three sides of a triangle to determine its type.");
            Console.WriteLine("Type 'exit' to quit the application.");
            Console.WriteLine();

            while (true)
            {
                Console.Write("Enter the length of side 1 or type 'exit' to quit: ");
                string input1 = Console.ReadLine() ?? string.Empty;
                if (input1.ToLower() == "exit") break;

                Console.Write("Enter the length of side 2 or type 'exit' to quit: ");
                string input2 = Console.ReadLine() ?? string.Empty;
                if (input2.ToLower() == "exit") break;

                Console.Write("Enter the length of side 3 or type 'exit' to quit: ");
                string input3 = Console.ReadLine() ?? string.Empty;
                if (input3.ToLower() == "exit") break;

                if (double.TryParse(input1, out double side1) && double.TryParse(input2, out double side2) && double.TryParse(input3, out double side3) &&
                    side1 > 0 && side2 > 0 && side3 > 0)
                {
                    if (side1 == side2 && side2 == side3)
                    {
                        Console.WriteLine("The triangle is Equilateral.");
                        DisplayFunFact("Equilateral");
                    }
                    else if (side1 == side2 || side1 == side3 || side2 == side3)
                    {
                        Console.WriteLine("The triangle is Isosceles.");
                        DisplayFunFact("Isosceles");
                    }
                    else
                    {
                        Console.WriteLine("The triangle is Scalene.");
                        DisplayFunFact("Scalene");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter valid lengths for all three sides or type 'exit' to quit.");
                }
                Console.WriteLine();
            }

            Console.WriteLine("Thank you for using the DCIT 318 Triangle Type Identifier. Goodbye!");
        }

        static void DisplayFunFact(string triangleType)
        {
            string[] equilateralFacts = new string[]
            {
                "An equilateral triangle has all three sides equal and all three angles equal to 60 degrees.",
                "Equilateral triangles are also equiangular triangles, meaning they have three equal angles.",
                "Equilateral triangles can be seen in Ghanaian Kente patterns, symbolizing balance and harmony.",
                "In Akan culture, triangles often represent the cycle of life and the unity of mind, body, and soul."
            };

            string[] isoscelesFacts = new string[]
            {
                "An isosceles triangle has two sides that are equal in length.",
                "In an isosceles triangle, the angles opposite the equal sides are also equal.",
                "The term 'isosceles' comes from the Greek word 'isos' meaning 'equal' and 'skelos' meaning 'leg'.",
                "Isosceles triangles can be found in the design of traditional Ghanaian stools, representing stability.",
            };

            string[] scaleneFacts = new string[]
            {
                "A scalene triangle has all sides of different lengths.",
                "In a scalene triangle, all the angles are also different.",
                "Scalene triangles have no line of symmetry.",
                "Scalene triangles are often used in modern Ghanaian architecture for their unique and dynamic shapes.",
            };

            string fact = "";

            switch (triangleType)
            {
                case "Equilateral":
                    fact = equilateralFacts[random.Next(equilateralFacts.Length)];
                    break;
                case "Isosceles":
                    fact = isoscelesFacts[random.Next(isoscelesFacts.Length)];
                    break;
                case "Scalene":
                    fact = scaleneFacts[random.Next(scaleneFacts.Length)];
                    break;
            }

            Console.WriteLine("Fun Fact: " + fact);
        }
    }
}
