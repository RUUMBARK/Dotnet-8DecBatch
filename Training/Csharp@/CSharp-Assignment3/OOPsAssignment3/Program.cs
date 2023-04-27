using System;

namespace OOPsAssignment3
{
    class Program
    {   

        static void Main(string[] args)
        {
            Console.WriteLine("Enter employee details- ");
            Console.WriteLine("Emp No-");
            int empno = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Emp Name-");
            string empname  = Console.ReadLine();
            Console.WriteLine("Salary- ");
            double salary = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Kilometer you travel-");
            int km = Convert.ToInt32(Console.ReadLine());
            
            Employee emp = new Employee(empno, empname, salary);
            emp.info();

            Manager mn = new Manager(empno, empname, salary);
            mn.Calculategross();
            mn.CalculateSalary();
            mn.info();

            MarketingExecutive me = new MarketingExecutive(empno, empname, salary, km);
            me.Calculategross();
            me.CalculateSalary();
            me.info();
        }
    }
}
