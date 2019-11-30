using System;

/* Написать программу, которая запрашивает массу и рост человека, вычисляет его индекс массы и сообщает, нужно ли человеку похудеть, набрать вес или всё в норме
 *          *Рассчитать, на сколько кг похудеть или сколько кг набрать для нормализации веса
 *          
 *  16 и менее               Выраженный дефицит массы тела 
 *  16—18,5                  Недостаточная (дефицит) масса тела 
 *  18,5—24,99               Норма 
 *  25—30                    Избыточная масса тела (предожирение) 
 *  30—35                    Ожирение 
 *  35—40                    Ожирение резкое 
 *  40 и более               Очень резкое ожирение 
 *  
 * coded by Олег Саврик
 */

namespace IMTAdvanced
{
    class Program
    {
        static int CalculateDeltaM(double normalIndex, double h, double i)
        {
            return (int)Math.Round(Math.Abs(Math.Pow(h, 2) * (i - normalIndex)));
        }

        static void Main(string[] args)
        {
            double weight, height, indexOfMass;
            const double
                anorexy = 16,
                minNormalIndex = 18.5,
                maxNormalIndex = 24.99,
                almostFat = 25,
                fat = 30,
                veryFat = 35,
                uglyFat = 40;

            Console.Write("Программа для вычисления индекса массы тела.\nВведите рост в см.: ");
            height = float.Parse(Console.ReadLine()) / 100;
            Console.Write("Введите вес в килограммах: ");
            weight = float.Parse(Console.ReadLine());
            indexOfMass = weight / (height * height);
            Console.WriteLine($"Ваш ИМТ: {indexOfMass:F1}");

            if (indexOfMass < anorexy)
            {
                Console.WriteLine($"Выраженный дефицит массы тела, необходимо нарастить массу на {CalculateDeltaM(minNormalIndex, height, indexOfMass)} кг.");
            }
            else if (indexOfMass >= anorexy && indexOfMass < minNormalIndex)
            {
                Console.WriteLine($"Недостаточная (дефицит) масса тела, необходимо нарастить массу на {CalculateDeltaM(minNormalIndex, height, indexOfMass)} кг.");
            }
            else if (indexOfMass >= minNormalIndex && indexOfMass <= maxNormalIndex)
            {
                Console.WriteLine("Норма");
            }
            else if (indexOfMass >= almostFat && indexOfMass < fat)
            {
                Console.WriteLine($"Избыточная масса тела (предожирение), необходимо сбросить массу на {CalculateDeltaM(maxNormalIndex, height, indexOfMass)} кг.");
            }
            else if (indexOfMass >= fat && indexOfMass < veryFat)
            {
                Console.WriteLine($"Ожирение, необходимо сбросить массу на {CalculateDeltaM(maxNormalIndex, height, indexOfMass)} кг.");
            }
            else if (indexOfMass >= veryFat && indexOfMass < uglyFat)
            {
                Console.WriteLine($"Ожирение резкое, необходимо сбросить массу на {CalculateDeltaM(maxNormalIndex, height, indexOfMass)} кг.");
            }
            else if (indexOfMass >= uglyFat)
            {
                Console.WriteLine($"Очень резкое ожирение, необходимо сбросить массу на {CalculateDeltaM(maxNormalIndex, height, indexOfMass)} кг.");
            }
            Console.ReadKey();
        }
    }
}
