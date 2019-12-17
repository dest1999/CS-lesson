using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
/*
 * Модифицировать программу нахождения минимума функции так, чтобы можно было передавать функцию в виде делегата.
 * а) Сделать меню с различными функциями и представить пользователю выбор, для какой функции и на каком отрезке находить минимум.
 * Использовать массив (или список) делегатов, в котором хранятся различные функции.
 * б) *Переделать функцию Load, чтобы она возвращала массив считанных значений. Пусть она возвращает минимум через параметр (с использованием модификатора out). 
 *
 * coded by Олег Саврик
 */

namespace findMinFunction
{
    class Program
    {
        public delegate double Dlgt(double x);

        public static double F(double x)
        {
            return x * x - 50 * x + 10;
        }
        public static double Fsinxx(double x) //x * x * sin(x)
        {
            return x * x * Math.Sin(x);
        }
        public static double FxTgx(double x) // x * tg(x)
        {
            return x * Math.Tan(x);
        }

        public static void SaveFunc(string fileName, double a, double b, double h, Dlgt dlgt) //a - нач.точка, b - конечн.точка, h - шаг ф-ции
        {
            FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            BinaryWriter bw = new BinaryWriter(fs);
            double x = a;
            while (x <= b)
            {
                bw.Write(dlgt(x));
                x += h;
            }
            bw.Close();
            fs.Close();
        }

        public static double Load(string FileName)
        {
            FileStream fs = new FileStream(FileName, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);
            double min = double.MaxValue, d;
            for (int i = 0; i < fs.Length/sizeof(double); i++)
            {
                d = br.ReadDouble();
                if (d < min) min = d;
            }
            br.Close();
            fs.Close();
            return min;
        }

        static void Main(string[] args)
        {
            Dlgt dlgtF = F, dlgtSin = Fsinxx, dlgtTan = FxTgx; // прошу комментарий о необходимости этой строки, т.к. не увидел разницы в работе с обобщенным списком.
            //ArrayList listDelegates = new ArrayList { dlgtF, dlgtSin, dlgtTan }; //это необобщенный список
            List<Dlgt> listDelegates = new List<Dlgt> { dlgtF, dlgtSin, dlgtTan };

            Console.WriteLine("Введите номер функции, начальную и конечную точки, шаг функции через пробелы.\n" +
                "1 - функция вида x*x-50*x+10\n" + // эти номера нужно будет уменьшить на 1 для соответствия элементам коллекции
                "2 - функция вида x*x*sin(x)\n" +
                "3 - функция вида x*(tg(x))");

            string[] param = Console.ReadLine().Split(' ');

            SaveFunc("data.bin", double.Parse(param[1]), double.Parse(param[2]), double.Parse(param[3]), listDelegates[(int.Parse(param[0])) - 1]);
            
            //SaveFunc("data.bin", double.Parse(param[1]), double.Parse(param[2]), double.Parse(param[3]), (Dlgt)listDelegates[(int.Parse(param[0])) - 1]); //работа с необобщенным списком
            Console.WriteLine(Load("data.bin"));

            Console.ReadKey();
        }
    }
}
