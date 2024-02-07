using System;
using System.Reflection;
namespace print_type_info
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Type t = typeof(System.String);
            Console.WriteLine(t);
            Console.WriteLine(t.FullName);
            Console.WriteLine(t.BaseType);
            Console.WriteLine(t.IsClass);
            Console.WriteLine(t.IsEnum);
            Console.WriteLine(t.IsInterface);
            Console.ReadLine();
        }
    }
}
