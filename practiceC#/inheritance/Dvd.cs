public class Dvd : Loanable
{

    private string _title;

    public Dvd(string title)
    {
        _title = title;
    }

    //override means that even though Display is in the parent class it will still display info
    public override void Display()
    {
        base.Display();
        Console.WriteLine($"Title: {_title}");
    }

}