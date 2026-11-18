class Simple : BaseGoal
{

    public Simple(string goalName, string goalDescription, int goalPoints, int goalIteration, string goalComplete)
    : base (goalName, goalDescription, goalPoints, goalIteration, goalComplete)
    {
    }

    public Simple()
    : base ()
    {

    }

    public override int RecordEvent()
    {
        _goalIteration++;
        if (_goalIteration == 1)
            return base.RecordEvent();
        else
            return 0;
    }

    public override string DisplayFormat()
    {
        return $" Simple: {base.DisplayFormat()}";
    }
}