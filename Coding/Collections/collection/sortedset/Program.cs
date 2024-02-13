using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sortedset
{
    public  class Program
    {
        static void Main(string[] args)
        {
            SortedSet<int> set1 = new SortedSet<int>();
            SortedSet<int> set2 = new SortedSet<int>();

            set1.Add(1);
            set1.Add(2);
            set1.Add(3);
            set1.Add(4);
            set2.Add(4);
            set1.Remove(2);
            int first = set1.First();
            Console.WriteLine(first);
            int last = set1.Last();
            Console.WriteLine(last);
            bool contains = set1.Contains(3);
            Console.WriteLine(contains);
            int count = set1.Count();
            Console.WriteLine(count);
            set1.UnionWith(set2);
            set1.IntersectWith(set2);

            foreach (int i in set1)
            {
                Console.WriteLine(i);
                Console.ReadLine();
            }
        }
    }
}
