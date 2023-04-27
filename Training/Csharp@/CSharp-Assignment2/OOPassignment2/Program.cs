using System;

namespace OOPassignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Emp Id : ");
            int id = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Emp name : ");
            string name = Console.ReadLine();

            Console.WriteLine("Enter Emp salary : ");
            double sal = Convert.ToDouble(Console.ReadLine());

            if (id == null || id <= 0 || name.Equals(null) ||  )
            {
                System.Console.WriteLine("Id cannot be null");
            }
            else if (name.Equals(null))
            {
                Console.WriteLine(" Name can not be null");
            }
            else if (sal == 0)
            {
                Console.WriteLine("Salary can not be zero");
            }
            else
            {
                Class1 e = new Class1(id, name, sal);
                e.CalculateSalary();
                e.displayDetails();

            }
        }
    }
}


