// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Book book = new Book("Harry Potter","f7ds8a",4);
Dvd theWayOfKings = new Dvd("The Way of Kings");
theWayOfKings.CheckOut();
theWayOfKings.Display();
book.Display();
book.ShowBookDetails();