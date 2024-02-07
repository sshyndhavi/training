using System;
namespace generic_delegates
{
    public delegate T add<T>(T param1, T param2);
    public class Program
    {
        public static int Sum(int x, int y)
        {
            return x + y;

        }
        public static string Concat(string x, string y)
        {
            return x + y;

        }
        static void Main(string[] args)
        {
            add<int>sum  = Sum;
            Console.WriteLine(sum(10,20));

            add<string> concat = Concat;
            Console.WriteLine(concat("hello", "world"));

            Console.ReadLine();
        }
    }
  
}
