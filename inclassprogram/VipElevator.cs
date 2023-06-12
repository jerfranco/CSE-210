public class VIP : Elevator
{
    public void AddVIPFloor()
    {
        floors.Add(31);
    }

    public void ListAllFloors()
    {
        foreach (var floor in floors)
        {
            Console.WriteLine(floor);
        }
    }
}