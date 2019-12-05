using System;
/*
 * С клавиатуры вводятся числа, пока не будет введён 0 (каждое число в новой строке).
 * Требуется подсчитать сумму всех нечётных положительных чисел. Сами числа и сумму вывести на экран, используя tryParse. 
 * 
 * coded by Олег Саврик
 */

namespace summaTryParce
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, sum = 0;
            Console.WriteLine("Будет подсчитана сумма введенных нечётных положительных чисел.\nДля выхода введите 0");
            do
            {
                while (!int.TryParse(Console.ReadLine(), out i))
                {
                    Console.WriteLine("Вы ввели не число.");
                }

                if ((i % 2 == 1) && (i > 0))
                {
                    sum += i;
                }

                Console.WriteLine($"Сумма {sum}");
            } while (i != 0);
            Console.WriteLine($"Выбран выход. Сумма чисел {sum}");

            Console.ReadKey();
        }
    }
}
