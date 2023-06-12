public class Elevator
{
    int x = 1;
    protected List<int> floors = new List<int>();
    private bool _open = false;
    private bool _close = true;

    public List<int> createFloor()
    {
        while(x <= 30)
        {
            foreach (int floor in floors)
            {
                floors.Add(x);
                x = x + 1;
            }
        }
        return floors;
    }
    public string Open()
    {
        return "Doors are opening...";
    }

    public string Close()
    {
        return "Doors are closing...";
    }

    public string moveFloor(int floorNum)
    {
        if(floorNum <= 30)
        {
            return $"Moving to floor {floorNum}";
        }
        else
        {
            return $"{floorNum} does not exist. Must be between 1-30";
        }
    }


    public void requestElevator()
    {

    }

    public void ListFloors()
    {
        foreach (int floor in floors)
        {
            Console.WriteLine(floor);
        }
    }
    
    public void Display()
    {
        foreach (var floor in floors)
        {
            Console.WriteLine(floor);
        }
    }

}