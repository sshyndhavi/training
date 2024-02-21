using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extensionmethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 10;
            bool result = i.IsGreater(100);
            Console.WriteLine(result);
        }
    }
}
