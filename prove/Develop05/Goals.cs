class Goals
{

    private int _pointTotal;

    public Goals(int pointTotal)
    {
        _pointTotal = pointTotal;
    }
    
    public Goals()
    {
        _pointTotal = 0;
    }
    
    public void ListGoals(List<BaseGoal> myGoalsList)
    {
        Console.WriteLine("");
        int GoalNumber = 0;
        foreach (BaseGoal goal in myGoalsList)
        {
            GoalNumber = GoalNumber + 1;
            Console.Write($"{GoalNumber}.");
            Console.WriteLine(goal.DisplayFormat());
            Console.WriteLine("");
            
        }
        Console.Write("Press 'Enter' to continue to Main Menu");
        Console.CursorVisible = false;
        Console.Read();
        Console.CursorVisible = true;
    }

    public void ListGoalNames(List<BaseGoal> myGoalsList)
    {
        int GoalNumber = 0;
        Console.WriteLine("");
        Console.WriteLine("Your goals are:");
        
        foreach (BaseGoal goal in myGoalsList)
        {
            GoalNumber = GoalNumber + 1;
            Console.Write($"{GoalNumber}.");
            Console.WriteLine(goal.GetGoalName());
        }
        Console.WriteLine("");
    }
    
    public void SaveGoals(string filename)
    {
        
    }
    
    public void LoadGoals(string filename)
    {
        
    }
    
    public void RecordEvent(int points)
    {
        _pointTotal += points;
    }
    
    public void DisplayPointTotal()
    {
        Console.WriteLine("");
        Console.WriteLine($"You have {_pointTotal} points");
    }

}