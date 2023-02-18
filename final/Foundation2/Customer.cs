public class Customer
{
    private string _name = "";
    private Address _address;
    public string GetName()
    {
        return _name;
    }
    public void SetAddress(Address address)
    {
        _address = address;
    }
    public void SetName(string name)
    {
        _name = name;
    }
    public string DisplayCustomer()
    {
        return $"{_name}, \n{_address.Display()}";
    }
    public bool IsAddressInternational()
    {
        return _address.GetInternational();                
    }
}