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
        // creating Employee objects 
        Employee emp1 = new Employee("hyndu", "suri", "vsp", 35000);
        //  method to get the count of objects
        
        int count = Employee.GetObjectCount();

        Console.WriteLine("count of objects using instance method: " + count);
            Console.ReadLine();
        

    }

}
