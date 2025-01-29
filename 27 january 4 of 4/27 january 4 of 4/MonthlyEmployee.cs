using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27_january_4_of_4
{
    class MonthlyEmployee : Employee
    {
        private double monthlySalary;

        public MonthlyEmployee(string name, double monthlySalary) : base(name)
        {
            this.monthlySalary = monthlySalary;
        }

        public override double CalculateSalary()
        {
            return monthlySalary;
        }
    }
}
