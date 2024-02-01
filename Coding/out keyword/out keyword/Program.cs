using System;

class Program
{
    static void Main(string[] args)
    {
        int result; // Variable to store the output parameter

        // Call the method with the 'out' parameter
        Add(5, 3, out result);

        // Print the result
        Console.WriteLine("The sum is: " + result); // Output will be 8
    }

    // Method that calculates the sum of two numbers and returns it through an 'out' parameter
    static void Add(int a, int b, out int sum)
    {
        sum = a + b; // The result is assigned to the 'out' parameter
    }
}
