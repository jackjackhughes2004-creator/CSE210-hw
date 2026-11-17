class Menu
{
    public int MainMenu()
    {
        Console.WriteLine("");
        Console.WriteLine("1. Create New Goal");
        Console.WriteLine("2. List Goals");
        Console.WriteLine("3. Save Goals");
        Console.WriteLine("4. Load Goals");
        Console.WriteLine("5. Record Event");
        Console.WriteLine("6. Quit");
        Console.Write("Select a choice from the menu: ");
        
        string input = Console.ReadLine();
        
        if (int.TryParse(input, out int choice))
        {
            return choice;
        }
        return 0;
    }

    public int CategoryMenu()
    {
        Console.WriteLine("");
        Console.WriteLine("Which Goal Would You Like To Create?");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Select a choice from the menu: ");
        
        string input = Console.ReadLine();
        
        if (int.TryParse(input, out int choice))
        {
            return choice;
        }
        return 0;
    }

    public int RecordMenu(List<BaseGoal> myGoalsList)
    {
        Console.WriteLine("Which goal would you like to record an event for?");
        Console.Write("Enter the goal number: ");
        string input = Console.ReadLine();
        
        // Parse the input and check if it's a valid number and within the list's range (1-indexed)
        if (int.TryParse(input, out int choice))
        {
            if (choice >= 1 && choice <= myGoalsList.Count)
            {
            return choice;
            }
        }
        return 0;
    }
}