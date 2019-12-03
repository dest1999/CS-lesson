using System;
/*
 * Дописать структуру Complex, добавив метод вычитания комплексных чисел. Продемонстрировать работу структуры.
 * Дописать класс Complex, добавив методы вычитания и произведения чисел. Проверить работу класса.
 * Добавить диалог с использованием switch демонстрирующий работу класса. 
 * 
 * coded by Олег Саврик
 */

namespace Complex
{
    struct Complex
    {
        public double im;
        public double re;

        public Complex Plus (Complex x)
        {
            Complex y;
            y.im = im + x.im;
            y.re = re + x.re;
            return y;
        }

        public Complex Minus(Complex x)
        {
            Complex y;
            y.im = im - x.im;
            y.re = re - x.re;
            return y;
        }

        public Complex Multi (Complex x)
        {
            Complex y;
            y.im = re * x.im + im * x.re;
            y.re = re * x.re - im * x.im;
            return y;
        }

        public string ToStr()
        {
            return re + "+" + im + "i";
        }

    }


    class Program
    {
        static void Main(string[] args)
        {
            Complex cmplx1, cmplx2;
            cmplx1.re = 1;
            cmplx1.im = 1;
            cmplx2.re = 2;
            cmplx2.im = 2;

            Complex result = cmplx1.Plus(cmplx2);
            Console.WriteLine(result.ToStr());
            result = cmplx1.Minus(cmplx2);
            Console.WriteLine(result.ToStr());

            result = cmplx1.Multi(cmplx2);
            Console.WriteLine(result.ToStr());





            Console.ReadKey();
        }
    }
}
