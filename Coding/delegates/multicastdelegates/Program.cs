using System;

public delegate void MyDelegate(string msg);
public class Program
{
    public static void Main()
    {
        MyDelegate del1 = ClassA.MethodA;
        MyDelegate del2 = ClassB.MethodB;

        MyDelegate del = del1 + del2;
        Console.WriteLine("After del1 + del2");
        del("Hello World");

        MyDelegate del3 = (string msg) => Console.WriteLine("Called lambda expression: " + msg);
        del += del3;
        Console.WriteLine("After del1 + del2 + del3");
        del("hello world");

        del = del - del2;
        Console.WriteLine("After del - del2");
        del("Hello World");

        del -= del1;
        Console.WriteLine("After del1 - del1");
        del("Hello World");
        Console.ReadLine();
    }
}

public class ClassA
{
    public static void MethodA(string message)
    {
        Console.WriteLine("Called ClassA.MethodA() with parameter: " + message);
    }
}

public class ClassB
{
    public static void MethodB(string message)
    {
        Console.WriteLine("Called ClassB.MethodB() with parameter: " + message);
    }
}
