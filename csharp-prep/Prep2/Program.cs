using System;

class Program
{
    static void Main(string[] args)
    {
        string letter;

        Console.Write("Please enter your grade percentage: ");
        string userinput = Console.ReadLine();
        int x = int.Parse(userinput);

        if (x>=90)
            letter = "A";
        else if (x>=80 && x<90)
            letter = "B";
        else if (x>=70 && x<80)
            letter = "C";
        else if (x>=60 && x<70)
            letter = "D";
        else if (x<60)
            letter = "F";
        else
            letter = "";
        
        Console.WriteLine($"Your grade is: {letter}");

        if (x>=70)
            Console.WriteLine("You Passed The Class!");
        else
            Console.WriteLine("You Failed!");
    }
}