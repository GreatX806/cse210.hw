// C# Programming Exercise 2: Conditionals
// This program demonstrates how to use conditional statements (if, else if, else) to make decisions.

using System;

public class Exercise2
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Welcome to C# Exercise 2!");

        // --- Input ---
        // Prompt the user to enter a temperature.
        Console.Write("Enter the current temperature in Celsius: ");
        string tempInput = Console.ReadLine();

        // Convert the input string to a number (double for potential decimal values).
        double temperature = double.Parse(tempInput);

        // --- Conditionals ---
        // Use if, else if, and else to check the temperature and provide a message.
        if (temperature < 0) // If the temperature is less than 0...
        {
            Console.WriteLine("It's freezing outside!");
        }
        else if (temperature >= 0 && temperature < 10) // Else if the temperature is 0 or more AND less than 10...
        {
            Console.WriteLine("It's quite cold.");
        }
        else if (temperature >= 10 && temperature < 20) // Else if the temperature is 10 or more AND less than 20...
        {
            Console.WriteLine("It's cool.");
        }
        else if (temperature >= 20 && temperature < 30) // Else if the temperature is 20 or more AND less than 30...
        {
            Console.WriteLine("It's warm.");
        }
        else // If none of the above conditions are true (temperature is 30 or more)...
        {
            Console.WriteLine("It's hot!");
        }

        // Another simple conditional example.
        Console.Write("Enter your score (0-100): ");
        string scoreInput = Console.ReadLine();
        int score = int.Parse(scoreInput);

        if (score >= 70)
        {
            Console.WriteLine("You passed!");
        }
        else
        {
            Console.WriteLine("You need to study more.");
        }


        // Keep the console window open.
        Console.WriteLine("\nPress Enter to finish.");
        Console.ReadLine();
    }
}
