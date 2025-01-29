using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27_january_2_of_4
{
    internal class RAM
    {
        public int Size { get; set; } // в ГБ

        public RAM(int size)
        {
            Size = size;
        }

        public void Load()
        {
            Console.WriteLine($"Загружено {Size} ГБ оперативной памяти.");
        }

        public void Clear()
        {
            Console.WriteLine("Оперативная память очищена.");
        }
    }
}
