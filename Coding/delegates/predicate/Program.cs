using System;
namespace predicate
{
    internal class Program
    {
        public static bool IsUpper(string s)
        {
            return s.Equals(s.ToUpper());
        }
        static void Main(string[] args)
        {
            Predicate<string> isupper = IsUpper;
            bool result = isupper("hello");
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
