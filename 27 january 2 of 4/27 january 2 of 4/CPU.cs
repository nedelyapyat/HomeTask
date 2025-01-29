using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27_january_2_of_4
{
    internal class CPU
    {
        public string Model { get; set; }
        public double Frequency { get; set; } // в ГГц

        public CPU(string model, double frequency)
        {
            Model = model;
            Frequency = frequency;
        }

        public void Start()
        {
            Console.WriteLine($"CPU {Model} запущен на {Frequency} ГГц.");
        }

        public void Shutdown()
        {
            Console.WriteLine("CPU выключен.");
        }
    }
}
