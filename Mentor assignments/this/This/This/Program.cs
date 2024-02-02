using System;

public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }

    public Person(string name, int age)
    {
        // Using 'this' to distinguish between instance variables and constructor parameters
        this.Name = name;
        this.Age = age;
    }

    public void PrintDetails()
    {
        // Accessing instance variables using 'this'
        Console.WriteLine("Name: " + this.Name);
        Console.ReadLine();
        Console.WriteLine("Age: " + this.Age);
        Console.ReadLine();
    }

    public void UpdateDetails(string name, int age)
    {
        // Using 'this' to refer to the current instance of the class
        this.Name = name;
        this.Age = age;
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Creating an instance of the Person class
        Person person = new Person("John", 30);

        // Printing details of the person
        person.PrintDetails();

        // Updating details using a method
        person.UpdateDetails("Jane", 25);

        // Printing updated details
        person.PrintDetails();
    }
}
