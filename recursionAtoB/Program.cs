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
        static int Recursive(int a, int b)
        {
            Console.WriteLine(a++);
            if (a <= b) return (a + Recursive(a, b));
            else return 0;
        }

        static void Main(string[] args)
        {
            Console.Write("Введите число A: ");
            int A = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите число B: ");
            int B = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n\n" + (A + Recursive(A, B))); //А+  это костыль для исрпавления неправильного подсчета суммы в Recursive, почему-то не суммируется первый элемент
            Console.ReadKey();
        }
    }
}
