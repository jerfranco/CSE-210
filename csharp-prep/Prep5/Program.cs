using System;

class Program
{
    static void Main(string[] args)
    {
        welcome();
        string username = userNameInput();
        int number = numberInput();
        int sanswer = squared(number);
        response(username, sanswer);

    }
    static void welcome() 
    {
        Console.WriteLine("Welcome to the program!");
    }
    static string userNameInput() 
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        return name;
    }
    static int numberInput() 
    {
        Console.Write("Please enter your favorite number: ");
        int favNumber = int.Parse(Console.ReadLine());
        return favNumber;
    }
    static int squared(int favNumber) 
    {
        int answer = favNumber * favNumber;
        return answer;
    }
    static void response(string name, int answer)
    {
        Console.WriteLine($"{name}, the square of your number is {answer}");
    }
}