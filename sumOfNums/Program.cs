using System;
/*С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечетных положительных чисел
 * coded by Олег Саврик
 */

namespace sumOfNums
{
    class Program
    {
        static int GetNum()
        {
            Console.Write("Введите целое число: ");
            return Convert.ToInt32(Console.ReadLine());
        }

        static void Main(string[] args)
        {
            int sum = 0, num;

            do
            {
                num = GetNum();
                if (num > 0 && (num % 2 == 1) )
                {
                    sum += num;
                }
            } while (num != 0);

            Console.WriteLine($"Сумма введенных нечетных положительных чисел: {sum}");
            Console.ReadKey();
        }
    }
}
