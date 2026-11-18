class BaseGoal
{
    private string _goalName;
    private string _goalDescription;
    private int _goalPoints;
    protected int _goalIteration;
    protected string _goalComplete;

    public BaseGoal(string goalName, string goalDescription, int goalPoints, int goalIteration, string goalComplete)
    {
        _goalName = goalName;
        _goalDescription = goalDescription;
        _goalPoints = goalPoints;
        _goalIteration = goalIteration;
        _goalComplete = goalComplete;
    }

    public BaseGoal()
    {
        SetGoalName();
        SetGoalDescription();
        SetGoalPoints();
        _goalIteration = 0;
        GoalCompletion();
    }

    public void SetGoalName()
    {
        Console.WriteLine("");
        Console.Write("Enter the name of your goal: ");
        _goalName = Console.ReadLine();
    }

    public string GetGoalName()
    {
        return _goalName;
    }

    public void SetGoalDescription()
    {
        Console.Write("Enter the description of your goal: ");
        _goalDescription = Console.ReadLine();
    }

    public void SetGoalPoints()
    {
        Console.Write("Enter the how many points your goal is worth: ");
        _goalPoints = int.Parse(Console.ReadLine());
    }

    public virtual int RecordEvent()
    {
        _goalIteration++;
        return _goalPoints;
    }

    public virtual string GoalCompletion()
    {
        if (_goalIteration >= 1)
            return _goalComplete = "X";
        else 
            return _goalComplete = " ";
    }

    public virtual string DisplayFormat()
    {
        return $"{_goalName} [{_goalComplete}]: {_goalPoints} Points\n({_goalDescription})";
    }

    public virtual string SavingFormat()
    {
        return $"{_goalName}#{_goalDescription}#{_goalPoints}#{_goalIteration}#{_goalComplete}";
    }
}