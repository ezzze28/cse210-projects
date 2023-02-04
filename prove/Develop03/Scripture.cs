using System;
public class Scripture
{
    private string _phase;
    public Scripture(){
        _phase = "Unknown";
    }

    public Scripture(string phaseToInput)
    {
        _phase = phaseToInput;
    }
    public string GetPhase(){
        return _phase;
    }
    public void SetPhase(string phaseToSet){
        _phase = phaseToSet; 
    }
    public string GetCompleteScripture()
    {
        string phaseToReturn = _phase;
        return phaseToReturn;

    }
}