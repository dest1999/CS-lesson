using System;

/*Написать метод, возвращающий минимальное из трёх чисел
 * coded by Олег Саврик
 */

namespace minOf_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.Write("Введите число a: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите число b: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите число c: ");
            c = Convert.ToInt32(Console.ReadLine());

            if (a < b && a < c)
            {
                Console.WriteLine($"минимальное число из введенных {a}");
            }
            else if (b < a && b < c)
            {
                Console.WriteLine($"минимальное число из введенных {b}");
            }
            else if (c < a && c < b)
            {
                Console.WriteLine($"минимальное число из введенных {c}");
            }

            Console.ReadKey();
        }
    }
}
