using System;

public class EternalGoal : Goal
{

    public EternalGoal(string goalName, string goalDescription, int pointsArchieved) : base(goalName, goalDescription, pointsArchieved)
    {
        _title = goalName;
        _description = goalDescription;
        _pointsToComplete = pointsArchieved;
    }
    public override string GetGoalInformation()
    {
        return $"[ ] {_title} ({_description})";
    }

    public override int GetGoalCompleted(int userPoints)
    {
        GetGoalInformation();
        userPoints = userPoints + _pointsToComplete;
        return userPoints;
    }
    public override string GetStringRepresentation()
    {
        return "EternalGoal:" + _title + "," + _description + "," + _pointsToComplete;
    }
}