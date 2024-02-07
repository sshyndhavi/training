using System;
namespace multicaste_delegates_with_values
{
    public delegate int Mydelegate();
    public class Program
    {
        public static void Main(string[] args)
        {
            Mydelegate del1 = class1.Method1;
            Mydelegate del2 = class2.Method2;
            Mydelegate del = del1 + del2;
            Console.WriteLine( del());
            Console.ReadLine();
        }
    }
    public class class1 
    {
        public static int Method1()
        {
            return 100;
        }

    }
    public class class2
    {
        public static int Method2()
        {
            return 200;
        }

    }


}
