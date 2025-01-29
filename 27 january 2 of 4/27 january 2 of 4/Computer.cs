using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27_january_2_of_4
{
    internal class Computer
    {
        private CPU cpu;
        private RAM ram;
        private GPU gpu;

        public Computer(CPU cpu, RAM ram, GPU gpu)
        {
            this.cpu = cpu;
            this.ram = ram;
            this.gpu = gpu;
        }

        public void PowerOn()
        {
            Console.WriteLine("Включение компьютера...");
            cpu.Start();
            ram.Load();
            gpu.Initialize();
            Console.WriteLine("Компьютер включен и готов к работе.");
        }

        public void PowerOff()
        {
            Console.WriteLine("Выключение компьютера...");
            gpu.Disable();
            ram.Clear();
            cpu.Shutdown();
            Console.WriteLine("Компьютер выключен.");
        }
    }
}
