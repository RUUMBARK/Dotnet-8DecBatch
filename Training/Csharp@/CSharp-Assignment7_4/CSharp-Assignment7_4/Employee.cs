using System;
using System.Collections.Generic;
using System.Text;


namespace CSharp_Assignment7_4
{
    [Serializable]
    class Employee
    {
        public int id;
        public string name;
        public double salary;

        public Employee(int Id, string Name, double Salary)
        {
            this.id = Id;
            this.name = Name;
            this.salary = Salary;
        }


    }
}