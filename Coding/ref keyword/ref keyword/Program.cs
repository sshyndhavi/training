using System;

class Program
{
    static void Main(string[] args)
    {
        int number = 5; // Declare and initialize a variable

        Console.WriteLine("Before method call: " + number); // Output: 5

        // Call the method with the 'ref' parameter
        IncrementRef(ref number);

        Console.WriteLine("After method call: " + number); // Output: 6
    }

    // Method that increments the value of the parameter passed by reference
    static void IncrementRef(ref int num)
    {
        num++; // Increment the value of the parameter by 1
    }
}
