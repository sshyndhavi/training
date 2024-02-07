using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reference_data_type
{
    public class Person
    {
        public int id;  
        public string name;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            p.id = 1;
            p.name = "test";
            Person op = p;
            op.id = 2;
            Console.WriteLine(op.id);
            Console.WriteLine(p.id);
            Console.ReadLine();

        }
    }
}
