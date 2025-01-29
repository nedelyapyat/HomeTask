using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27_january_3_of_4
{
    public class Vehicle
    {
        public string Name { get; set; } // Свойство для названия транспортного средства

        public Vehicle(string name)
        {
            Name = name;
        }

        // Виртуальный метод Drive
        public virtual void Drive()
        {
            Console.WriteLine($"{Name} is moving...");
        }
    }
}
