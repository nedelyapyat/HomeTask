using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27_january_2_of_4
{
    internal class Program
    {
        static void Main()
        {
            CPU myCPU = new CPU("Intel Core i7", 3.5);
            RAM myRAM = new RAM(16);
            GPU myGPU = new GPU("NVIDIA RTX 3060", 8);

            Computer myComputer = new Computer(myCPU, myRAM, myGPU);

            myComputer.PowerOn();
            Console.WriteLine();
            myComputer.PowerOff();
            Console.ReadKey();
        }
    }
}
