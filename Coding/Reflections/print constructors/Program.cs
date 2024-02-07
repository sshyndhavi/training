using System;
using System.Reflection;

namespace print_constructors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Type t = typeof(System.String);
            Console.WriteLine("constructors of type"+t);
            ConstructorInfo[] ci = t.GetConstructors(BindingFlags.Public|BindingFlags.Instance);
            foreach (ConstructorInfo c in ci) 
            {
                Console.WriteLine(c);
                Console.ReadLine();
            }
        }
    }
}
