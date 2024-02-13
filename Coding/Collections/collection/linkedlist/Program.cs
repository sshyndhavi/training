using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linkedlist
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> list = new LinkedList<int>();
            list.AddFirst(1);
            list.AddFirst(2);
            list.AddFirst(3);
            list.AddFirst(4);
            list.AddLast(5);
            list.AddLast(6);
            list.Remove(4);
            list.RemoveFirst();
            list.RemoveLast();
            bool contains = list.Contains(1);
            Console.WriteLine(contains);
            int count = list.Count;
            Console.WriteLine(count);
            foreach (int i in list)
            {
                Console.WriteLine(i);
                Console.ReadLine();
            }

        }
    }
}
