using System;
using Adapter_Patterns.Entities;

namespace Adapter_Patterns
{
    public class Program
    {
        private static void Main(string[] args)
        {
            CalculateSalary cal = new CalculateSalary();
            SalaryDTO Salary = new SalaryDTO();
            Salary.Name = "Ragab";
            Salary.Value = 1000;
            var result = cal.Calculate(Salary);
            System.Console.WriteLine(result);
            SalaryShiftDto Salaryshift = new SalaryShiftDto();
            Salaryshift.Name = "Ragab";
            Salaryshift.Value = 1000;
            var result2 = new Adapter().AdapterCalculateSalary(Salaryshift);
            System.Console.WriteLine(result2);
        }
    }
}
