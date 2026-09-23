using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        int user_number = 1;
        int total = 0;

        Console.WriteLine("Enter a list of numbers, type 0 when finished. (Zero will not be added to the average.)");
        List<int> numbers = new List<int>();

        while (user_number != 0)
        {
            Console.Write("Enter a Number: ");
            user_number = int.Parse(Console.ReadLine());
            
            if (user_number != 0)
                numbers.Add(user_number);
            else
                user_number = 0;
        }
        
        foreach (int number in numbers)
        {
            total += number;
        }    
        Console.WriteLine($"The sum is: {total}");
        Console.WriteLine($"The average is: {total/numbers.Count}");

        int max = numbers[0];

        foreach (int number in numbers)
        {
            if (number > max)
                max = number;
        }
        Console.WriteLine($"The max is: {max}");
    }
}