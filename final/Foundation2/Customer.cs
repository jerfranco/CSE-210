public class Customer
{
    Address address = new Address("4533 Horseshoe Circle","Antioch","CA","USA");
    public string _name;

    public Customer(string name)
    {
        _name = name;
    }
    public string GetName()
    {
        return _name;
    }

    public void displayName()
    {
        Console.WriteLine($"Customer Name: {_name}");
    }
    

    
}