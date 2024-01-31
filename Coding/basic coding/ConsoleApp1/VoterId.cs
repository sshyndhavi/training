using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class VoterId
    {
       public static void Main()
            {
            int age = Convert.ToInt32(Console.ReadLine());
            if (age >= 18)
            Console.WriteLine("they are eligible");
            else
            Console.WriteLine("they are not eligible");
            }
    }
}
