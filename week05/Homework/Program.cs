using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();

        Assignment student = new Assignment("Cory", "Algebra");
        string summary = student.GetSummary();
        Console.WriteLine(summary);
        Console.WriteLine();

        MathAssignment student2 = new MathAssignment("James", "Geometry", "7.4", "1-10 all odd");
        summary = student2.GetSummary();
        Console.WriteLine(summary);
        string homework = student2.GetHomeworkList();
        Console.WriteLine(homework);
        Console.WriteLine();

        WritingAssignment student3 = new WritingAssignment("Hannah", "English", "A Clockwork Orange");
        summary = student3.GetSummary();
        Console.WriteLine(summary);
        homework = student3.GetWritingInformation();
        Console.WriteLine(homework);
        Console.WriteLine();

    }
}