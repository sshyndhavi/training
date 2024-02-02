using System;
using System.Collections;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Extension_method
{
   
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "10";
            Console.WriteLine(s.ToInt());
            Console.ReadLine();

            
        }
    }
    public static class StringExtensions
    {
        public static int ToInt(this  string s)
        {
            return Convert.ToInt32(s);
        }
    }
}
