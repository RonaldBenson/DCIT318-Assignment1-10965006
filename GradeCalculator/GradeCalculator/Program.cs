using System;

namespace GradeCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the numerical grade:");

            // Read the grade input from the user as a string
            string input = Console.ReadLine();

            // Declare a variable to store the letter grade
            char letterGrade;

            // Parse the input string to a floating-point number
            if (float.TryParse(input, out float grade))
            {
                // Determine the letter grade based on the grade
                if (grade >= 80)
                {
                    letterGrade = 'A';
                }
                else if (grade >= 70)
                {
                    letterGrade = 'B';
                }
                else if (grade >= 60)
                {
                    letterGrade = 'C';
                }
                else if (grade >= 50)
                {
                    letterGrade = 'D';
                }
                else
                {
                    letterGrade = 'F';
                }

                // Output the letter grade
                Console.WriteLine($"The letter grade is: {letterGrade}");
            }
            else
            {
                // Handle invalid input
                Console.WriteLine("Invalid input. Please enter a valid numerical grade.");
            }
        }
    }
}
