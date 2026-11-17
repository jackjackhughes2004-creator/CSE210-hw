using System;
using System.ComponentModel;

class Program
{
    static void Main(string[] args)
    {
        Menu myMenus = new Menu();
        List<BaseGoal> myGoalsList = new List<BaseGoal>();
        Goals myGoals = new Goals();
        int choice = 0;
        
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
                            myGoalsList.Add(mySimpleGoal);
                        break;

                        case 2:
                            Checklist myChecklistGoal = new Checklist();
                            myGoalsList.Add(myChecklistGoal);
                        break;

                        case 3:
                        break;

                        default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                    }
                break;

                case 2:
                    myGoals.ListGoals(myGoalsList);
                break;

                case 3:
                break;

                case 4:
                break;

                case 5:
                    myGoals.ListGoalNames(myGoalsList);
                    int GoalChoice = myMenus.RecordMenu(myGoalsList);
                    BaseGoal selectedGoal = myGoalsList[GoalChoice - 1];
                    int points = selectedGoal.RecordEvent();
                    selectedGoal.GoalCompletion();
                    myGoals.RecordEvent(points);
                    Console.WriteLine("Event recorded successfully!");
                break;

                default:
                Console.WriteLine("Invalid choice. Please try again.");
                break;
            }
        }

    }
}