using System;
using System.Collections.Generic;

    class Program
    {
        static void Main(string[] args)

        {
            // Create a list of strings
            List<string> stringList = new List<string>() 
            { "apple", "banana", "orange" };

            // Create a linked list using the IEnumerable constructor
            LinkedList<string> linkedList = new LinkedList<string>(stringList);

            // Print the elements of the linked list
            Console.WriteLine("Elements of the linked list:");
            foreach (var item in linkedList)
            {
                Console.WriteLine(item);
                Console.ReadLine();
            }

            // Add more elements to the linked list
            linkedList.AddLast("grapes");
            linkedList.AddFirst("kiwi");

            // Print the updated elements of the linked list
            Console.WriteLine("\nUpdated elements of the linked list:");
            foreach (var item in linkedList)
            {
                Console.WriteLine(item);
                Console.ReadLine();
            }
        }
    }

