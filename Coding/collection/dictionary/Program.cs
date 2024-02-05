using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dictionary
{
    public class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> cricket = new Dictionary<int, string>();
            cricket.Add(100, "kohli");
            cricket.Add(99, "Dhoni");
            cricket.Add(98, "sachin");
            cricket.Add(97, "risabh");
            cricket.Add(96, "gambhir");
            cricket.Remove(99);
            bool containskey = cricket.ContainsKey(100);
            Console.WriteLine(containskey);
            bool ContainsValue = cricket.ContainsValue("96");
            Console.WriteLine(ContainsValue);
            int count = cricket.Count();
            Console.WriteLine(count);
            foreach(KeyValuePair<int, string> kvp in cricket)
            {
                Console.WriteLine(kvp+"");
                Console.ReadLine();
            }

                    
        }
    }
}
