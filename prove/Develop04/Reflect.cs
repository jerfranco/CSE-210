public class Reflect : Activity
{
    List<string> _prompt = new List<string>();
    List<string> _prompt1 = new List<string>();
    public void GetRandomPrompt1()
    {
        string question;
        Random randomGenerator = new Random();
        int num = randomGenerator.Next(0,_prompt.Count);
        question = _prompt[num];
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine($"\n--- {question} ---");
        Console.WriteLine("\nWhen you have something in mind, press enter to continue.");
        Console.ReadLine();
    }
    public void GetRandomPrompt2()
    {
        string question2;
        Random r = new Random();
        int num1 = r.Next(0,_prompt1.Count);
        question2 = _prompt1[num1];
        Console.WriteLine($"> {question2}");
    }

    public Reflect(string type, string desc,  string end) : base(type, end, desc)
    {
        _desc = desc;
        _prompt.Add("Think of a time when you stood up for someone else.");
        _prompt.Add("Think of a time when you did something really difficult.");
        _prompt.Add("Think of a time when you helped someone in need.");
        _prompt.Add("Think of a time when you did something truly selfless.");

        _prompt1.Add("Why was this experience meaningful to you? ");
        _prompt1.Add("Have you ever done anything like this before?");
        _prompt1.Add("How did you get started? ");
        _prompt1.Add("How did you feel when it was complete? ");
        _prompt1.Add("What made this time different than other times when you were not as successful? ");
        _prompt1.Add("What is your favorite thing about this experience? ");
        _prompt1.Add("What could you learn about yoruself through this experience? ");
        _prompt1.Add("What did you learn about yoruself through this experience? ");
        _prompt1.Add("How can you keep this experience in mind in the future? ");
    }
    
    public void Ponder()
    {
        Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
        Console.Write("You may begin in: ");
        Countdown();
        Console.Clear();
    }
    public void Complete()
    {
        Console.WriteLine($"\nYou have completed {_input} seconds of the {_type} Activity");
    }
    }
    

