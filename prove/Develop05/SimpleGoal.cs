using System;

public class SimpleGoal : Goal // SimpleGoal child class of Goal
{
    private bool _checked = false;
    private bool _completed = false;
    public SimpleGoal(string goalName, string goalDescription, int pointsArchieved, bool checkedGoal = false) : base(goalName, goalDescription, pointsArchieved)
    {

        _title = goalName;
        _description = goalDescription;
        _pointsToComplete = pointsArchieved;
        _checked = checkedGoal;
    }

    public override string GetGoalInformation()
    {
        {
            if (_checked){
                _completed = true;
                return "[X] " + _title + " (" + _description + ")";}
            else{
                return "[ ] " + _title + " (" + _description + ")";}
        }
    }

    public override int GetGoalCompleted(int userPoints)
    {
        bool completed = _completed;

        _checked = true;
        if (completed == false)
        {
            GetGoalInformation();
            userPoints = userPoints + _pointsToComplete;
            completed = true;
            return userPoints;
        }
        else
        {
            GetGoalInformation();
            return userPoints;
        }
        
    }
    public override string GetStringRepresentation()
    {
        return "SimpleGoal:" + _title + "," + _description + "," + _pointsToComplete + "," + _checked;
    }
}