public class Create
{  
    public string _name;
    public string _desc;
    public int _points;
    public Create(string name, string desc, int points)
    {
        _name = name;
        _desc = desc;
        _points = points;
    }
    public void Questions()
    {
        Console.WriteLine("What is the name of your goal? ");
        _name = Console.ReadLine() ?? String.Empty;
        Console.WriteLine("What is a short description of it? ");
        _desc = Console.ReadLine() ?? String.Empty;
        Console.WriteLine("What is the amound of points associated with this goal? ");
        _points = Convert.ToInt32(Console.ReadLine());
    }

}