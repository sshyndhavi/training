using System;

public class Employee
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Address { get; set; }
    public decimal Salary { get; set; }

    // Static field to count the number of objects
    private static int objectCount = 0;

    // Constructor
    public Employee(string firstName, string lastName, string address, decimal salary)
    {
        FirstName = firstName;
        LastName = lastName;
        Address = address;
        Salary = salary;

        // Increment the object count when a new object is created
        objectCount++;
    }

    // Static method to get the count of objects
    public static int GetObjectCount()
    {
        return objectCount;
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Creating Employee objects
        Employee emp1 = new Employee("John", "Doe", "123 Main St", 50000);
        Employee emp2 = new Employee("Jane", "Smith", "456 Elm St", 60000);

        //  method to get the count of objects
        int count = CountObjectsUsingStaticMethod();
    

        Console.WriteLine("Count of objects using static method: " + count);
        Console.ReadLine();
        
    }

    // Method to count objects using a static method
    static int CountObjectsUsingStaticMethod()
    {
        return Employee.GetObjectCount();
    }
}
