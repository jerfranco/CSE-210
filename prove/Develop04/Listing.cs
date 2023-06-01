public class Listing
{
    string quest = "";
    List<string> question = new List<string>();
    public Listing()
    {
        question.Add("Who are people that you appreciate? ");
        question.Add("What are you personal strengths of yours? ");
        question.Add("Who are people that you have helped this week? ");
        question.Add("When have you felt the Holy Ghos this month? ");
        question.Add("Whoa re some of your personal heroes? ");
    }

    public void RandomPrompt()
    {
        Random random = new Random();
        int num = random.Next(0,question.Count);
        quest = question[num];
        Console.WriteLine(quest);
    }
    
    
    public void Display()
    {
        Console.WriteLine("This activity will help you relfect on the good things in your life by having you list as many things as you can in a certain area.");
    }
}