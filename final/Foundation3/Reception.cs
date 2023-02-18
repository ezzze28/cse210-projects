public class Reception : Event
{
    private string _rsvp = "";
    private string _type = "";


    public Reception (string rsvp, string type, string title, string description, string date, string time, string address): base(title, description, date, time, address)
    {
        _rsvp = rsvp;
        _type = type;
    }
    public string GetFullDetails()
    {
        return $"\nRSVP: {_rsvp}\nType: {_type} {GetStandardDetails()}";
    }
    public string GetShortDescription()
    {
        return $"\nType: {_type}\nTitle: {GetTitle()}\nDate: {GetDate()}";
    }

}