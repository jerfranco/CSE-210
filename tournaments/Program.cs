// // See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// neymar._name = "Neymar Jr";
// naymar._position = "Forward";
// neymar._jerseyNumber = 10;


Player neymar = new Player("Neymar jr.", 10);
neymar.SetPosition("Forward");
Player kobe = new Player("Kobe Bryant", 24, "Forward");
Team awesomeSauce = new Team("Awesome Sauce");
awesomeSauce.AddPlayer(neymar);
awesomeSauce.AddPlayer(kobe);
Console.WriteLine(neymar.Display());

awesomeSauce.AddLoss();
awesomeSauce.AddWin();

awesomeSauce.DisplayRoster();

