using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27_january_shapes
{
    public class Triangle : Shape
    {
        private double sideA, sideB, sideC; // Длины сторон треугольника

        // Конструктор для инициализации параметров
        public Triangle(string color, int x, int y, double sideA, double sideB, double sideC) : base(color, x, y)
        {
            this.sideA = sideA;
            this.sideB = sideB;
            this.sideC = sideC;
        }

        // Переопределение метода Display для треугольника
        public override void Display()
        {
            base.Display(); // Выводим информацию из базового класса
            Console.WriteLine($"Sides: {sideA}, {sideB}, {sideC}"); // Дополнительная информация для треугольника
        }
    }
}
