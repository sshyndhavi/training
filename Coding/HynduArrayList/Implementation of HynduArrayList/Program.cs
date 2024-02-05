using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingMyArrayList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HynduArraylist<int> list = new HynduArraylist<int>();
            list.Insertfirst(10);
            list.Insertfirst(20);
            list.Insertfirst(30);
            list.Insertlast(50);
            list.Insertlast(5);
            list.RemoveFirst(30);
            list.RemoveLast(5);


            list.Print();

            Console.WriteLine("\nTotal elements in the list are : ");
            int totalEle = list.Count();
            Console.WriteLine(totalEle);

            Console.ReadLine();

        }
    }
}