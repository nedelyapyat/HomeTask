using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27_january_4_of_4
{
    class HourlyEmployee : Employee
    {
        private double hourlyRate;
        private int hoursWorked;

        public HourlyEmployee(string name, double hourlyRate, int hoursWorked) : base(name)
        {
            this.hourlyRate = hourlyRate;
            this.hoursWorked = hoursWorked;
        }

        public override double CalculateSalary()
        {
            return hourlyRate * hoursWorked;
        }
    }
}
