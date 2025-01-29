using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27_january_shapes
{
    public class Circle : Shape
    {
        private double radius;

        
        public Circle(string color, int x, int y, double radius) : base(color, x, y)
        {
            this.radius = radius;
        }

        // Переопределение метода Display для круга
        public override void Display()
        {
            base.Display(); // Выводим информацию из базового класса
            Console.WriteLine($"Radius: {radius}"); // Дополнительная информация для круга
        }
    }
}
