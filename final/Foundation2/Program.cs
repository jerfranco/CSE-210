using System;

class Program
{
    static void Main(string[] args)
    {
        //float x = 0;
        List<float> total = new List<float>();
        Order order = new Order();
        Address address1 = new Address("4533 Horseshoe Circle","Antioch","CA","USA");
        Product product = new Product("Rice",1,5,5);
        Product product1 = new Product("Egg",2,4,2);
        Customer customer = new Customer("Jeremiah Franco");
        Product pro = new Product();
        order.productAmount(product);
        order.productAmount(product1);
        Console.WriteLine(product.Price());
        Console.WriteLine(product1.Price());
        order.priceList(product.Price());
        order.priceList(product1.Price());
        
        order.getCountry(address1.returnCountry());
        order.Tot();
        Console.WriteLine(order.packingLabel(customer.GetName(),product.getID()));
        Console.WriteLine(order.shippingLabel(customer.GetName(), address1));

        
        
        // product.Order();
        // product1.Order();
        // order.order.Add(product.Price());
        // order.order.Add(product1.Price());
        // Console.WriteLine(order.order.Sum());
        // order.order.Add(address.cCountry());
        // Console.WriteLine(order.order.Sum());


        
        // product.totalList();
        // product1.totalList();
        // product.totalPrice();
        // product.DisplayTotal();

    }
}