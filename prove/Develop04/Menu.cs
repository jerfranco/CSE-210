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
                Console.Clear();
                Console.WriteLine("Menu Options:");
                Console.WriteLine("1. Start breathing activity\n2. Start reflecting activity\n3. Start listing activity\n4. Quit");
                Console.WriteLine("Select a choice from the menu: ");
                response = Console.ReadLine() ?? String.Empty;
            }
            switch(response)
            {
                case "1":
                    Breathing b = new Breathing("Breathing","This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.","Well Done!!!");
                    Console.Clear();
                    Console.WriteLine(b.WelcomeDisplay());
                    Console.WriteLine(b.Description());
                    b.Question();
                    b.GetReady();
                    b.Animation();
                    b.Exercise();
                    Console.WriteLine(b.endMessage());
                    b.Animation();
                    break;
                case "2":
                    Reflect r = new Reflect("Reflect","This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you ahve and how you can use it in other aspects of your life.\n","Well Done !!!");
                    Console.Clear();
                    Console.WriteLine(r.WelcomeDisplay());
                    Console.WriteLine(r.Description());
                    r.Question();
                    r.GetReady();
                    r.Animation();
                    r.GetRandomPrompt1();
                    r.Ponder();
                    r.GetRandomPrompt2();
                    r.Animation();
                    r.GetRandomPrompt2();
                    r.Animation();
                    Console.WriteLine();
                    Console.WriteLine(r.endMessage());
                    r.Animation();
                    Console.WriteLine();
                    r.Complete();
                    r.Animation();
                    break;
                case "3":
                    Listing l = new Listing("Listing","This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.","Well Done!!!");
                    Console.Clear();
                    Console.WriteLine(l.WelcomeDisplay());
                    Console.WriteLine(l.Description());
                    l.Question();
                    l.GetReady();
                    l.Animation();
                    l.RandomPrompt();
                    l.Countdown();
                    l.Begin();
                    Console.WriteLine(l.endMessage());
                    l.Animation();               
                    break;
                case "4":
                    Environment.Exit(0);
                    break;
            }
            response = "";
        }

    }

}