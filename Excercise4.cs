// C# Programming Exercise 4: Lists
// This program demonstrates how to use Lists to store collections of items.

using System;
using System.Collections.Generic; // This line is needed to use List<T>.

public class Exercise4
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Welcome to C# Exercise 4!");

        // --- Creating a List ---
        // Create a List of strings to store names.
        List<string> names = new List<string>(); // List<string> means it's a list that will hold strings.

        // --- Adding items to a List ---
        names.Add("Alice");
        names.Add("Bob");
        names.Add("Charlie");
        names.Add("David");

        // --- Accessing items in a List ---
        // You can access items by their index (position), starting from 0.
        Console.WriteLine($"The first name in the list is: {names[0]}"); // Index 0 is the first item.
        Console.WriteLine($"The third name in the list is: {names[2]}"); // Index 2 is the third item.

        // --- Getting the number of items in a List ---
        Console.WriteLine($"There are {names.Count} names in the list.");

        // --- Iterating through a List (using a foreach loop) ---
        // A foreach loop is a common way to go through every item in a collection.
        Console.WriteLine("\nNames in the list:");
        foreach (string name in names) // For each 'name' (which is a string) in the 'names' list...
        {
            Console.WriteLine(name);
        }

        // --- Removing items from a List ---
        names.Remove("Bob"); // Remove the item with the value "Bob".
        Console.WriteLine($"\nAfter removing Bob, there are {names.Count} names.");

        // --- Checking if an item exists in a List ---
        if (names.Contains("Alice"))
        {
            Console.WriteLine("Alice is still in the list.");
        }

        // --- Clearing all items from a List ---
        names.Clear();
        Console.WriteLine($"After clearing the list, there are {names.Count} names.");


        // Keep the console window open.
        Console.WriteLine("\nPress Enter to finish.");
        Console.ReadLine();
    }
}
