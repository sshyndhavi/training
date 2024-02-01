using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NamedParameterEx
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int areaResult = CalculateArea(breadth: 20, length: 10);
            Console.WriteLine("Length {0} * Breadth {1} = Area {2}", 10, 20, areaResult);
            Console.Read();

        }
        public static int CalculateArea(int length, int breadth)
        {
            return length * breadth;
        }

    }
}
