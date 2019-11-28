using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xyLenght
{
    class XYLength
    {
        static double LengthBetweenXY (double innerX1, double innerX2, double innerY1, double innerY2)
        {
            return Math.Sqrt(Math.Pow(innerX2 - innerX1, 2) + Math.Pow(innerY2 - innerY1, 2));
        }

        static void Main(string[] args)
        {
            double x1, x2, y1, y2;
            Console.Write("Введите координату x1: ");
            x1 = double.Parse(Console.ReadLine());
            Console.Write("Введите координату y1: ");
            y1 = double.Parse(Console.ReadLine());
            Console.Write("Введите координату x2: ");
            x2 = double.Parse(Console.ReadLine());
            Console.Write("Введите координату y2: ");
            y2 = double.Parse(Console.ReadLine());

            /* Это вычисление выведено в отдельный метод, теперь переменная r не нужна
            r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            */
            Console.WriteLine($"Расстояние между точками: {LengthBetweenXY(x1, x2, y1, y2):f2}");

            Console.ReadKey();
        }
    }
}
