using System;
public class CheckListGoal : Goal // SimpleGoal child class of Goal
{
    private int _currentlyCounter;
    private int _verificationCounter;
    private int _bonusGoalCompleted;
    private bool _checked = false;

    public CheckListGoal(string goalName, string goalDescription, int pointsArchieved) : base(goalName, goalDescription, pointsArchieved)
    {
        _title = goalName;
        _description = goalDescription;
        _pointsToComplete = pointsArchieved;
    }

    public CheckListGoal(string goalName, string goalDescription, int pointsArchieved, int verificationCounter, int currentCounter = 0) : base(goalName, goalDescription, pointsArchieved)
    {
        _title = goalName;
        _description = goalDescription;
        _pointsToComplete = pointsArchieved;
        _verificationCounter = verificationCounter;
        _currentlyCounter = currentCounter;
    }

    public CheckListGoal(string goalName, string goalDescription, int pointsArchieved, int verificationCounter, int bonusGoalCompleted, int currentCounter = 0, bool Goalchecked = false) : base(goalName, goalDescription, pointsArchieved)
    {
        _title = goalName;
        _description = goalDescription;
        _pointsToComplete = pointsArchieved;
        _verificationCounter = verificationCounter;
        _bonusGoalCompleted = bonusGoalCompleted;
        _currentlyCounter = currentCounter;
        _checked = Goalchecked;
    }
    public int GetVerificationCounter()
    {
        return _verificationCounter;
    }
    public void SetVerificationCounter(int verificationCounterToSet)
    {
        _verificationCounter = verificationCounterToSet;
    }
    public int GetBonusGoalCompleted()
    {
        return _bonusGoalCompleted;
    }
    public void SetBonusGoalCompleted(int bonusGoalCompletedToSet)
    {
        _bonusGoalCompleted = bonusGoalCompletedToSet;

    }
    public int GetCurrentlyCounter()
    {
        return _currentlyCounter;
    }
    public void SetCurrentlyCounter(int currenlyCounterToSet)
    {
        _currentlyCounter = currenlyCounterToSet;

    } 
    public override string GetGoalInformation()
    {
        if (_checked)
        {
            return $"[X] {_title} ({_description}) -- Currently completed {GetCurrentlyCounter()}/{_verificationCounter}";
        }
        else
        {
            return $"[ ] {_title} ({_description}) -- Currently completed {GetCurrentlyCounter()}/{_verificationCounter}";
        }
    }
    public override int GetGoalCompleted(int userPoints)
    {
        _currentlyCounter = _currentlyCounter + 1;
        int currentCounter = _currentlyCounter;
        SetCurrentlyCounter(currentCounter);

        string goalInformation = GetGoalInformation();

        int index = _listOfGoals.IndexOf(goalInformation);
        string newGoalInformation;

        if (_currentlyCounter == _verificationCounter)
        {
            _checked = true;
            newGoalInformation = GetGoalInformation();
            userPoints = userPoints + _bonusGoalCompleted;
            userPoints = userPoints + _pointsToComplete;
        }
        else if (_currentlyCounter > _verificationCounter)
        {
            _currentlyCounter = _currentlyCounter - 1;
        }
        else
        {
            newGoalInformation = goalInformation;
            userPoints = userPoints + _pointsToComplete;
        }

        return userPoints;

    }
    public override string GetStringRepresentation()
    {
        return "CheckListGoal:" + _title + "," + _description + "," + _pointsToComplete + "," + _verificationCounter + "," + _bonusGoalCompleted + "," + _currentlyCounter;
    }
}