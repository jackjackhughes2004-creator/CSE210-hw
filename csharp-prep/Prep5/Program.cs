using System;
using System.ComponentModel.DataAnnotations;

class Program
{
    static void DisplayGreeting()
    {
        Console.WriteLine("Welcome to program!");
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string user_name = Console.ReadLine();
        return user_name;
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int favorite_number = int.Parse(Console.ReadLine());
        return favorite_number;
    }

    static void PromptUserBirthYear(out int birthYear)
    {
        Console.Write($"Please enter the year you were born: ");
        birthYear = int.Parse(Console.ReadLine());
    }

    static int SquareNumber(int number)
    {
        int square = number * number;
        return square;
    }
    static void Main(string[] args)
    {
        DisplayGreeting();
        string user_name = PromptUserName();
        int favorite_number = PromptUserNumber();

        int BirthYear;
        PromptUserBirthYear(out BirthYear);

        int Squared_Favorite_Number = SquareNumber (favorite_number);

        DisplayResult(user_name, Squared_Favorite_Number, BirthYear);
    }

    static void DisplayResult(string user_name, int Squared_Favorite_Number, int BirthYear)
    {
    Console.WriteLine($"{user_name}, your favorite number squared is {Squared_Favorite_Number}");
    Console.WriteLine($"{user_name}, you will turn {2026 - BirthYear} this year.");
    }
    
}