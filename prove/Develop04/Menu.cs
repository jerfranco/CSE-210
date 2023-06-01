public class Menu
{

    public void Display()
    {
        string response = "";
        string[] options = {"1","2","3","4"};
        while(response != "4")
        {
            while(options.Contains(response) == false)
            {
                Console.WriteLine("Menu Options:");
                Console.WriteLine("1. Start breathing activity\n2. Start reflecting activity\n3. Start listing activity\n4. Quit");
                Console.WriteLine("Select a choice from the menu: ");
                response = Console.ReadLine() ?? String.Empty;
            }
            switch(response)
            {
                case "1":
                    break;
                case "2":
                    break;
            }
        }

    }

}