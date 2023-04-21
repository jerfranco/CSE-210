using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string grade = Console.ReadLine();

        if (grade >= 90){
            Console.WriteLine("A");
        }
        else if (grade <= 89 && grade >= 80){
            Console.WriteLine("B");
        }
            
    }
}