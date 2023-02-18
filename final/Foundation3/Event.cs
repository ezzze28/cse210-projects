public class Event
{
    private string _title = "";
    private string _description = "";
    private string _time = "";
    private string _date = "";
    private string _address = "";

    public string GetTitle()
    {
        return _title;
    }
    public void SetTitle(string title)
    {
        _title = title;
    }
    public string GetDescription()
    {
        return _description;
    }
    public void SeDescription(string description)
    {
        _description = description;
    }
    public string GetTime()
    {
        return _time;
    }
    public void SetTime(string time)
    {
        _time = time;
    }
    public string GetAddress()
    {
        return _address;
    }
    public void SetAddress(string address)
    {
        _address = address;
    }
    public string GetDate()
    {
        return _date;
    }
    public Event(string title, string description, string date, string time, string address)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }
    public Event()
    {

    }
    public string GetStandardDetails()
    {
        return $"\nTitle: {_title}\nDescription: {_description}\nDate: {_date}\nTime: {_time}\nAddress: {_address}";
    }
    
}