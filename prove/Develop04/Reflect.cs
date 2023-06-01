public class Reflect
{
    string question = "";
    string question2 = "";
    List<string> _prompt = new List<string>();
    List<string> _prompt1 = new List<string>();
    public Reflect()
    {
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
    public void GetRandomPrompt1()
    {
        Random randomGenerator = new Random();
        int num = randomGenerator.Next(0,_prompt.Count);
        question = _prompt[num];
        Console.WriteLine(question);
    }
    public void GetRandomPrompt2()
    {
       Random randomGenerator = new Random();
        int num = randomGenerator.Next(0,_prompt1.Count);
        question2 = _prompt1[num];
        Console.WriteLine(question2);
    } 
    public void Display()
    {
        Console.WriteLine("This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you ahve and how you can use it in other aspects of your life.");
        
    }
    
    
    }
    
    // public void RandomPrompt()
    // {
    //     Console.WriteLine(question);
    // }
    
