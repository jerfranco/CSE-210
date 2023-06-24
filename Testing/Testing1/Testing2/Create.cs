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
    public string GetGoal()
    {
        return _name;
    }
}