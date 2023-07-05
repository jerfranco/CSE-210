    public class Product
{

    public string _name;
    public int _id;
    private int _price;
    private int _quantity;
    public float _total;


    public Product(string name, int id, int price, int quantity)
    {
        _name = name;
        _id = id;
        _price = price;
        _quantity = quantity;
    }
    
    public int getID()
    {
        return _id;
    }
    public Product(){}

    public float Price()
    {
        _total = _price * _quantity;
        return _total;
    }

    public void Order()
    {
        //total.Add(_total);
    }


    public void Display()
    {
        Console.WriteLine($"Name: {_name}, quantity: {_quantity}");
    }

}