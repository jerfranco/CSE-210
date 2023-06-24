void Display()
{
    Room room = new Room();
    User user = new User();
    
}
void CreateUser()
{
    user.GetUserInfo();
}
void Reservation()
{
    Console.WriteLine("Would you like to reserve a room?")
    string input = Console.ReadLine();
    if (input == "yes")
    {
        Console.WriteLine("What room do you want to reserve? ");
        int room = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("When will you be checking in the room? ");
        int checkIn = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("When will you be checking out the room? ");
        int checkOut = Convert.ToInt32(Console.ReadLine());
        Reservation reservation = new Reservation(user);
        reservation.Stringify(checkIn,checkOut);

    }
    else
    {
        Console.WriteLine("Okay...");
    }

}
Display();
CreateUser();
Reservation();
