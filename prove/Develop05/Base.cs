public class Base
{
    string _name;
    string _desc;
    string _points;
    int points;
    public void Questions()
    {
        
        Console.WriteLine("What is the name of your goal? ");
        _name = Console.ReadLine();
        Console.WriteLine("What is a short description of it? ");
        _desc = Console.ReadLine();
        Console.WriteLine("What is the amount of point associated with this goal? ");
        _points = Console.ReadLine();
        points = Convert.ToInt32(_points); 
    }
    public string CleanDisplay(string goal)
    {
        return $"{goal}: {_name}, {_}"
    }
}