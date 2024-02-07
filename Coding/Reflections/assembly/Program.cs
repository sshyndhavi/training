using System;
using System.Reflection;

namespace assembly
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Type t = typeof(System.String);
            Console.WriteLine(t.Assembly);
            Console.ReadLine();
        }
    }
}
