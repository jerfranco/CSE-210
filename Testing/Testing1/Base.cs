public class Base
{
    string _type;
    string name;
    string desc;
    int points;
    string response;
    public Base(string type)
    {
        _type = type;
    }
    public string goalType()
    {
        return $"{_type} goal";
        
    }
    
    public void Questions()
    {

        List<string> input = new List<string>();
        Console.WriteLine("What is the name of the goal? ");
        name = Console.ReadLine();
        Console.WriteLine("What is a short description of it? ");
        desc = Console.ReadLine();
        Console.WriteLine("What is the amount of points associated with this goal? ");
        points = Convert.ToInt32(Console.ReadLine());
        response = $"{name}, {desc}, {points}";
        input.Add(response);
    }
    public void Response()
    {
        
    }

    public void Display()
    {
        Console.WriteLine(response);
    }
}