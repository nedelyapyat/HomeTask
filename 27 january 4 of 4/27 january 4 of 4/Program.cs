using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27_january_4_of_4
{
    class Program
    {
        static void Main()
        {
            Employee emp1 = new HourlyEmployee("Иван", 20, 160);
            Employee emp2 = new MonthlyEmployee("Анна", 3000);
            Employee emp3 = new ContractEmployee("Сергей", 5000);

            Console.WriteLine($"{emp1.Name} зарабатывает {emp1.CalculateSalary()} руб.");
            Console.WriteLine($"{emp2.Name} зарабатывает {emp2.CalculateSalary()} руб.");
            Console.WriteLine($"{emp3.Name} зарабатывает {emp3.CalculateSalary()} руб.");
            Console.ReadKey();
        }
    }
}
