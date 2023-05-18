public class Team
{
    private List<Player> _players = new List<Player>();
    private string _name;
    private int _wins;
    private int _losses;


    public Team(string name)
    {
        _name = name;
    }

    public void AddPlayer(Player p)
    {
        _players.Add(p);
    }

    public void DisplayRoster()
    {
        Console.WriteLine($"{_name} {_wins}/{_losses}");
        foreach (Player player in _players)
        {
            Console.WriteLine(player.Display());
        }
    }
    public void AddWin()
    {
        _wins += 1;   
    }
    public void AddLoss()
    {
        _losses += 1;
    }
}