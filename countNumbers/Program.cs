using System;
/*Написать метод подсчета количества цифр числа
 * coded by Олег Саврик
 */

namespace countNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число целое число: ");
            int i = 0, num = Int32.Parse(Console.ReadLine());
            
            for (; num != 0 ; i++)
            {
                num /= 10;
            }

            Console.WriteLine($"Символов в числе {i}");

            Console.ReadKey();
        }
    }
}
