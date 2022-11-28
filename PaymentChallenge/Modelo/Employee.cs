using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace PaymentChallenge.Modelo
{
    public class Employee
    {
        public string Name { get; set; }
        public string Job { get; set; }

        public int YearHired { get; set; }

        public double Salary { get; set; }


        public Employee() { }

        public Employee(string name, string job, double salary, int yearhired)
        {
            Name = name;
            Job = job;
            YearHired = yearhired;
            Salary = salary;
        }

    }
}



