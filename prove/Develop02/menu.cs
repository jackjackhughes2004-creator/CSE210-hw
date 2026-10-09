using System.Net;
using System.Security.Cryptography.X509Certificates;

class Menu
{

    public string GetName()
    {
        Console.Write("Please Enter Your Name: ");
        string name = Console.ReadLine();
        
        return name;
    }

    public int ProcessMenu()
    {
        int choice = 0;

        while (choice < 1 || choice > 5)
        {
            Console.WriteLine("\nWhat would you like to do?");
            Console.WriteLine("1. New Journal Entry");
            Console.WriteLine("2. Display Journal");
            Console.WriteLine("3. Load All Old Journals");
            Console.WriteLine("4. Save Journal");
            Console.WriteLine("5. Quit");
            
            Console.Write("Please Select An Option: ");
            choice = int.Parse(Console.ReadLine());
        }

        return choice;
    }
}