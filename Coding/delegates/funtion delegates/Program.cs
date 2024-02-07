using System;
namespace Delegates
{
    public class Program
    {
        public static int Sum(int x, int y)
        {
            return x + y;
        }
        public static  void Main(string[] args)
        {
            Func<int, int, int> add = Sum;
            Console.WriteLine(add(1, 2));
            Console.ReadLine();
        }
    }
}
