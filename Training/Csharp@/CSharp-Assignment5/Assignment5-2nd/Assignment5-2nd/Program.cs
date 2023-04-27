using System;

namespace Assignment5_2nd
{
    class Program
    {
        static void Main(string[] args)
        {
            int Id;
            string Name;
            double Salary;
            Console.WriteLine("Enter the count of employees you want to enter");
            int n = Convert.ToInt32(Console.ReadLine());
            arraylist EmployeeList = new arraylist();
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter id");
                Id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Name");
                Name  = Console.ReadLine();
                Console.WriteLine("Enter Salary");
                Salary = Convert.ToDouble(Console.ReadLine());
                EmployeeList.Add(new Employee(Id, Name, Salary));
            }
        }
    }
}
