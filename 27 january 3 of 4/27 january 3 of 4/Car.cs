using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27_january_3_of_4
{
    public class Car : Vehicle
    {
        public Car(string name) : base(name) { }

        public override void Drive()
        {
            Console.WriteLine($"{Name} is driving on the road.");
        }
    }
}
