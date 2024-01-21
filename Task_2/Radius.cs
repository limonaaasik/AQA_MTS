using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    internal class Radius
    {
        public delegate double Calculate(double x);

        public double CircleLength(double radius)
        {
            double length = 2 * Math.PI * radius;
            Console.WriteLine($"Длина окружности: {length}");
            return length;
        }
        public double CircleSquare(double radius)
        {
            double square = Math.PI* Math.Pow(radius, 2);
            Console.WriteLine($"Площадь круга: {square}");
            return square;
        }
        public double VolumeBall(double radius)
        {
            double volume = 4d / 3 * Math.PI * Math.Pow(radius, 3); // d - double, указала, что число с плавающей точкой
            Console.WriteLine($"Объем шара: {volume}");
            return volume;
        }

    }
}
