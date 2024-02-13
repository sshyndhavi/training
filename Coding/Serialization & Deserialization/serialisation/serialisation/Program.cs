using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace serialisation
{
    [Serializable]
    public class Student
    {
        int rollno;
        string name;
        public Student(int rollno, string name) 
        { 
            rollno  = 1;
            name = "john";
        }

    }

    public  class Program
    {
        public static void Main(string[] args)
        {
            FileStream stream = new FileStream("program.bin", FileMode.OpenOrCreate);
            BinaryFormatter formatter = new BinaryFormatter();
            Student s = new Student(1,"john");
            formatter.Serialize(stream, s);
            stream.Close();
            Console.ReadLine();
 
        }
        
    }
}
