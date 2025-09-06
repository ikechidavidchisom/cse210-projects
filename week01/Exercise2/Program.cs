using System;

class Program
{
    static void Main(string[] args)
    {
        // Ask the user for their grade percentage
        Console.Write("Enter your grade percentage: ");
        string input = Console.ReadLine();
        int grade = int.Parse(input);

        string letter = "";
        
        // Determine the letter grade
        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80)
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

           // Final grade output
        Console.WriteLine($"Your grade is: {letter}");

        // Pass/fail message
        if (grade >= 70)
        {
            Console.WriteLine("Congratulations! You passed the course.");
        }
        else
        {
            Console.WriteLine("Don't worry, keep trying and you'll get it next time!");
        }
    }
}