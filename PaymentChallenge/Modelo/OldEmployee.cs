using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentChallenge.Modelo
{
    public class OldEmployee : Employee, IOldEmployee
    {
        public double PercentualAdjust { get; set; }

        public double SalaryAdjustment(double salary, double percentualAdjust)
        {
            this.PercentualAdjust = percentualAdjust;
            return this.Salary = salary + (salary * percentualAdjust/100); 
        }
 
    }
 
}
