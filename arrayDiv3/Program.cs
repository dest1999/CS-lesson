using System;
/*
 * Дан целочисленный массив из 20 элементов. Элементы массива могут принимать целые значения от –10 000 до 10 000 включительно. Заполнить случайными числами.
 * Написать программу, позволяющую найти и вывести количество пар элементов массива, в которых только одно число делится на 3.
 * В данной задаче под парой подразумевается два подряд идущих элемента массива. Например, для массива из пяти элементов: 6; 2; 9; –3; 6 ответ — 2.
 * 
 * coded by Олег Саврик
 */

namespace arrayDiv3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[20];
            Random initArrayRnd = new Random();
            int count = 0;
            
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = initArrayRnd.Next(-10000, 10001);
            }
            Console.WriteLine("Элементы массива:");
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            
            for (int i = 0; i < array.Length; i += 2)
            {
                if ((array[i] % 3 == 0) ^ (array[i+1] % 3 == 0))
                {
                    count++;
                }
            }
            Console.WriteLine($"Найдено пар: {count}");

            Console.ReadKey();
        }
    }
}
