using System;
using System.Collections.Generic;
using System.Text;

namespace OOPsAssignment3
{
    class MarketingExecutive : Employee,IPrintable
    {
        int empno;
        string empname;
        double salary;
        double km_travel;
        double tour_allowance;
        double tele_allowance;
        double grosssalary;
        double pf;
        double tds;
        double netsalary;

        public MarketingExecutive(int empno, string empname, double salary, double km_travel) : base(empno, empname, salary)
        {
            this.empno = empno;
            this.empname = empname;
            this.salary = salary;
            this.km_travel = km_travel;
        }

        public override void Calculategross()
        {
            base.Calculategross();
            tour_allowance = 5 * this.km_travel;
            tele_allowance = 1000;

            grosssalary = this.grosssalary + tour_allowance + tele_allowance;
        }

        public override void CalculateSalary()
        {
            pf = grosssalary / 10;
            tds = grosssalary / 18;
            netsalary = grosssalary - (pf + tds);
        }

        public void info()
        {
            Console.WriteLine("Marketing Executive detail are- ");
            Console.WriteLine("Marketing Executive id- {0}", empno);
            Console.WriteLine("Marketing Executive Name- " + empname);
            Console.WriteLine("Marketing Executive Salary- {0}", salary);
            Console.WriteLine("Kilometer Employee travel- {0} ", km_travel);
            Console.WriteLine("Marketing Executive GrossSalary- {0}", grosssalary);
            Console.WriteLine("Marketing Executive Net Salary- {0}", netsalary);
        }
    }
}

