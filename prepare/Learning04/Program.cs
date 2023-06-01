using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment = new Assignment("Samuel Bennett","Multiplication");
        MathAssignment ma = new MathAssignment("Roberto Rodriguez","Fractions","Section 7.3","Problems 8 -19");
        WritingAssignment wa = new WritingAssignment("Mary Waters","European History","The Causes of World War II by Mary Waters");
        Console.WriteLine(assignment.GetSummary());
        Console.WriteLine(ma.GetHomeworkList());
        Console.WriteLine(wa.GetSummary());
        Console.WriteLine(wa.GetWritingInformation());

    }
}