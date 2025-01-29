using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27_january_3_of_4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Создаем объекты разных транспортных средств
            Vehicle car = new Car("Car");
            Vehicle bicycle = new Bicycle("Bicycle");
            Vehicle boat = new Boat("Boat");

            // Вызываем метод Drive для каждого объекта
            car.Drive();
            bicycle.Drive();
            boat.Drive();
            Console.ReadKey();
        }
    }
}
