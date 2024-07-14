using System;

//This is my Parent class goal for the child goals. 
public abstract class Goal 
{
    private string _name;
    private string _description;
    protected double _points;
    protected double _timesCompleted;
    protected string _formattedString;

    public Goal()
    {
        //I am using the "this" keyword here as well as in other parts of my code.
        // this keyword refers to the current instance of the class and is also 
        // used as a modifier of the first parameter of an extension method.
        this._name = SetName();
        this._description = SetDescription();
        this._points = SetPoints();
        this._timesCompleted = 0;
    }
    public Goal(string name, string description, double points, int timesFinished)
    {
        this._name = name;
        this._description = description;
        this._points = points;
        this._timesCompleted = timesFinished;
    }

    // this method gets the name of the goal from the user and sets it. 
    protected string SetName()
    {
        Console.Write("What is the name of your goal? ");
        return Console.ReadLine();
    }
    // this method gets the description of the goal from the user and sets it.
    protected string SetDescription()
    {
        Console.Write("What is a short description of it? ");
        return Console.ReadLine();
    }
    // this method gets the points associated with the goal from the user and sets it.
    protected int SetPoints()
    {
        Console.Write("What is the amount of points associated with this goal? ");
        return int.Parse(Console.ReadLine());
    }

     
    public string GetName()
    {
        return this._name;
    }
    public string GetDescription()
    {
        return this._description;
    }
    public double GetPoints()
    {
        return this._points;
    }
    public double GetTimesFinished()
    {
        return this._timesCompleted;
    }
    //This next method can be overridden in the child classes
    public virtual int GetReachBonus()
    {
        return 0;
    }
    //This next method can be overridden in the child classes
    public virtual int GetBonusPoints()
    {
        return 0;
    }

    public double AwardPoints(double points)
    {
        Console.WriteLine($"Congratulations! You have earned {this._points} points!\n");
        return points;
    }

    //This next method can be overridden in the child classes
    public virtual double RecordEvent()
    {
        this._timesCompleted += 1;
        return 0;
    }

    //This method will only be implemented in the child classes
    public abstract bool IsComplete();

    //This next method can be overridden in the child classes
    public virtual void ListGoal()
    {
        if(IsComplete()){
            Console.Write($" [X] {this._name} ({this._description})");
        }
        if(!IsComplete()){
            Console.Write($" [ ] {this._name} ({this._description})");
        }
    }

    //This next method can be overridden in the child classes
    public virtual string SerializeSelf()
    {
        this._formattedString += $":{this.GetName()}"
                                +$":{this.GetDescription()}:{this.GetPoints()}"
                                +$":{this.GetTimesFinished()}";
        return this._formattedString;
    }
}