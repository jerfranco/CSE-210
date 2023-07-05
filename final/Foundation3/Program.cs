using System;

class Program
{
    static void Main(string[] args)
    {
        Outdoor outdoor = new Outdoor("Sunny","Outdoor","Football","Playing flag football","July 19, 2023","9am");
        Address address = new Address("4900 Marie P DeBartolo Way","Santa Clara","CA","USA");
        outdoor.shortDesc();
        outdoor.standardDesc();
        address.Display();
        Console.WriteLine();
        outdoor.outDesc();
        outdoor.standardDesc();
        Console.WriteLine();
        Console.WriteLine("-------------------------------------------------------------------------");

        Lectures lectures = new Lectures("Kevin Hart",150,"Lecture","Ted Talk","Kevin Hart will talk about the basis of comedy","July 19, 2023","5pm");
        lectures.shortDesc();
        lectures.standardDesc();
        Console.WriteLine();
        lectures.lecDesc();
        lectures.standardDesc();
        Console.WriteLine();
        Console.WriteLine("-------------------------------------------------------------------------");

        Reception reception = new Reception("jeremiahfranco3@gmail.com","Reception","Wedding","Friend is getting married in the temple","July 19, 2023","8pm");
        reception.shortDesc();
        reception.standardDesc();
        Console.WriteLine();
        reception.recDesc();
        reception.standardDesc();
        Console.WriteLine();
        Console.WriteLine("-------------------------------------------------------------------------");
    }
}