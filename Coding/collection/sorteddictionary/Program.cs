using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sorteddictionary
{
    public class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<int,string> cricket = new SortedDictionary<int,string>();
            cricket.Add(100, "kohli");
            cricket.Add(99, "SACHIN");
            cricket.Add(96, "DHONI");
            cricket.Add(94, "GANGULY");
            cricket.Add(92, "ROHIT");
            cricket.Remove(92);
            int count = cricket.Count;
            Console.WriteLine(count);
            bool Containskey = cricket.ContainsKey(94);
            Console.WriteLine(Containskey);
            bool containsvalue = cricket.ContainsValue("DHONI");
            foreach(KeyValuePair<int,string> kvp in cricket)
            {
                Console.WriteLine(kvp);
                Console.ReadLine();
            }
        }
    }
}
