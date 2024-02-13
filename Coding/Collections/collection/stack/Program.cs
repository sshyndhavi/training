using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stack
{
    public class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            int poppedelement = stack.Pop();
            Console.WriteLine(poppedelement);
            int peekelement = stack.Peek();
            Console.WriteLine(peekelement);
            int count = stack.Count();
            Console.WriteLine(count);
            bool contains = stack.Contains(1);
            Console.WriteLine(contains);
            bool isempty= stack.Count ==0;
            Console.WriteLine(isempty);
            int size = stack.Count();
            Console.WriteLine(size);
            Console.Read();
            
        }
          
         
    }
    
}
