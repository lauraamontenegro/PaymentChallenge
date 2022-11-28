using System;
using System.Collections.Generic;
using PaymentChallenge.Modelo;
using System.Globalization;
namespace PaymentChallenge

{
    public class Program
    {
        public static object SalaryAdjustment { get; private set; }
        public static int YearHired { get; private set; }

        static void Main(string[] args)

        {
            OldEmployee oldEmployee = new OldEmployee();             

            Console.WriteLine("Digite o seu nome");
            oldEmployee.Name = Console.ReadLine();
            Console.WriteLine("Digite o seu cargo");
            oldEmployee.Job = Console.ReadLine();
            Console.WriteLine("Digite o ano de contratação");
            int yearHired = oldEmployee.YearHired = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o seu salário");
            double salary = oldEmployee.Salary =  double.Parse(Console.ReadLine());
            Console.WriteLine("Digite ENTER para encerrar.");


            if (salary > 7000 && yearHired <= 2019)
            {
                Console.WriteLine("Você irá receber um aumento de 10%.");
                double percentualAdjust = oldEmployee.PercentualAdjust = 10;
                Console.WriteLine("Aperte ENTER para ver o seu novo salário");               
                Console.ReadLine();
                oldEmployee.SalaryAdjustment(salary, percentualAdjust);
                Console.WriteLine($"Seu novo salário é de: {oldEmployee.Salary}");
                Console.Read();
            }
            else if (salary < 7000 && yearHired <= 2019)
            {
                Console.WriteLine("Qual será a % do reajuste?");
                double percentualAdjust = oldEmployee.PercentualAdjust = double.Parse(Console.ReadLine());
                Console.WriteLine("Aperte ENTER para ver o seu novo salário");
                Console.ReadLine();
                oldEmployee.SalaryAdjustment(salary, percentualAdjust);
                Console.WriteLine($"Seu novo salário é de: {oldEmployee.Salary}");
                Console.Read();
            }
            else
            {
                Console.WriteLine("Você não tem reajuste!");
                Console.ReadLine();
            }

        }


    }
}
