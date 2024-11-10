using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите координаты окружности:");
            Console.Write("Введите радиус окружности: ");
            double r = double.Parse(Console.ReadLine());
            Console.Write("Введите координаты цента окружности x0 = ");
            double x0 = double.Parse(Console.ReadLine());
            Console.Write("Введите координаты цента окружности y0 = ");
            double y0 = double.Parse(Console.ReadLine());
            Console.Write("Введите координаты точки  x = ");
            double x = double.Parse(Console.ReadLine());
            Console.Write("Введите координаты точки  y = ");
            double y = double.Parse(Console.ReadLine());

            double square = Circle.GetSquare(r);
            double length = Circle.GetLength(r);
            bool affiliation = Circle.GetAffiliation(r, x0, y0,x,y);

            Console.WriteLine("Площадь круга по заданному радиусу равна {0:f2}", square);
            Console.WriteLine("Длину окружности по заданному радиусу равна {0:f2}", length);
            Console.WriteLine(affiliation == true ? "точка принадлежит кругу": "точка не принадлежит кругу");
            Console.ReadKey();
        }
    }
}
