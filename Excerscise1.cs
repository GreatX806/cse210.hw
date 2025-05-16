// C# Programming Exercise 1: Variables, Input, and Output
// This program demonstrates how to use variables, get input from the user, and display output.

using System;

public class Exercise1
{
    public static void Main(string[] args)
    {
        // --- Output ---
        // Display a welcome message to the user.
        Console.WriteLine("Welcome to C# Exercise 1!");

        // --- Input ---
        // Prompt the user to enter their favorite color.
        Console.Write("What is your favorite color? ");
        // Read the user's input and store it in a string variable.
        string favoriteColor = Console.ReadLine();

        // Prompt the user to enter a whole number.
        Console.Write("Enter a whole number: ");
        // Read the user's input (which is initially text) and store it in a string variable.
        string numberInput = Console.ReadLine();

        // --- Variables ---
        // We already have 'favoriteColor' (string) and 'numberInput' (string).
        // Now, let's convert the number input from text to an integer (whole number).
        int userNumber = int.Parse(numberInput); // Use int.Parse to convert the string to an integer.

        // --- Output using Variables ---
        // Display the information using the variables we created.
        Console.WriteLine($"Your favorite color is: {favoriteColor}"); // Using string interpolation ($"...") for cleaner output.
        Console.WriteLine($"The number you entered is: {userNumber}");

        // Perform a simple calculation with the variable and display the result.
        int doubledNumber = userNumber * 2;
        Console.WriteLine($"Your number doubled is: {doubledNumber}");

        // Keep the console window open until the user presses Enter.
        Console.WriteLine("\nPress Enter to finish.");
        Console.ReadLine();
    }