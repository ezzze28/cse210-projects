public class OutdoorGathering : Event
{
    private string _weather = "";
    private string _type = "";


    public OutdoorGathering (string weather, string type, string title, string description, string date, string time, string address): base(title, description, date, time, address)
    {
        _weather = weather;
        _type = type;
    }
    public string GetFullDetails()
    {
        return $"\nWeather Forecast: {_weather}\nType: {_type} {GetStandardDetails()}";
    }
    public string GetShortDescription()
    {
        return $"\nType: {_type}\nTitle: {GetTitle()}\nDate: {GetDate()}";
    }

}