using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheiratance
{
    internal class Employee
    {
        public string name { get; set; }
        public string employeeid { get; }
        public Employee(string name, string employeeid)
        {
            this.name = name;
            this.employeeid = employeeid;
        }
    }
    internal class Manager : Employee
    {
        string departement { get; set; }
        private double salary { get; }
        public Manager(string name, string employeeid, string departement, double salary) : base(name, employeeid)
        {
            this.departement = departement;
            this.salary = salary;
        }

        public void employeeInfo()
        {
            Console.WriteLine(name+" "+employeeid+" "+departement+" "+salary);
        }

    }
}
