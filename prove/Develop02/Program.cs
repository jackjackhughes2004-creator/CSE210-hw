using System;

class Program
{
    static void Main(string[] args)
    {
        Menu myMenu = new Menu();
        int response = 0;
        Journal myEntry = new Journal();

        string nameFile = "username.txt";
        string name = "";

        // I exceeded requirements by adding a way to get the user's name which
        // is used throughout the rest of the program and saved for future refrence.
        if (System.IO.File.Exists(nameFile))
        {
            name = System.IO.File.ReadAllText(nameFile).Trim();
        }
        else
        {
            name = myMenu.GetName();
            System.IO.File.WriteAllText(nameFile, name);
        }

        Console.WriteLine($"Welcome to your Journal Program {name}!");

        while (response != 5)
        {
            response = myMenu.ProcessMenu();
            switch(response)
            {
                case 1:
                    Console.WriteLine("\nNew Journal Entry:");
                    myEntry.CreateJournalEntry();
                    break;
                case 2:
                    Console.WriteLine("\nDisplaying...");
                    myEntry.DisplayJournalEntries(name);
                    break;
                case 3:
                    Console.WriteLine("\nLoading Entries...");
                    myEntry.ReadFromFile("AllJournalEntries.txt");
                    break;
                case 4:
                    Console.WriteLine("\nSaving...");
                    myEntry.WriteToFile("AllJournalEntries.txt");
                    break;
            }
        }
    }
}