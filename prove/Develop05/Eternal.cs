class Eternal : BaseGoal
{

    public Eternal(string goalName, string goalDescription, int goalPoints, int goalIteration, string goalComplete)
    : base (goalName, goalDescription, goalPoints, goalIteration, goalComplete)
    {
    }

    public Eternal()
    : base ()
    {
    }
    
    
    public override string GoalCompletion()
    {
        return _goalComplete = "Infinity";
    }

    public override string DisplayFormat()
    {
        return $" Eternal: {base.DisplayFormat()} Amount Completed: {_goalIteration}";
    }
}