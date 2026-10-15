using System;

class Program
{
    static void Main(string[] args)
    {
        // Step 4 Verification: Test constructors
        Fraction f1 = new Fraction();
        Fraction f2 = new Fraction(6);
        Fraction f3 = new Fraction(6, 7);

        Console.WriteLine(f1.GetFractionString());
        Console.WriteLine(f2.GetFractionString());
        Console.WriteLine(f3.GetFractionString());

        // Step 5 Verification: Test getters and setters
        Fraction f4 = new Fraction();
        f4.SetTop(3);
        f4.SetBottom(4);
        Console.WriteLine($"Top: {f4.GetTop()}, Bottom: {f4.GetBottom()}");

        // Step 6 Verification: Test representations
        Fraction test1 = new Fraction();
        Fraction test2 = new Fraction(5);
        Fraction test3 = new Fraction(3, 4);
        Fraction test4 = new Fraction(1, 3);

        Console.WriteLine(test1.GetFractionString());
        Console.WriteLine(test1.GetDecimalValue());
        
        Console.WriteLine(test2.GetFractionString());
        Console.WriteLine(test2.GetDecimalValue());
        
        Console.WriteLine(test3.GetFractionString());
        Console.WriteLine(test3.GetDecimalValue());
        
        Console.WriteLine(test4.GetFractionString());
        Console.WriteLine(test4.GetDecimalValue());

        // Step 7 Practice: Random loop
        Fraction randomFraction = new Fraction();
        Random rand = new Random();

        for (int i = 0; i < 20; i++)
        {
            int topNum = rand.Next(1, 10);
            int bottomNum = rand.Next(1, 10);

            randomFraction.SetTop(topNum);
            randomFraction.SetBottom(bottomNum);

            Console.WriteLine($"Fraction {i + 1}: string: {randomFraction.GetFractionString()} Number: {randomFraction.GetDecimalValue()}");
        }
    }
}