using System;

class Program
{
    static void Main(string[] args)
    {
        Menu menu = new Menu();
        int choice = 0;
        int totalBreathingSeconds = 0;
        int totalReflectionSeconds = 0;
        int totalListingSeconds = 0;

        while (choice != 4)
        {
            choice = menu.DisplayMenu();

            BaseActivity activity = null;

            switch (choice)
            {
                case 1:
                    activity = new BreathingActivity("Breathing Activity", 
                        "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.");
                        totalBreathingSeconds += activity.RunActivity();
                        Console.WriteLine($"Total breathing time so far: {totalBreathingSeconds} seconds");
                        Thread.Sleep(1500);
                    break;
                case 2:
                    activity = new ReflectionActivity("Reflection Activity", 
                        "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
                        totalReflectionSeconds += activity.RunActivity();
                        Console.WriteLine($"Total Reflection time so far: {totalReflectionSeconds} seconds");
                        Thread.Sleep(1500);
                    break;
                case 3:
                    activity = new ListingActivity("Listing Activity", 
                        "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
                        totalListingSeconds += activity.RunActivity();
                        Console.WriteLine($"Total Listing time so far: {totalListingSeconds} seconds");
                        Thread.Sleep(1500);
                    break;
                case 4:
                    Console.WriteLine("Goodbye!");
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    Thread.Sleep(1500);
                    break;
            }
        }
    }
}