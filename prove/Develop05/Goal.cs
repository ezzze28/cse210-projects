using System;
public abstract class Goal
{
    protected string _title;
    protected string _description;
    protected int _pointsToComplete;

    protected List<string> _listOfGoals = new List<string>();

    public Goal()
    {
        _title = "";
        _description = "";
        _pointsToComplete = 0;
    }

    public Goal(string goalName)
    {
        _title = goalName;
        _description = "";
        _pointsToComplete = 0;
    }

    public Goal(string goalName, string goalDescription)
    {
        _title = goalName;
        _description = goalDescription;
        _pointsToComplete = 0;
    }

    public Goal(string goalName, string goalDescription, int pointsArchieved)
    {
        _title = goalName;
        _description = goalDescription;
        _pointsToComplete = pointsArchieved;
    }
    public string GetGoalName()
    {
        return _title;
    }

    public void SetGoalName(string goalName)
    {
        _title = goalName;
    }

    public string GetGoalDescription()
    {
        return _description;
    }

    public void SetGoalDescription(string goalDescription)
    {
        _description = goalDescription;
    }

    public int GetGoalPoints()
    {
        return _pointsToComplete;
    }

    public void SetGoalPoints(int goalPointsToComplete)
    {
        _pointsToComplete = goalPointsToComplete;
    }
    public virtual string GetGoalInformation(){
        return $"[] {_title} ({_description})";
    }

    public virtual int GetGoalCompleted(int userPoints){
        return userPoints;
    }    
    public virtual string GetStringRepresentation()
    {
        return "Goal:" + _title + "," + _description + "," + _pointsToComplete + "," + false;
    }

}