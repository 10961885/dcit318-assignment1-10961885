using System;

namespace GradeConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a numerical grade between 0 and 100: ");
            string input = Console.ReadLine();
            double grade;

            // Validate the input to ensure it is a valid double
            if (double.TryParse(input, out grade))
            {
                if (grade >= 0 && grade <= 100)
                {
                    if (grade >= 90)
                    {
                        Console.WriteLine("A");
                    }
                    else if (grade >= 70 && grade < 90)
                    {
                        Console.WriteLine("B");
                    }
                    else if (grade >= 60 && grade < 70)
                    {
                        Console.WriteLine("C");
                    }
                    else if (grade >= 50 && grade < 60)
                    {
                        Console.WriteLine("D");
                    }
                    else
                    {
                        Console.WriteLine("F");
                    }
                }
                else
                {
                    Console.WriteLine("Please enter a grade between 0 and 100.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a numerical grade.");
            }
        }
    }
}
