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

        public Complex Plus(Complex x)
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

        public override string ToString()
        {
            return re + "+" + im + "i str";
        }
    }

    class ComplexClass
    {
        public double re;
        public double im;

        public ComplexClass Plus(ComplexClass x)
        {
            ComplexClass y = new ComplexClass();
            y.re = x.re + this.re;
            y.im = x.im + this.im;
            return y;
        }

        public ComplexClass Minus(ComplexClass x)
        {
            ComplexClass y = new ComplexClass();
            y.im = this.im - x.im;
            y.re = this.re - x.re;
            return y;
        }

        public ComplexClass Multi (ComplexClass x)
        {
            ComplexClass y = new ComplexClass();
            y.re = this.re * x.re - this.im * x.im;
            y.im = this.re * x.im + this.im * x.re;
            return y;
        }


        public override string ToString()
        {
            return this.re + "+" + this.im + "i cls";
        }


    }

    class Program
    {
        static void Main(string[] args)
        {
            Complex cmplx1, cmplx2;
            ComplexClass cc1 = new ComplexClass();
            ComplexClass cc2 = new ComplexClass();

            cc1.re = cmplx1.re = 1;
            cc1.im = cmplx1.im = 1;
            cc2.re = cmplx2.re = 3;
            cc2.im = cmplx2.im = -9;

            #region Check
            Complex result = cmplx1.Plus(cmplx2);
            Console.WriteLine(result.ToString());

            ComplexClass resultCls = cc1.Plus(cc2);
            Console.WriteLine(resultCls.ToString());

            result = cmplx1.Minus(cmplx2);
            Console.WriteLine(result.ToString());

            resultCls = cc1.Minus(cc2);
            Console.WriteLine(resultCls.ToString());

            result = cmplx1.Multi(cmplx2);
            Console.WriteLine(result.ToString());

            resultCls = cc1.Multi(cc2);
            Console.WriteLine(resultCls.ToString());
            #endregion
            Console.WriteLine("\nВыберите действие с числами: + - *");
            ConsoleKeyInfo key = Console.ReadKey();
            Console.WriteLine();
            
            switch (key.KeyChar.ToString())
            {
                case "+":
                    resultCls = cc1.Plus(cc2);
                    Console.WriteLine(resultCls.ToString());
                    break;
                case "-":
                    resultCls = cc1.Minus(cc2);
                    Console.WriteLine(resultCls.ToString());
                    break;
                case "*":
                    resultCls = cc1.Multi(cc2);
                    Console.WriteLine(resultCls.ToString());
                    break;
                default:
                    Console.WriteLine("Вы нажали что-то не то");
                    break;
            }
            
            

            
            
            Console.ReadKey();
        }
    }
}
