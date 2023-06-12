public class Rectangle : Shape
{
    private double _width;
    private double _length;
    public Rectangle(double length, double width, string color) : base(color)
    {
        _length = length;
        _width = width;

    }
    public override double GetArea()
    {
        return _length * _width;
    }
}