public class Listing : Activity
{
    string quest = "";
    List<string> question = new List<string>();
    List<string> answers = new List<string>();
    public Listing(string type, string desc, string end) : base(type, desc, end)
    {
        question.Add("Who are people that you appreciate? ");
        question.Add("What are you personal strengths of yours? ");
        question.Add("Who are people that you have helped this week? ");
        question.Add("When have you felt the Holy Ghos this month? ");
        question.Add("Who are some of your personal heroes? ");
    }
    

    public void RandomPrompt()
    {
        Random random = new Random();
        int num = random.Next(0,question.Count);
        quest = question[num];
        Console.WriteLine("List as many responses you can to the following prompt:");
        Console.WriteLine($"--- {quest} ---");
        Console.WriteLine("You may begin in: ");
    }


    public void Begin()
    {
        string amount;
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_input);
        while (DateTime.Now < endTime)
        {
            Console.WriteLine("> ");
            amount = Console.ReadLine();
            answers.Add(amount);
        }
        Console.WriteLine($"You listed {answers.Count} items!");
    }
}