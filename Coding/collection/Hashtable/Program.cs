using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    public class Program
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();
            ht.Add(1, "ONE");
            ht.Add(2, "two");
            ht.Add(3, "three");
            ht.Remove(1);
            bool containskey = ht.ContainsKey(1);
            Console.WriteLine(containskey);
            bool containsvalue = ht.ContainsValue("two");
            Console.WriteLine(containsvalue);
            Hashtable copy = (Hashtable) ht.Clone();
            Console.WriteLine(copy);
            int count = ht.Count;
            Console.WriteLine(count);
            Console.ReadLine();
        }
    }
}
