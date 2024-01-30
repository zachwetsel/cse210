using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment = new Assignment("Zach","Addition");
        Console.WriteLine($"{assignment.GetSummary()}");

        MathAssignment mathAssignment = new MathAssignment("Zach","Addition","7.3","8-19");
        Console.WriteLine($"{mathAssignment.GetSummary()}");
        Console.WriteLine($"{mathAssignment.GetHomeworkList()}");

        WritingAssignment writingAssignment = new WritingAssignment("Zach Wetsel","European History","The Causes of World War II");
        Console.WriteLine($"{writingAssignment.GetSummary()}");
        Console.WriteLine($"{writingAssignment.GetWritingInformation()}");

    }
}