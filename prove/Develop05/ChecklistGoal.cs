class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(int target, int bonus)
        :base()
    {
        _target = target;
        _bonus = bonus;
    }

    public void RecordEvent()
    {
        //fill in later with override
    }

    public bool isComplete()
    {
        //fill in later with override
    }

    public string GetDetailsString()
    {
        // fill in with override
    }

    public string GetStringRepresentation()
    {
        //fill in with override
    }

}