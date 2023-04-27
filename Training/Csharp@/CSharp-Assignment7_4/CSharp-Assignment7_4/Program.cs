using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace CSharp_Assignment7_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\RUUMBARK\source\repos\CSharp-Assignment7_4\Text.txt";
            Employee emp = new Employee(003, "Ruchita", 20000);
            FileStream stream = new FileStream(path, FileMode.OpenOrCreate);
            BinaryFormatter bf = new BinaryFormatter();


            bf.Serialize(stream, emp);
            stream.Close();
            Console.WriteLine(" File created successfully -> " + path);


            FileStream stream1 = new FileStream(path, FileMode.Open, FileAccess.Read);
            Employee objnew = (Employee)bf.Deserialize(stream1);

            Console.WriteLine(objnew.id);
            Console.WriteLine(objnew.name);
            Console.WriteLine(objnew.salary);

        }
    }
}
