using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentChallenge.Modelo
{
    internal interface IOldEmployee
    {
        public double SalaryAdjustment(double salary, double percentualAdjust);
    }
}
