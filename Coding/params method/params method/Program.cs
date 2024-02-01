using System;

class Program
{
    static void Main(string[] args)
    {
        // Calling the method with different numbers of arguments
        DisplayNumbers(1, 2, 3);
        DisplayNumbers(10, 20, 30, 40, 50);
        DisplayNumbers(); // No arguments
    }

    // Method that takes a variable number of integer arguments using 'params'
    static void DisplayNumbers(params int[] numbers)
    {
        Console.WriteLine("The numbers are:");

        // Iterate through the array of numbers and display each one
        foreach (int num in numbers)
        {
            Console.WriteLine(num);
        }

        Console.WriteLine();
    }
}
