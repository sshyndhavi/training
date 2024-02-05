using System;

public class Pair<T>
{
    public T First { get; set; }
    public T Second { get; set; }

    public Pair(T first, T second)
    {
        First = first;
        Second = second;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Pair<int> intPair = new Pair<int>(10, 20);
        Pair<string> stringPair = new Pair<string>("Hello", "World");

        Console.WriteLine($"Int Pair: {intPair.First}, {intPair.Second}");
        Console.ReadLine();
        Console.WriteLine($"String Pair: {stringPair.First}, {stringPair.Second}");
        Console.ReadLine();
    }
}
