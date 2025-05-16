// C# Programming Exercise 5: Functions (also called Methods in C#)
// This program demonstrates how to create and use functions to organize code and perform specific tasks.

using System;

public class Exercise5
{
    // The Main function is the entry point of the program.
    public static void Main(string[] args)
    {
        Console.WriteLine("Welcome to C# Exercise 5!");

        // --- Calling a Function ---
        // We call the 'Greet' function to execute the code inside it.
        Greet("Great Afangide"); // Passing a value ("Great Afangide") to the function.

        // Call the 'AddNumbers' function and store the returned result in a variable.
        int sum = AddNumbers(5, 10);
        Console.WriteLine($"The sum of 5 and 10 is: {sum}");

        // Call the 'IsEven' function and use its returned boolean value in a conditional.
        int numberToCheck = 7;
        if (IsEven(numberToCheck))
        {
            Console.WriteLine($"{numberToCheck} is an even number.");
        }
        else
        {
            Console.WriteLine($"{numberToCheck} is an odd number.");
        }


        // Keep the console window open.
        Console.WriteLine("\nPress Enter to finish.");
        Console.ReadLine();
    }

    // --- Creating Functions ---

    // This is a simple function that takes one argument (a string name) and doesn't return a value (void).
    public static void Greet(string name)
    {
        Console.WriteLine($"Hello, {name}!");
    }

    // This function takes two integer arguments and returns an integer value (their sum).
    public static int AddNumbers(int num1, int num2)
    {
        int result = num1 + num2;
        return result; // 'return' sends the result back to where the function was called.
    }

    // This function takes one integer argument and returns a boolean value (true or false).
    public static bool IsEven(int number)
    {
        // The modulo operator (%) gives the remainder of a division.
        // If a number divided by 2 has a remainder of 0, it's even.
        if (number % 2 == 0)
        {
            return true; // Return true if the number is even.
        }
        else
        {
            return false; // Return false if the number is odd.
        }
        // A shorter way to write the IsEven function:
        // return number % 2 == 0;
    }
}
