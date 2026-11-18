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
        SetTargetAmount();
        SetBonusPoints();
    }

    public void SetTargetAmount()
    {
        bool allowExit = false;
        while (allowExit != true)
        {    
            Console.Write("Enter how many times will you do this before you meet your goal: ");
            if (int.TryParse(Console.ReadLine(), out int targetAmount) && targetAmount > 0)
            {
                _targetAmount = targetAmount;
                allowExit = true;
            }
            else
                Console.WriteLine("Unauthorized Value, Please Enter A Positive Number");
        }
    }

    public void SetBonusPoints()
    {
        bool allowExit = false;
        while (allowExit != true)
        {    
            Console.Write("Enter the how many bonus points will you get when you meet your goal: ");
            if (int.TryParse(Console.ReadLine(), out int bonusPoints) && bonusPoints >= 0)
            {
                _bonusPoints = bonusPoints;
                allowExit = true;
            }
            else
                Console.WriteLine("Unauthorized Value, Please Enter A Positive Number");
        }
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