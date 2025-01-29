using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27_january_4_of_4
{
    class ContractEmployee : Employee
    {
        private double contractAmount;

        public ContractEmployee(string name, double contractAmount) : base(name)
        {
            this.contractAmount = contractAmount;
        }

        public override double CalculateSalary()
        {
            return contractAmount;
        }
    }
}
