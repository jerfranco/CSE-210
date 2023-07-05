using System;

class Program
{
    static void Main(string[] args)
    {
        Bicycles bicycles = new Bicycles("Bicycle",20,5,50,5);
        Console.WriteLine(bicycles.Speed());
        Console.WriteLine(40 / 50);

        Console.WriteLine(bicycles.GetSummary());

        Console.WriteLine($"Distance: {bicycles.Distance()}");
    }
}