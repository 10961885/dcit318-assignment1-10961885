using System;

namespace TriangleType
{
    class Program
    {
        static void Main(string[] args)
        {
            double side1, side2, side3;

            Console.Write("Enter side 1: ");
            while (!double.TryParse(Console.ReadLine(), out side1) || side1 <= 0)
            {
                Console.WriteLine("Invalid input. Please enter a positive number.");
                Console.Write("Enter side 1: ");
            }

            Console.Write("Enter side 2: ");
            while (!double.TryParse(Console.ReadLine(), out side2) || side2 <= 0)
            {
                Console.WriteLine("Invalid input. Please enter a positive number.");
                Console.Write("Enter side 2: ");
            }

            Console.Write("Enter side 3: ");
            while (!double.TryParse(Console.ReadLine(), out side3) || side3 <= 0)
            {
                Console.WriteLine("Invalid input. Please enter a positive number.");
                Console.Write("Enter side 3: ");
            }

            if (IsValidTriangle(side1, side2, side3))
            {
                if (side1 == side2 && side2 == side3)
                {
                    Console.WriteLine("Equilateral Triangle");
                }
                else if (side1 == side2 || side2 == side3 || side1 == side3)
                {
                    Console.WriteLine("Isosceles Triangle");
                }
                else
                {
                    Console.WriteLine("Scalene Triangle");
                }
            }
            else
            {
                Console.WriteLine("The entered sides do not form a valid triangle.");
            }
        }

        static bool IsValidTriangle(double side1, double side2, double side3)
        {
            // Check the triangle inequality theorem
            return (side1 + side2 > side3) && (side1 + side3 > side2) && (side2 + side3 > side1);
        }
    }
}
