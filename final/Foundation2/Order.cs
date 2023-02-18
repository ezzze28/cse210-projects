public class Order
{
    private List<Product> _products = new List<Product>();
    private string _packingLabel = "";
    private string _shippingLabel = "";

    private Customer _customer;

    public void SetProduct(Product product)
    {
        _products.Add(product);
    }

    public void SetCustomer(Customer customer)
    {
        _customer = customer;
    }


    public void ShowPackingLabel()
    {
        foreach(var product in _products)
        {
            Console.WriteLine($"{product.GetName()} - {product.GetId()}");
        }
    }

    public void GetShippingLabel()
    {
        Console.WriteLine(_customer.DisplayCustomer());
    }
    public int GetTotalPrice()
    {
        int total = 0;
        foreach(var product in _products)
        {
            total += product.CalculatePrice();
        }
        if(_customer.IsAddressInternational())
        {
            total += 35;
        }
        else
        {
            total += 5;
        }
        return total;

    }

}