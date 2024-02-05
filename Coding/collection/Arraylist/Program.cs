using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace collection
{
    public class Program
    {
        static void Main(string[] args)
        {
            ArrayList al = new ArrayList();
            al.Add(1);
            al.Add(2);
            al.Add(3);
            al.Add(4);
            al.Add(5);
            al.Remove(1);
            al.RemoveAt(0);
            bool contains = al.Contains(1);
            Console.WriteLine(contains);
            int index = al.IndexOf(5);
            Console.WriteLine(index);
            al.Insert(0, 0);
            int count = al.Count;
            Console.WriteLine(count);
            object[]  arr = al.ToArray();
            Console.WriteLine(arr);
             /*int sort = al.Sort();
            Console.WriteLine(sort);
            int reverse = al.Reverse();
            Console.WriteLine(reverse);*/
            foreach (int i in al)
            {
                Console.WriteLine(i);
            }
        }
    }
}
