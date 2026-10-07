using System.Net;

class Menu
{
    public int ProcessMenu()
    {
        int choice = 0;

        while (choice < 1 || choice > 5)
        {
            Console.WriteLine("Welcome to Journal Program!");
            Console.WriteLine("1. New Journal Entry");
            Console.WriteLine("2. Display Journal");
            Console.WriteLine("3. Read Journal From File");
            Console.WriteLine("4. Write Journal To File");
            Console.WriteLine("5. Quit");
            
            Console.Write("Please Select An Option: ");
            choice = int.Parse(Console.ReadLine());
        }

        return choice;
    }
}