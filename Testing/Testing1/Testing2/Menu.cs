public class Menu
{
    Goals goals = new Goals();
    public void DisplayMenu()
    {   
        string response = "";
        string[] options = {"1","2","3","4","5","6"};
        while(response != "6")
        {
            while(options.Contains(response) == false)
            {
                Console.WriteLine("Menu Options:");
                Console.WriteLine("1. Create New Goal\n2. List Goals\n3. Save Goals\n4. Load Goals\n5. Record Event\n6. Quit");
                Console.WriteLine("Select a choice from the menu: ");
                response = Console.ReadLine() ?? String.Empty;
            }
            switch(response)
            {
                case "1":
                goals.Menu();
                break;
                case "2":
                break;
                case "3":
                    
                break;
                case "4":
                break;
                case "5":
                break;
                case "6":
                    Environment.Exit(0);
                break;
            }
            response = "";
        }
    }
}