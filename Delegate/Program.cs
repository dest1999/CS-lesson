using System;
/*
 * Изменить программу вывода таблицы функции так, чтобы можно было передавать функции типа double (double, double).
 * Продемонстрировать работу на функции с функцией a*x^2 и функцией a*sin(x).
 * 
 * coded by Олег Саврик
 */

namespace Delegate
{
    public delegate double Fun(double z, double z1);

    class Program
    {
        public static void Table(Fun F, double x, double a, double b)
        {
            Console.WriteLine("----- X ----- Y -----");
            while (x <= b)
            {
                Console.WriteLine("| {0,8:0.000} | {1,8:0.000} |", x, F(x, a));
                x++;
            }
            Console.WriteLine("---------------------");
        }

        public static double MyFunc(double y, double a) // a*y^2
        {
            return a * (y * y);
        }

        public static double MyFuncSin(double y, double a) // sin
        {
            return a * Math.Sin(y);
        }

        static void Main(string[] args)
        {
            Console.WindowHeight = 40;
            Fun fun = MyFunc;
            Console.WriteLine("Функция a*x^2");
            Table(fun, -2, 2, 10);
            Console.WriteLine("Функция a*sin(x)");
            fun = MyFuncSin;
            Table(fun, -2, 2, 10);

            Console.ReadKey();
        }
    }
}
