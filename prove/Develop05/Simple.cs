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

    public override string DisplayFormat()
    {
        return $"{base.DisplayFormat()}";
    }
}