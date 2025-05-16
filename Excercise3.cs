// C# Programming Exercise 3: Loops
// This program demonstrates how to use loops (for and while) to repeat actions.

using System;

public class Exercise3
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Welcome to C# Exercise 3!");

        // --- For Loop ---
        // A for loop is often used when you know how many times you want to loop.
        Console.WriteLine("\nUsing a for loop to count from 1 to 5:");
        for (int i = 1; i <= 5; i++) // Start at i=1, continue as long as i is <= 5, increase i by 1 each time.
        {
            Console.WriteLine($"Count: {i}");
        }

        // --- While Loop ---
        // A while loop is often used when you don't know exactly how many times to loop,
        // but you have a condition that needs to be true to continue looping.
        Console.WriteLine("\nUsing a while loop to count down from 5 to 1:");
        int count = 5;
        while (count >= 1) // Continue as long as 'count' is greater than or equal to 1.
        {
            Console.WriteLine($"Countdown: {count}");
            count = count - 1; // Decrease 'count' by 1 each time (important to avoid an infinite loop!).
            // count--; // This is a shorthand way to decrease by 1.
        }

        // --- Do-While Loop (less common, but good to know) ---
        // A do-while loop is similar to a while loop, but it *always* executes the code inside the loop at least once
        // before checking the condition.
        Console.WriteLine("\nUsing a do-while loop (will run at least once):");
        int j = 0;
        do
        {
            Console.WriteLine($"Do-While iteration: {j}");
            j++;
        } while (j < 3); // The condition is checked *after* the first iteration.


        // Keep the console window open.
        Console.WriteLine("\nPress Enter to finish.");
        Console.ReadLine();
    }
}
