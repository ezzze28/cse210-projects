public class Product
{
    private string _name = "";
    private string _id = "";
    private int _price;
    private int _quantity;

    public string GetName()
    {
        return _name;
    }
    public void SetName(string name)
    {
        _name = name;
    }
    public string GetId()
    {
        return _id;
    }
    public void SetId(string id)
    {
        _id = id;
    }
    public int GetPrice()
    {
        return _price;
    }
    public void SetPrice(int price)
    {
        _price = price;
    }
    public int GetQuantity()
    {
        return _quantity;
    }
    public void SetQuantity(int quantity)
    {
        _quantity = quantity;
    }
    public int CalculatePrice()
    {
        return _quantity * _price;
    }

}