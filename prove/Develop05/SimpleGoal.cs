using System;

public class Simple : Goal 
{
    public Simple() 
        : base() 
    {
        
    }
    public Simple(string name, string description, double points, int timesFinished):
    base(name, description, points, timesFinished)
    {

    }

    //The following four methods are modified from the parent Goal class
    public override bool IsComplete()
    {
        if(this._timesCompleted >= 1)
        {
            return true;
        }
        else 
        {
            return false;
        }
    }
    public override double RecordEvent()
    {
        base.RecordEvent();
        return AwardPoints(this._points);
    }
    public override string SerializeSelf()
    {
        this._formattedString = "simple";
        return base.SerializeSelf();
    }
    public override void ListGoal() 
    {
        base.ListGoal();
        Console.Write($" --- Simple Goal\n");
    }

}
