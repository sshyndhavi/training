using System;
using System.Collections.Generic;

namespace collections
{
    class Program
    {
        public static void Main(string[] args)
        {
            HashSet<int> numbers1 = new HashSet<int>();
            HashSet<int> numbers2 = new HashSet<int>();

            numbers1.Add(1);
            numbers1.Add(2);
            numbers1.Add(3);
            numbers2.Add(2);
            numbers1.Remove(3);
            bool contains = numbers1.Contains(1);
            Console.WriteLine(contains);
            int count = numbers1.Count;
            Console.WriteLine(count);
            numbers1.UnionWith(numbers2);
            numbers2.IntersectWith(numbers1);
            foreach(int i in numbers1)
            {
                Console.Write(i);
                Console.ReadLine();

            }
           


        }

    }
}
