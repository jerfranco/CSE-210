public class Jobs
{
    //instances
    public string _company = "";
    public string _jobTitle = "";
    public int _StartYear;
    public int _EndYear;

    //constructor
    public Jobs()
    {

    }

    //methods
    public void DisplayResults()
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_StartYear}-{_EndYear}");
    }
}