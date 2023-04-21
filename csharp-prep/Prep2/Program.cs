using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string input = Console.ReadLine();
        int grade = int.Parse(input);
        if (grade >= 90){
            Console.WriteLine("A");
        }
        else if (grade <= 89 && grade >= 80){
            Console.WriteLine("B");
        }
        else if (grade <=79 && grade >= 70){
            Console.WriteLine("C");
        }
        else if (grade <= 69 && grade >= 60){
            Console.WriteLine("D");
        }
        else{
            Console.WriteLine("F");
        }
        if (grade >= 70){
            Console.WriteLine("You passed the course!");
        }
        else{
            Console.WriteLine("I believe in you!!!!");
        }
    }
}