using System;
namespace action
{
    internal class Program
    {
        public static void Print(int i)
        {
            Console.WriteLine(i);
        }
        static void Main(string[] args)
        {
            // declaring target method
            Action<int> result = Print;
            Console.WriteLine();
            result(10);
            // declaring lambda expression
            Action<int> print = i => Console.WriteLine(i);
            result(10);
            Console.ReadLine();
        }
    }
}
