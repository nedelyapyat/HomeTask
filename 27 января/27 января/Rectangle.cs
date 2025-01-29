using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27_january_shapes
{
    public class Rectangle : Shape
    {
        private double width, height; // Ширина и высота прямоугольника

        // Конструктор для инициализации параметров
        public Rectangle(string color, int x, int y, double width, double height) : base(color, x, y)
        {
            this.width = width;
            this.height = height;
        }

        // Переопределение метода Display для прямоугольника
        public override void Display()
        {
            base.Display(); // Выводим информацию из базового класса
            Console.WriteLine($"Width: {width}, Height: {height}"); // Дополнительная информация для прямоугольника
        }
    }
}
