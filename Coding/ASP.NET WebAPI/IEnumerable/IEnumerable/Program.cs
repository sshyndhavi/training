using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Collections
{
    public  class Program
    {
        public static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3 };
            IEnumerable enumerable = numbers;
            IEnumerator enumerator = enumerable.GetEnumerator();
            while(enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current);
                Console.ReadLine();
            }
        }
    }
}
