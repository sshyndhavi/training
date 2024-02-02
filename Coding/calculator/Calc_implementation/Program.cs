using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc_implementation
{
    internal class Program
    {
        static void Main(string[] args)
        {// Create an instance of the Calculator class
            Calculator calc = new Calculator();

            // Call the Add method
            #region Addition
            int sum = calc.Add(5, 3);
            Console.WriteLine("Sum: " + sum);
            Console.ReadLine();
            #endregion
            // Call the Subtract method
            int difference = calc.Subtract(10, 4);
            Console.WriteLine("Difference: " + difference);
            Console.ReadLine();
        }
    }
}
