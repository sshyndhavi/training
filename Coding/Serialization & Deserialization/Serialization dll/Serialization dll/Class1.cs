using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Serialization_dll
{
   [Serializable]
    class Student
    {
        int rollno;
        string name;
        public Student(int rollno, string name)
        {
            this.rollno = rollno;
            this.name = name;
        }
    }
    public class SerializeExample
    {
       public static void serializationMethod()
        {
            FileStream stream = new FileStream("program.bin", FileMode.OpenOrCreate);
            BinaryFormatter formatter = new BinaryFormatter();

            Student s = new Student(101, "sonoo");
            formatter.Serialize(stream, s);

            Console.WriteLine("Serialization done");
            Console.Read();
            stream.Close();
        }
    }
}


