class Goals
{

    private int _pointTotal;
    List<BaseGoal> _myGoalsList = new List<BaseGoal>();

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
        _myGoalsList.Add(goal);
    }

    public void ListGoals()
    {
        Console.Clear();
        if (_myGoalsList.Count > 0)
        {
            int GoalNumber = 0;
            foreach (BaseGoal goal in _myGoalsList)
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
        else
        {
            Console.WriteLine("No current goals loaded. Try loading past goals or creating new ones.");
            Console.Write("Press 'Enter' to continue to Main Menu");
            Console.CursorVisible = false;
            Console.Read();
            Console.CursorVisible = true;
        }
    }

    public void ListGoalNames()
    {
        int GoalNumber = 0;
        Console.WriteLine("");
        Console.WriteLine("Your goals are:");
        
        foreach (BaseGoal goal in _myGoalsList)
        {
            GoalNumber = GoalNumber + 1;
            Console.Write($"{GoalNumber}.");
            Console.WriteLine(goal.GetGoalName());
        }
        Console.WriteLine("");
    }
    
    public void SaveGoals()
    {
        using (StreamWriter outputFile = new StreamWriter("Goals.txt"))
        {
            foreach(BaseGoal goal in _myGoalsList)
            {
                outputFile.WriteLine($"{goal}#{goal.SavingFormat()}");
            }
        }
    }
    
    public void LoadGoals()
    {
        if (File.Exists("Goals.txt") && new FileInfo("Goals.txt").Length > 0)
        {
            string[] lines = File.ReadAllLines("Goals.txt");
            foreach (string line in lines)
            {
                string[] parts = line.Split("#");

                if (parts[0] == "Simple")
                {
                    Simple loadedSimpleGoal = new Simple(parts[1], parts[2], int.Parse(parts[3]), int.Parse(parts[4]), parts[5]);
                    _myGoalsList.Add(loadedSimpleGoal);
                }
                else if (parts[0] == "Checklist")
                {
                    Checklist loadedChecklistGoal = new Checklist(parts[1], parts[2], int.Parse(parts[3]), int.Parse(parts[4]), parts[5], int.Parse(parts[6]), int.Parse(parts[7]));
                    _myGoalsList.Add(loadedChecklistGoal);
                }
                else if (parts[0] == "Eternal")
                {
                    Eternal loadedEternalGoal = new Eternal(parts[1], parts[2], int.Parse(parts[3]), int.Parse(parts[4]), parts[5]);
                    _myGoalsList.Add(loadedEternalGoal);
                }
                else
                    Console.WriteLine("Error. No Goals Loaded.");
            }
            Console.Clear();
            Console.WriteLine("Goals Loaded Successfully");
        }
        else
            Console.WriteLine("No Past Goals Found");
    }
    
    public void RecordEvent(Menu myMenus)
    {
        // Lists just the names with their corresponding numbers for better readibility
        ListGoalNames();

        // Displays the menu for the user to choose which goal to record an event for.
        int goalChoice = myMenus.RecordMenu(_myGoalsList);
        
        // Recreates the goal so we can work with it
        BaseGoal selectedGoal = _myGoalsList[goalChoice - 1];
        
        // Uses the recreated goal to update "Record Event"/"_goalIteration" and "Goal Completion"/"_goalComplete"
        int points = selectedGoal.RecordEvent();
        selectedGoal.GoalCompletion();
        
        // Adds points to total, cleans up the screen, and displays a message saying how many points were added.
        _pointTotal += points;
        Console.Clear();
        Console.WriteLine($"Event recorded successfully! {points} points added!");
    }
    
    public void DisplayPointTotal()
    {
        Console.WriteLine("");
        Console.WriteLine($"You have {_pointTotal} points");
    }

    public void DeleteGoal(Menu myMenus)
    {
        // Lists just the names with their corresponding numbers for better readibility
        ListGoalNames();
                
        // Displays the menu for the user to choose which goal to delete.
        int goalChoice = myMenus.DeletionMenu(_myGoalsList);
        
        // Removes the goal from the list and saves changes to the Goals.txt file.
        _myGoalsList.RemoveAt(goalChoice - 1);
        SaveGoals();
    }
}