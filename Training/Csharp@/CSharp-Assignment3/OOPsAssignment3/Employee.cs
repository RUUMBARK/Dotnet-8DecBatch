using System;
using System.Collections.Generic;
using System.Text;

namespace OOPsAssignment3
{

    interface IPrintable
    {
        void info();
    }
    class Employee:IPrintable
    {
        int empno;
        string empname;
        double salary;
        double pf;
        double tds;
        double netsalary;
        double grosssalary;

        public Employee(int empno, string empname, double salary)
        {
            this.empno = empno;
            this.empname = empname;
            this.salary = salary;
        }

        public virtual void Calculategross ()
        {
            if (this.salary < 5000)
            {
                this.grosssalary = this.salary + (this.salary * 10 / 100) + (this.salary * 5 / 100) + (this.salary * 15 / 100);
            }

            else if (this.salary < 10000)
            {
                this.grosssalary = this.salary + (this.salary * 15 / 100) + (this.salary * 10 / 100) + (this.salary * 20 / 100);
            }

            else if (this.salary < 15000)
            {
                this.grosssalary = this.salary + (this.salary * 20 / 100) + (this.salary * 15 / 100) + (this.salary * 25 / 100);
            }

            else if (this.salary < 20000)
            {
                this.grosssalary  = this.salary + (this.salary * 25 / 100) + (this.salary * 20 / 100) + (this.salary * 30 / 100);
            }

            else if (this.salary <= 20000)
            {
                this.grosssalary = this.salary + (this.salary * 30 / 100) + (this.salary * 25 / 100) + (this.salary * 35 / 100);
            }
        }
        public virtual void CalculateSalary()
        {
            pf = grosssalary / 10;
            tds = grosssalary / 18;
            netsalary = grosssalary - (pf + tds);
        }

        public void info()
        {
            System.Console.WriteLine("The Emp No is " + empno + "The Emp Name is " + empname + "The Salary is " + salary);
        }
    }
}
