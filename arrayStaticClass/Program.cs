using System;
/*
 * Реализуйте задачу 1 в виде статического класса StaticClass;
 * а) Класс должен содержать статический метод, который принимает на вход массив и решает задачу 1;
 * б) *Добавьте статический метод для считывания массива из текстового файла. Метод должен возвращать массив целых чисел;
 * в)**Добавьте обработку ситуации отсутствия файла на диске. 
 * 
 *  coded by Олег Саврик
 */

namespace arrayStaticClass
{
    public static class ArrayStaticClass
    {
        /*static int[] array    //подсказка
        {
            get { return array; }

            set { array = value; }
        }*/

        public static int ArrayAnalize(int[] array)
        {
            int cnt = 0;
            for (int i = 0; i < array.Length - 1; i++)
            {
                if ((array[i] % 3 == 0) ^ (array[i + 1] % 3 == 0))
                {
                    cnt++;
                }
            }
            return cnt;

        }

    }

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
                Console.Write(item + " ");
            }
            Console.WriteLine();



            count = ArrayStaticClass.ArrayAnalize(array);
            Console.WriteLine($"Найдено пар: {count}");

            Console.ReadKey();
        }
    }
}
