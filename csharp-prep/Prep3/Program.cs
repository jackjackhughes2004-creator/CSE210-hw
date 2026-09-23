using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magic_number = randomGenerator.Next(1, 100);

        bool guessed = false;
        int guess_amount = 0;

        while (! guessed)
        {
            guess_amount ++;
            Console.Write("Please enter your guess: ");
            string userinput2 = Console.ReadLine();
            int guess = int.Parse(userinput2);

            if (guess == magic_number)
                {
                    Console.WriteLine("You guessed it!");
                    guessed = true;
                }
            else if (guess > magic_number)
                Console.WriteLine("Lower");
            else if (guess < magic_number)
                Console.WriteLine("Higher");
            else
                Console.WriteLine("try again :(");
        }   
        Console.WriteLine($"It only took you {guess_amount} guesses!");

    }
}