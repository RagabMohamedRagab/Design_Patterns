using System;

namespace Adapter_Patterns.Entities
{
    public class Adapter:CalculateSalary
    {
        private SalaryDTO _dto;

        public Adapter()
        {
            _dto = new SalaryDTO();
        }

        public double AdapterCalculateSalary(SalaryShiftDto d) {
           _dto.Value=d.Value;
           return base.Calculate(_dto);
           
         }
    }
}
