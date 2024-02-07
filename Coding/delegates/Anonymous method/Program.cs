using System;
namespace Anonymous_method
{
    public delegate void Print(int val);
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 10;
            Print pr = delegate (int val)
            {
                val += 10;
                Console.WriteLine(val);
                Console.ReadLine();
                
            };
            pr(100);
         
        

        }
    }
}
