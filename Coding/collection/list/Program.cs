using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace list
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();
            list.Add("Apple");
            list.Add("orange");
            list.Add("kiwi");
            list.Add("banana");
            list.Add("mango");
            list.Remove("mango");
            bool Contains = list.Contains("mango");
            int Index = list.IndexOf("Apple");
            list.Insert(1,"cherry");
            list.Sort();
            Console.WriteLine(Index);
            Console.WriteLine(Contains);
            
            foreach (string item in list)
            {
                Console.Write(item);
                Console.ReadLine();

            }

        }
    }
}
