using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter your grade percentage: ");
        int grade = int.Parse(Console.ReadLine());
        string letterGrade = "";
        string sign = "";

        // Determine the letter grade
        if (grade >= 90)
        {
            letterGrade = "A";
        }
        else if (grade >= 80)
        {
            letterGrade = "B";
        }
        else if (grade >= 70)
        {
            letterGrade = "C";
        }
        else if (grade >= 60)
        {
            letterGrade = "D";
        }
        else
        {
            letterGrade = "F";
        }

        // Determine the sign for grades A, B, C, D
        if (letterGrade != "F" && letterGrade != "A")
        {
            if (grade % 10 >= 7)
            {
                sign = "+";
            }
            else if (grade % 10 < 3)
            {
                sign = "-";
            }
        }

        // Handle special cases for A and F
        if (letterGrade == "A" && grade < 93)
        {
            sign = "-";
        }

        // Output the letter grade and sign
        Console.WriteLine($"Your letter grade is {letterGrade}{sign}.");

        // Check if the user passed the course
        if (grade >= 70)
        {
            Console.WriteLine("Congratulations! You passed the course.");
        }
        else
        {
            Console.WriteLine("Unfortunately, you did not pass. Better luck next time.");
        }
    }
}