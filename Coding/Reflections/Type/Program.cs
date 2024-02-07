using System;
using System.Reflection;

namespace Reflection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            Type result = a.GetType();
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
