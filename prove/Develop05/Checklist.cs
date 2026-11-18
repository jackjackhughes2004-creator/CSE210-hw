class Checklist : BaseGoal
{
    private int _targetAmount;
    private int _bonusPoints;

    public Checklist(string goalName, string goalDescription, int goalPoints, int goalIteration, string goalComplete, int targetAmount, int bonusPoints)
    : base (goalName, goalDescription, goalPoints, goalIteration, goalComplete)
    {
        _targetAmount = targetAmount;
        _bonusPoints = bonusPoints;
    }

    public Checklist()
    : base ()
    {
        GetTargetAmount();
        GetBonusPoints();
    }

    public void GetTargetAmount()
    {
        Console.Write("Enter how many times will you do this before you meet your goal: ");
        _targetAmount = int.Parse(Console.ReadLine());
    }

    public void GetBonusPoints()
    {
        Console.Write("Enter the how many bonus points will you get when you meet your goal: ");
        _bonusPoints = int.Parse(Console.ReadLine());
    }
    
    
    public override string GoalCompletion()
    {
        if (_goalIteration >= _targetAmount)
        {
            return base.GoalCompletion();
        }
        else 
        {
            return _goalComplete = " ";
        }
    }

    public override int RecordEvent()
    {
        _goalIteration++;
        if (_goalIteration < _targetAmount)
        {   
            _goalIteration--;
            return base.RecordEvent();
        }
        else if (_goalIteration == _targetAmount)
        {
            return _bonusPoints;
        }
        else
            return 0;
    }

    public override string DisplayFormat()
    {
        return $" Checklist: {base.DisplayFormat()}\nProgress: {_goalIteration}/{_targetAmount} ({_bonusPoints} Bonus Points on Completion)";
    }

    public override string SavingFormat()
    {
        return $"{base.SavingFormat()}#{_targetAmount}#{_goalIteration}";
    }
}