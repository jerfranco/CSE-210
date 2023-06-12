public abstract class Shape
{
    private string _color;

    // string color;
    public string GetColor()
    {
        return _color;
    }
    public void SetColor(string color)
    {
        _color = color;
    }

    public Shape(string color)
    {
        _color = color;
    }

    public abstract double GetArea();
}