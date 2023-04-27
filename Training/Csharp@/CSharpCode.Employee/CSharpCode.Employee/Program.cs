using System;

namespace CSharpCode.Employee
{
    class Employee
    {

        int EmpNo;
        string EmpName;
        double Salary;
        double HRA;
        double TA;
        double DA;
        double PF;
        double TDS;
        double NetSalary;
        double GrossSalary;

        public void employeeDetails(int EmpNo, string EmpName, double Salary)
        {
            this.EmpNo = EmpNo;
            this.EmpName = EmpName;
            this.Salary = Salary;
        }
        public double Calculate()
        {
            if (Salary < 5000)
            {
                HRA = 0.10 * Salary;
                TA = 0.5 * Salary;
                DA = 0.15 * Salary;
                GrossSalary = Salary + HRA + TA + DA;
                return GrossSalary;
            }
            else if (Salary >= 5000 && Salary < 10000)
            {
                HRA = 0.15 * Salary;
                TA = 0.10 * Salary;
                DA = 0.20 * Salary;
                GrossSalary = Salary + HRA + TA + DA;
                return GrossSalary;
            }
            else if (Salary >= 10000 && Salary < 15000)
            {
                HRA = 0.20 * Salary;
                TA = 0.15 * Salary;
                DA = 0.25 * Salary;
                GrossSalary = Salary + HRA + TA + DA;
                return GrossSalary;
            }
            else if (Salary >= 15000 && Salary < 20000)
            {
                HRA = 0.25 * Salary;
                TA = 0.20 * Salary;
                DA = 0.30 * Salary;
                GrossSalary = Salary + HRA + TA + DA;
                return GrossSalary;
            }
            else if  (Salary >= 20000)
            {
                HRA = 0.30 * Salary;
                TA = 0.25 * Salary;
                DA = 0.35 * Salary; GrossSalary = Salary + HRA + TA + DA;
                return GrossSalary;
            }
            else
            {
                Console.WriteLine("Check the Salary");
                return -1;
            }
        }
        public double CalSalary()
        {
            PF = 0.10 * GrossSalary;
            TDS = 0.18 * GrossSalary;
            NetSalary = GrossSalary - (PF = TDS);
            return NetSalary;
        }
    }  
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            
            Console.WriteLine("Enter Employee No. :");
            int EmpNo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Employee Name: ");
            string EmpName = Console.ReadLine();
            Console.WriteLine("Enter Salary: ");
            double Salary = Convert.ToDouble(Console.ReadLine());

            emp.employeeDetails(EmpNo, EmpName, Salary);
            Console.WriteLine($"The GrossSalary of employee: {emp.Calculate()} ");
            Console.WriteLine($"The NetSalary of employee: {emp.CalSalary()}");

            Console.ReadLine();
        }
    }
}
