using System;

class Program
{
    static void Main(string[] args)
    {
        Bicycles bicycles = new Bicycles("Bicycles","July 19, 2023",5,4,20);
        Console.WriteLine(bicycles.Speed());
        Console.WriteLine(bicycles.Pace());
        Console.WriteLine(bicycles.GetSummary());

    }
}