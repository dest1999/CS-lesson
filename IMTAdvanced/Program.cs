using System;

/* Написать программу, которая запрашивает массу и рост человека, вычисляет его индекс массы и сообщает, нужно ли человеку похудеть, набрать вес или всё в норме
 *          *Рассчитать, на сколько кг похудеть или сколько кг набрать для нормализации веса
 *  
 * coded by Олег Саврик
 */

namespace IMTAdvanced
{
    class Program
    {
        static void Main(string[] args)
        {
            float m, I, h;

            Console.Write("Программа для вычисления индекса массы тела.\nВведите рост в см.: ");
            h = float.Parse(Console.ReadLine()) / 100;
            Console.Write("Введите вес в килограммах: ");
            m = float.Parse(Console.ReadLine());
            I = m / (h * h);
            Console.WriteLine($"Ваш ИМТ: {I:F1}");
            Console.ReadKey();


        }
    }
}
