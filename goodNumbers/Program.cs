using System;
/* Написать программу подсчета количества «хороших» чисел в диапазоне от 1 до 1 000 000 000.
 * «Хорошим» называется число, которое делится на ​сумму своих цифр​.
 * Реализовать подсчёт времени выполнения программы, используя структуру DateTime
 *  
 * coded by Олег Саврик
 */

namespace goodNumbers
{
    class Program
    {
        static bool IsTheNumberIsGood (int i)
        {
            int tmpi = i, sumOfNumbers = 0;

            do //в этом цикле извлекаем сумму составляющих чисел
            {
                sumOfNumbers += tmpi % 10;
                tmpi /= 10;
            } while (tmpi != 0);

            if (i % sumOfNumbers == 0) //проверяем делится ли число нацело на сумму своих составляющих
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static void Main(string[] args)
        {
            int qtyOfGoodNumbers = 0;
            DateTime start = DateTime.Now;

            for (int i = 1; i < 1000000000; i++)
            {
                if (IsTheNumberIsGood(i))
                {
                    qtyOfGoodNumbers++;
                    if (i % 1000000 == 0) Console.Write($"Чисел найдено: {qtyOfGoodNumbers}\r");
                }
            }

            Console.WriteLine($"Программа отработала за {DateTime.Now - start}, чисел найдено {qtyOfGoodNumbers}");
            Console.ReadKey();
        }
    }
}
