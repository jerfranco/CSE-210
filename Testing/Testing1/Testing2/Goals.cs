public class Goals
{
    List<Create> goals = new List<Create>();
    string _name = "";
    string _desc = "";
    int _points = 0;
    public void Menu()
    {    
        string response = "";
        string[] options = {"1","2","3","4"};
        while(response != "4")
        {
            while(options.Contains(response) == false)
            {
                Console.WriteLine("The types of goals are:");
                Console.WriteLine("1. Simple Goal\n2. Eternal Goal\n3. Checklist Goal\n4. Quit");
                Console.WriteLine("What type of goal would you like to create? ");
                response = Console.ReadLine() ?? String.Empty;
            }
            switch(response)
            {
                case "1":
                Questions();
                AddGoals();
                break;
                case "2":
                break;
                case "3":
                break;
                case "4":
                break;
            }
            response = "";
        }
    }
    public void Questions()
    {
        Console.WriteLine("What is the name of your goal? ");
        string name = Console.ReadLine() ?? String.Empty;
        _name = name;
        Console.WriteLine("What is a short descirption of it? ");
        string desc = Console.ReadLine() ?? String.Empty;
        _desc = desc;
        Console.WriteLine("What is the amount of points associated with this goal? ");
        int points = Convert.ToInt32(Console.ReadLine());
        _points = points;
    }
    public void AddGoals()
    {
        goals.Add(new Create(_name, _desc, _points));
    }

    public void DisplayGoals()
    {
        foreach (Create goal in goals)
        {
            Console.WriteLine($"{goal._name} {goal._desc}");
        }
    }
}