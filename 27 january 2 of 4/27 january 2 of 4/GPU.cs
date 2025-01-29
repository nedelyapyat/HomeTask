using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27_january_2_of_4
{
    internal class GPU
    {
        public string Model { get; set; }
        public int Memory { get; set; } // в ГБ

        public GPU(string model, int memory)
        {
            Model = model;
            Memory = memory;
        }

        public void Initialize()
        {
            Console.WriteLine($"GPU {Model} с {Memory} ГБ памяти инициализирован.");
        }

        public void Disable()
        {
            Console.WriteLine("GPU отключен.");
        }
    }
}
