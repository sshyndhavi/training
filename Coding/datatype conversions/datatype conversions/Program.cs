using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace datatype_conversions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // declaring variables for different type conversions
            int a = 10;
            float b = 20.6f;
            string c= "30";
            decimal d = 30.8m;
            bool e = true;
            char f = 'h';
            double g = 34.5d;
            long l = 567;
            short s = 2;
            Console.WriteLine(a + " " + b + " " + c + " " + d + " "+ e+ " "+ f + " " + g + " " + l + " " + s);
            // Console.Read();
            // implicit conversion
            float h = a;
            Console.WriteLine(h);
            // int i = b; explicit conversion is required
            int i = (int)b;
            Console.WriteLine(i);
            // boxing operation
            object o = a;
            Console.WriteLine(o);
            //unboxing
            int k = (int)o;
            Console.WriteLine(k );
            //parse
            int num = int.Parse(c);
            Console.WriteLine(num);
            //tryparse
            string str = "123";
            int number;
            if (int.TryParse(str, out number))
            {
                // Conversion successfuL
                Console.WriteLine(number);
            }
            else
            {
                // Conversion failed
                Console.WriteLine("conversion failed");
            }


        }
    }
}
