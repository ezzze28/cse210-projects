public class Lecture : Event
{
    private string _speaker = "";
    private int _capacity;
    private string _type = "";


    public Lecture (string speaker, int capacity, string type, string title, string description, string date, string time, string address): base(title, description, date, time, address)
    {
        _speaker = speaker;
        _capacity = capacity;
        _type = type;
    }
    public string GetFullDetails()
    {
        return $"\nSpeaker: {_speaker}\nCapacity: {_capacity}\nType: {_type} {GetStandardDetails()}";
    }
    public string GetShortDescription()
    {
        return $"\nType: {_type}\nTitle: {GetTitle()}\nDate: {GetDate()}";
    }

}