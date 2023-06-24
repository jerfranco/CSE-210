public class Create
{
    public void Menu()
    {
        Menu menu = new Menu();
        //string input;
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
                Simple simple = new Simple("Simple");
                simple.goalType();
                simple.Questions();
                simple.Response();
                break;
                case "2":
                Simple simp = new Simple("Simple");
                simp.Display();
                break;
                case "3":
                break;
                case "4":
                menu.Display();
                break;
            }
            response = "";
        }
    }
}