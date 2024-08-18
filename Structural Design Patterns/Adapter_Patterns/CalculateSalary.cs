using System;
using Adapter_Patterns.Entities;
namespace Adapter_Patterns
{
    public class CalculateSalary
    {
        public double Calculate(SalaryDTO obj) => obj.Value * 1.5;
    }
}
