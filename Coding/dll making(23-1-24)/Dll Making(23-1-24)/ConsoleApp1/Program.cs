using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathFunction;


namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 20;

            int addResult = MathService.add(a,b);
            Console.WriteLine(addResult);
            Console.ReadLine();
        }
    }
}
