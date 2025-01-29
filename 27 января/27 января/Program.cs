using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27_january_shapes
{
    public class Program
    {
        static void Main()
        {
            // Создаем объекты разных фигур
            Shape circle = new Circle("Red", 0, 0, 5);
            Shape rectangle = new Rectangle("Blue", 2, 3, 4, 6);
            Shape triangle = new Triangle("Green", 1, 1, 3, 4, 5);

            // Выводим информацию о каждой фигуре
            circle.Display();
            rectangle.Display();
            triangle.Display();
            Console.ReadKey();
        }
    }
}
