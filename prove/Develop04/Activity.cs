using System;

public class Activity{

    protected string _activityName;
    protected int _activityDuration;
    protected string _activityDescription;
    protected string _finalActivityMessage;

    public Activity()
    {
        _activityName = "Unknown";
        _activityDescription = "Unknown";
        _finalActivityMessage = "Unknown";
    }
    public Activity(string activityName)
    {
        _activityName = activityName;
        _activityDescription = "Unknown";
        _finalActivityMessage = "Unknown";
    }

    public Activity(string activityName, string activityDescription)
    {
        _activityName = activityName;
        _activityDescription = activityDescription;
        _finalActivityMessage = "Unknown";
    }    
    
    public Activity(string activityName, string activityDescription, string activityFinalMessage)
    {
        _activityName = activityName;
        _activityDescription = activityDescription;
        _finalActivityMessage = activityFinalMessage;
    }    
    
    public string GetActivityName(){
        return _activityName;
    }

    public void SetActivityName(string activityName)
    {
        _activityName = activityName;
    }
     
    public int GetActivityDuration()
    {
        return _activityDuration;
    }

    public void SetActivityDuration(int activityDuration)
    {
        _activityDuration = activityDuration;
    }
    public string GetActivityDescription(){
        return _activityDescription;
    }

    public void SetActivityDescription(string activityDescription)
    {
        _activityDescription = activityDescription;
    }
     
    public string GetFinalActivityMessage()
    {
        return _finalActivityMessage;
    }

    public void SetFinalActivityMessage(string finalActivityMessage)
    {
        _finalActivityMessage = finalActivityMessage;
    }
    public string GetActivityNameDisplay(){
        return $"Welcome to the {_activityName}.";
    }
    public string GetActivityDescriptionDisplay(){
        return $"{_activityDescription}";
    }
    public string GetActivityDurationDisplay(){
        Console.Write("How long, in seconds, would you like for your session? ");
        string result = Console.ReadLine();
        return result;
    }

    public string GetFinalActivityMessageDisplay(){
        Console.WriteLine("Well done.");
        Console.WriteLine();
        Convert.ToString(_activityDuration);
        return $"You have completed another {_activityDuration} seconds of the {_activityName}.";
    }

}