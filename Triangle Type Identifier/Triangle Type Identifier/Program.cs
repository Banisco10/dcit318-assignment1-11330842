using System;

namespace Triangle_Type_Identifier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("DCIT 318 ASSIGNMENT");
            TriangleTypeIdentifier();
        }

        static void TriangleTypeIdentifier()
        {
            double side1 = GetSide("Enter Side 1: ");
            double side2 = GetSide("Enter Side 2: ");
            double side3 = GetSide("Enter Side 3: ");

            // Check if it's a valid triangle
            if (side1 + side2 <= side3 || side1 + side3 <= side2 || side2 + side3 <= side1)
            {
                Console.WriteLine("These sides do not form a valid triangle.");
                Console.WriteLine("The sum of the lengths of any two sides must be greater than the length of the third side.");
                return;
            }

            if (side1 == side2 && side2 == side3)
                Console.WriteLine("This is an Equilateral Triangle.");
            else if (side1 == side2 || side1 == side3 || side2 == side3)
                Console.WriteLine("This is an Isosceles Triangle.");
            else
                Console.WriteLine("This is a Scalene Triangle.");
        }

        static double GetSide(string prompt)
        {
            double side;
            while (true)
            {
                Console.Write(prompt);
                if (!double.TryParse(Console.ReadLine(), out side))
                {
                    Console.WriteLine("Invalid input! Please enter a valid number.");
                    continue;
                }

                if (side <= 0)
                {
                    Console.WriteLine("Side length must be greater than zero.");
                    continue;
                }

                return side;
            }
        }
    }
}
