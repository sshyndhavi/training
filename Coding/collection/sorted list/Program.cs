using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sorted_list
{
    public class Program
    {
        static void Main(string[] args)
        {
            SortedList<int, string> sortedlist = new SortedList<int, string>();
            sortedlist.Add(1, "one");
            sortedlist.Add(2, "two");
            sortedlist.Add(3, "three");
            sortedlist.Add(4, "four");
            sortedlist.Remove(1);
            bool containskey = sortedlist.ContainsKey(2);
            Console.WriteLine(containskey);

            bool containsvalue = sortedlist.ContainsValue("three");
            Console.WriteLine(containsvalue);

            int indexkey = sortedlist.IndexOfKey(4);
            Console.WriteLine(indexkey);

            int indexvalue = sortedlist.IndexOfValue("two");
            ICollection<int> keys = sortedlist.Keys;
            ICollection<string> values = sortedlist.Values;
            foreach (KeyValuePair<int, string> kp in sortedlist)
            {
                Console.WriteLine(kp.Key + " " + kp.Value);

            }
            Console.Read();        }
    }
}
