using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Scripture scripture = new Scripture("Proverbs", 3, 5, 6, "Trust in the Lord with all thine heart; and lean not unto thine own understanding.");

        int choice = 1;
        while (choice != 2)
        {
            Console.Clear();
            scripture.GetDisplayText();
            Console.WriteLine();

            if (scripture.IsCompletelyHidden())
            {
                Console.WriteLine("All words are hidden. Great job memorizing!");
                break;
            }

            Console.WriteLine("1. Continue (Hide more words)");
            Console.WriteLine("2. Quit");
            Console.Write("Please Choose a Number: ");
            
            string input = Console.ReadLine();
            
            if (!int.TryParse(input, out choice))
            {
                choice = -1;
            }

            if (choice == 1)
            {
                scripture.HideRandomWords(3);
            }
            else if (choice == 2)
            {
                break;
            }
            else
            {   
                Console.WriteLine("");
                Console.WriteLine("Unrecognized Input. Please try again.");
                Console.WriteLine("");
                Console.WriteLine("Press Enter to continue...");
                Console.ReadLine();
            }
        }
    }
}