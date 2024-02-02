using System;

class Program
{
    static void Main(string[] args)
    {
        // Calling the PrintMessage method with and without specifying optional parameters
        PrintMessage("Hello"); // Will use default values for count and suffix
        PrintMessage("Hi", 3); // Will use "Hi" as message, 3 as count, and default suffix
        PrintMessage("Hey", 2, "!"); // Will use "Hey" as message, 2 as count, and "!" as suffix
    }

    // Method with optional parameters
    static void PrintMessage(string message, int count = 1, string suffix = ".")
    {
        for (int i = 0; i < count; i++)
        {
            Console.Write(message + suffix + " ");
        }
        Console.WriteLine();
    }
}
