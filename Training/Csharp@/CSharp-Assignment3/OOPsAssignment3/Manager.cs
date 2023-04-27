using System;
using System.Collections.Generic;
using System.Text;

namespace OOPsAssignment3
{
    class Manager : Employee,IPrintable
    {
        int empno;
        string empname;
        double salary;
        double pf;
        double tds;
        double netsalary;
        double grosssalary;
        double Petrol_allowance;
        double Food_allowance;
        double Other_allowance;

        public Manager(int empno, string empname, double salary):base(empno,empname,salary)
        {
            this.empno = empno;
            this.empname = empname;
            this.salary = salary;
        }
        public new void Calculategross()
        {
            base.Calculategross();
            Petrol_allowance = (this.salary * 8) / 100;
            Food_allowance = (this.salary * 13) / 100;
            Other_allowance = (this.salary * 3) / 100;
            grosssalary = Petrol_allowance + Food_allowance + Other_allowance + this.grosssalary;
        }

        public override void CalculateSalary()
        {
            pf = grosssalary / 10;
            tds = grosssalary / 18;
            netsalary = grosssalary - (pf + tds);
        }
        public void info()
        {
            Console.WriteLine(" Manager detail are- ");
            Console.WriteLine("Manager id- {0}", empno);
            Console.WriteLine("Manager Name- " + empname);
            Console.WriteLine("Manager Salary- {0}", salary);
            Console.WriteLine("Manager GrossSalary- {0}", grosssalary);
            Console.WriteLine(" Manager Net Salary- {0}", netsalary);
        }
    }
}
