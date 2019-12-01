using System;
/* Разработать рекурсивный метод, который выводит на экран числа от a до b(a<b). 
 * *Разработать рекурсивный метод, который считает сумму чисел от a до b. 
 * 
 * coded by Олег Саврик
 */

namespace recursionAtoB
{
    class Program
    {
        static int Recursive (int a, int b)
        {
            Console.WriteLine(++a);
            if (a < b) Recursive(a, b);
            return a;
        }




        static void Main(string[] args)
        {
            Console.Write("Введите число A: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите число B: ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(Recursive(a, b));


            Console.ReadKey();
        }
    }
}
