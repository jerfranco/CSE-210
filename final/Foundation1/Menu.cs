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
                Console.WriteLine("Welcome to YouTube");
                Console.WriteLine("Please select a YouTube video!");
                Console.WriteLine("1. Programming with Classes\n2. How to cook rice\n3. One piece\n4. Quit");
                response = Console.ReadLine();
            }
            switch(response)
            {
                case "1":
                Video video1 = new Video("Programming with Classes","Brother Hayes",90);
                Comment comment1 = new Comment("John Doe","Programming with Classes has helped me become a better programmer in an object oriented programming state.");
                Comment comment2 = new Comment("Bob Johns","I've always wanted to learn how to program and after watching this video, it helps me have a better understanding of why we program. Thanks!");
                Comment comment3 = new Comment("Jeremy Lin","I don't program myself, but I found this video very interesting.");
                video1.commentInput(comment1);
                video1.commentInput(comment2);
                video1.commentInput(comment3);
                video1.Display();                
                video1.CleanDisplay();
                Console.WriteLine(video1.commentAmount());
                Console.WriteLine();
                video1.displayComments();
                video1.CleanDisplay();
                break;
                case "2":
                Video video2 = new Video("How to cook rice","Uncle Roger",180);
                Comment comment1a = new Comment("Billy Joel","I can now cook rice. THANKS!");
                Comment comment2a = new Comment("James Franco","I love rice!");
                Comment comment3a = new Comment("Jackie Chan","I already know to cook rice");
                video2.commentInput(comment1a);
                video2.commentInput(comment2a);
                video2.commentInput(comment3a);
                video2.Display();                
                video2.CleanDisplay();
                Console.WriteLine(video2.commentAmount());
                Console.WriteLine();
                video2.displayComments();
                video2.CleanDisplay();
                break;
                case "3":
                Video video3 = new Video("One Piece","Oda",300);
                Comment comment1b = new Comment("Monkey D. Luffy","Gumu gumu go!");
                Comment comment2b = new Comment("Zoro","I want to be the greatest swordsman");
                Comment comment3b = new Comment("Ussop","I'm a genius!");
                video3.commentInput(comment1b);
                video3.commentInput(comment2b);
                video3.commentInput(comment3b);
                video3.Display();                
                video3.CleanDisplay();
                Console.WriteLine(video3.commentAmount());
                Console.WriteLine();
                video3.displayComments();
                video3.CleanDisplay();
                break;
                case "4":
                Environment.Exit(0);
                break;
            }
            response = "";
        }
    }
}