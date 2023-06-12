using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();
        Square s = new Square(4,"red");
        shapes.Add(s);

        Rectangle r = new Rectangle(5,4,"Blue");
        shapes.Add(r);

        Circle c = new Circle(4,"Orange");
        shapes.Add(c);
        
        foreach (Shape shape in shapes)
        {
            Console.WriteLine(shape.GetArea());
            Console.WriteLine(shape.GetColor());
        }

    }
}