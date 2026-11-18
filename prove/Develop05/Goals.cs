class Goals
{

    private int _pointTotal;
    List<BaseGoal> myGoalsList = new List<BaseGoal>();

    public Goals(int pointTotal)
    {
        _pointTotal = pointTotal;
    }
    
    public Goals()
    {
        _pointTotal = 0;
    }
    
    public void AddGoal(BaseGoal goal)
    {
        myGoalsList.Add(goal);
    }

    public void ListGoals()
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
    
    public void RecordEvent(Menu myMenus)
    {
        // Lists just the names with their corresponding numbers for better readibility
        ListGoalNames(myGoalsList);

        // Displays the menu for the user to choose which goal to record an event for.
        int GoalChoice = myMenus.RecordMenu(myGoalsList);
        
        BaseGoal selectedGoal = myGoalsList[GoalChoice - 1];
        int points = selectedGoal.RecordEvent();
        selectedGoal.GoalCompletion();
        _pointTotal += points;
        Console.Clear();
        Console.WriteLine($"Event recorded successfully! {points} points added!");
    }
    
    public void DisplayPointTotal()
    {
        Console.WriteLine("");
        Console.WriteLine($"You have {_pointTotal} points");
    }

}