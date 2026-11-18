using System;
using System.ComponentModel;

class Program
{
    static void Main(string[] args)
    {
        Menu myMenus = new Menu();
        Goals myGoals = new Goals();
        int choice = 0;

        myGoals.LoadGoals();
        
        while (choice != 6)
        {   
            myGoals.DisplayPointTotal();
            choice = myMenus.MainMenu();
            switch(choice)
            {
                case 1:
                    int category = myMenus.CategoryMenu();
                    switch(category)
                    {
                        case 1:
                            Simple mySimpleGoal = new Simple();
                            myGoals.AddGoal(mySimpleGoal);
                        break;

                        case 2:
                            Checklist myChecklistGoal = new Checklist();
                            myGoals.AddGoal(myChecklistGoal);
                        break;

                        case 3:
                            Eternal myEternalGoal = new Eternal();
                            myGoals.AddGoal(myEternalGoal);
                        break;

                        default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                    }
                break;

                case 2:
                    myGoals.ListGoals();
                break;

                case 3:
                    myGoals.SaveGoals();
                break;

                case 4:
                    myGoals.DeleteGoal(myMenus);
                break;

                case 5:
                    myGoals.RecordEvent(myMenus);
                break;

                default:
                Console.WriteLine("Invalid choice. Please try again.");
                break;
            }
        }
    }
}