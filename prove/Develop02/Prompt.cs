
public class Prompt
{
        private string _prompt = "";
        public string quest = "";
        List<string> questions = new List<string>();
        public Prompt()
        {
            questions.Add("Who was the most interesting person I interacted with today? ");
            questions.Add("What was the best part of my day? ");
            questions.Add("How did I see the hand of the Lord in my life today? ");
            questions.Add("What was the strongest emotion I felt today? ");
            questions.Add("If I had one thing I could do over today, what would it be?");
            questions.Add("What is the hardest thing that you did today? ");
            questions.Add("What was the easiest thing that you did? ");
            questions.Add("What are some things that you are grateful for? ");
            questions.Add("What was the highlight of your day? ");
            questions.Add("How are you feeling? ");
            questions.Add("Anything funny that happened today? ");
        }
        public string GetRandomPrompt()
        {
            Random randomGenerator = new Random();
            int num = randomGenerator.Next(0,questions.Count);
            quest = questions[num];
            return quest;
        }
}
