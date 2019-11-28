using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace imt
{
    class WeightIndex
    {
        static void Main(string[] args)
        {
            float m, I, h;
            
            Console.Write("Программа для вычисления индекса массы тела.\nВведите рост в метрах: ");
            h = float.Parse(Console.ReadLine());
            Console.Write("Введите вес в килограммах: ");
            m = float.Parse(Console.ReadLine());
            I = m / (h * h);
            Console.WriteLine($"Ваш ИМТ: {I:F1}");
            Console.ReadKey();
            

        }
    }
}
