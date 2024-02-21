using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
     public interface IShape 
     {
         double Area();
     }
     public class Circle : IShape
    {
        private double radius;
        public Circle(double radius)
        {
            this.radius = radius;
        }

        public double Area() 
        { 
            return Math.PI * radius*radius; 
        }
     }
    
      public  class Program
      {
        static void Main(string[] args)
        {
            IShape shape = new Circle(10);
            Console.WriteLine(shape.Area());
        }
      }
}

