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

        public static ComplexClass Parse(string str)
        {
            ComplexClass y = new ComplexClass();
            string [] tmp = str.Split('+');
            y.re = double.Parse(tmp[0]);
            y.im = double.Parse(tmp[1]);
            return y;
        }

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
            Complex complexStruct1, complexStruct2;
            ComplexClass complexClass1 = new ComplexClass();
            ComplexClass complexClass2 = new ComplexClass();
            complexClass1.re = complexStruct1.re = 5;
            complexClass1.im = complexStruct1.im = 4;
            complexClass2.re = complexStruct2.re = 3;
            complexClass2.im = complexStruct2.im = -9;

            #region Check
            Console.WriteLine("Если числа равны, то проверка прошла успешно");
            Complex result = complexStruct1.Plus(complexStruct2);
            Console.WriteLine(result.ToString());
            ComplexClass resultCls = complexClass1.Plus(complexClass2);
            Console.WriteLine(resultCls.ToString());
            result = complexStruct1.Minus(complexStruct2);
            Console.WriteLine(result.ToString());
            resultCls = complexClass1.Minus(complexClass2);
            Console.WriteLine(resultCls.ToString());
            result = complexStruct1.Multi(complexStruct2);
            Console.WriteLine(result.ToString());
            resultCls = complexClass1.Multi(complexClass2);
            Console.WriteLine(resultCls.ToString());
            #endregion

            Console.WriteLine("\nВведите первое комплексное число. Разделителем является +, например 5+7\nПервое число действительная часть, а второе число - мнимая");
            complexClass1 = ComplexClass.Parse(Console.ReadLine());
            Console.WriteLine("\nВведите второе комплексное число по тем же правилам");
            complexClass2 = ComplexClass.Parse(Console.ReadLine());
            
            Console.WriteLine("\nВыберите действие с числами: + - *");
            ConsoleKeyInfo key = Console.ReadKey();
            Console.WriteLine();
            switch (key.KeyChar.ToString())
            {
                case "+":
                    resultCls = complexClass1.Plus(complexClass2);
                    Console.WriteLine(resultCls.ToString());
                    break;
                case "-":
                    resultCls = complexClass1.Minus(complexClass2);
                    Console.WriteLine(resultCls.ToString());
                    break;
                case "*":
                    resultCls = complexClass1.Multi(complexClass2);
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
