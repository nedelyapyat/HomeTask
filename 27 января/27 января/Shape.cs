using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27_january_shapes
{
    public class Shape
    {
        private string color;
        private int x, y;

        // Конструктор для инициализации полей
        public Shape(string color, int x, int y)
        {
            this.color = color;
            this.x = x;
            this.y = y;
        }

        // Сделаем метод Display виртуальным, чтобы его можно было переопределить
        public virtual void Display()
        {
            Console.WriteLine($"Color: {color}, Center: ({x}, {y})");
        }
    }
}