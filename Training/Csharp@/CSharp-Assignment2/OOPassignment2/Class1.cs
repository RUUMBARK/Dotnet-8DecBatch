using System;
using System.Collections.Generic;
using System.Text;

namespace OOPassignment2
{
    class Class1
    {
        private int EmpNo;
        private string EmpName;
        private double Salary;
        private double HRA;
        private double TA;
        private double DA;
        private double PF;
        private double TDS;
        private double NetSalary;
        private double GrossSalary;

        public Class1 ( int EmpNo, string EmpName, double Salary)
        {
            this.EmpNo = EmpNo;
            this.EmpName = EmpName;
            this.Salary = Salary;
        }

        public void CalculateSalary()
        {

            if (this.Salary < 5000)
            {
                this.GrossSalary = (this.Salary + (this.Salary * 10 / 100) + (this.Salary * 5 / 100) + (this.Salary * 15 / 100));
                this.PF = this.GrossSalary * 10 / 100;
                this.TDS = this.GrossSalary * 18 / 100;
                this.NetSalary = this.GrossSalary - (this.PF + this.TDS);
            }
            else if (this.Salary < 10000)
            {
                this.GrossSalary = (this.Salary + (this.Salary * 15 / 100) + (this.Salary * 10 / 100) + (this.Salary * 20 / 100));
                this.PF = this.GrossSalary * 10 / 100;
                this.TDS = this.GrossSalary * 18 / 100;
                this.NetSalary = this.GrossSalary - (this.PF + this.TDS);
            }



            else if (this.Salary < 15000)
            {
                this.GrossSalary = (this.Salary + (this.Salary * 20 / 100) + (this.Salary * 15 / 100) + (this.Salary * 25 / 100));
                this.PF = this.GrossSalary * 10 / 100;
                this.TDS = this.GrossSalary * 18 / 100;
                this.NetSalary = this.GrossSalary - (this.PF + this.TDS);
            }



            else if (this.Salary < 20000)
            {
                this.GrossSalary = (this.Salary + (this.Salary * 20 / 100) + (this.Salary * 25 / 100) + (this.Salary * 30 / 100));
                this.PF = this.GrossSalary * 10 / 100;
                this.TDS = this.GrossSalary * 18 / 100;
                this.NetSalary = this.GrossSalary - (this.PF + this.TDS);
            }



            else if (this.Salary >= 20000)
            {
                this.GrossSalary = (this.Salary + (this.Salary * 20 / 100) + (this.Salary * 25 / 100) + (this.Salary * 35 / 100));
                this.PF = this.GrossSalary * 10 / 100;
                this.TDS = this.GrossSalary * 18 / 100;
                this.NetSalary = this.GrossSalary - (this.PF + this.TDS);
            }
            else
            {
                System.Console.WriteLine("You entered wrong details");
            }
        }



        public void displayDetails()
        {
            System.Console.WriteLine("Id : " + this.EmpNo + "\nEmployee Name : " + this.EmpName + "\nSalary : " + this.Salary + "\nGross Salary : " + this.GrossSalary + "\nNet Salary : " + this.NetSalary);
        }



    }
}
 


        
