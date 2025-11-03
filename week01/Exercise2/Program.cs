using System;

class Program
{
    static void Main(string[] args)
    {
        string letterGrade;
        int grade;


        Console.Write("What is your grade? ");
        string userInput = Console.ReadLine();
        grade = int.Parse(userInput);

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

        Console.WriteLine($"Your letter grade is {letterGrade}.");
        if (grade >= 70)
        {
            Console.WriteLine("You passed!");
        }
        else
        {
            Console.WriteLine("You did not pass!");
        }

    }
}