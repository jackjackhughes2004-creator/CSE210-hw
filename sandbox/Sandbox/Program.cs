using System;

class Program
{
    // static double AddNumbers (double x, int y)
    // {
    //     return x + y;
    // }
    

    
    // static void DisplayGreeting(string name)
    // {
    //     Console.WriteLine($"Welcome {name}, pleased to meet you.");
    // }

    static void Main(string[] args)
    {
       
        // DisplayGreeting("Bob");
        // double answer = AddNumbers(12.234, 10);
        // Console.WriteLine(answer);
       
        // bool done = false;

        // while (! done)
        // {
        //     Console.Write("Are we done? (y/n): ");
        //     done = Console.ReadLine().ToLower() == "y";
        // }

        // bool done;

        // do
        // {
        //     Console.Write("Are we done? (y/n): ");
        //     done = Console.ReadLine().ToLower() == "y";
        // } while(!done);

        // for(int i = 100000; i >-100000 ; i-= 10000)
        // Console.Write($"{i},");

        Console.Write("Please Enter Your Height: ");
        int height = int.Parse(Console.ReadLine());

        if (height >= 60 & height < 90)
        {
            Console.WriteLine("You can ride!");
        }
        else if (height >= 90)
        {
            Console.WriteLine("You are too tall to ride");
        }
        else
        {
            Console.WriteLine("You are too short to ride.");
        }

    }
}