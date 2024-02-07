using System;
namespace delegates
{
    //creating delegate
    public delegate void Mydelegate(string msg);
    public class Program
    {
        public static void Main()
        {
            //creating target method
            Mydelegate del = Class1.method1;
            del("hello world");
            del = Class2.method2;
            del("hi world");
            //creating lambda expression
            del =(string msg) => Console.WriteLine(msg);
            del("where are you");
            Console.ReadLine();
        }
    }
        class Class1
        {
            public static void method1(string msg)
            {
                Console.WriteLine(""+msg);
            }
        }
        class Class2
        {
            public static void method2(string msg)
            {
                Console.WriteLine(""+msg);
            }
        }
    
}
        

