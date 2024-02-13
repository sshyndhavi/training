using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUEUE
{
    public class Program
    {
        static void Main(string[] args)
        {
            Queue<string> queue = new Queue<string>();
            queue.Enqueue("A");
            queue.Enqueue("B");
            queue.Enqueue("C");
            queue.Enqueue("D");
            string removed= queue.Dequeue();
            Console.WriteLine(removed);
            bool contains = queue.Contains("A");
            Console.WriteLine(contains);
            int count = queue.Count();
            Console.WriteLine(count);
            bool empty = queue.Count ==null;
            Console.WriteLine(empty);
            string peekelement = queue.Peek();
            Console.WriteLine(peekelement);
            Console.ReadLine();
         
        }
    }
}
