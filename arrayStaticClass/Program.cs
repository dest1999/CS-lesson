using System;
using System.IO;
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

        public static void SaveArrayToFile(int[] array, string path)
        {
            StreamWriter writer = new StreamWriter(path);
            for (int i = 0; i < array.Length; i++)
            {
                writer.WriteLine(array[i]);
            }
            writer.Close();
            Console.WriteLine($"Массив сохранен в файл {path}");
        }

        public static bool LoadArrayFromFile(ref int[] array, string path)
        {
            int i = 0, elementOfArray;

            try
            {
                StreamReader reader = new StreamReader(path);
                
                while (!reader.EndOfStream)
                {
                    reader.ReadLine();
                    i++;
                }
                if (array.Length != i)
                {
                    Array.Resize(ref array, i);
                }
                i = 0;

                reader.BaseStream.Position = 0;
                
                while (!reader.EndOfStream)
                {
                    if (int.TryParse(reader.ReadLine(), out elementOfArray))
                    {
                        array[i] = elementOfArray;
                        i++;
                    }
                    else continue;
                }
                reader.Close();
                return true;
            }

            catch (FileNotFoundException)
            {
                Console.WriteLine("File not found exeption");
                return false;
            }

            finally
            {
                Console.WriteLine("Finally is work");
            }
        }

        public static void ShowArray(int[] array)
        {
            foreach (var item in array)
            {
                Console.Write(item + " ");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[20];
            Random initArrayRnd = new Random();
            int count = 0;

            Console.Write("Если хотите сохранить массив в файл, то введите имя файла, иначе просто нажмите 'Enter': ");
            string path = Console.ReadLine();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = initArrayRnd.Next(-10000, 10001);
            }
            if (path != "")
            {
                ArrayStaticClass.SaveArrayToFile(array, path);
            }
            Console.WriteLine("Элементы массива:");
            ArrayStaticClass.ShowArray(array);
            count = ArrayStaticClass.ArrayAnalize(array);
            Console.WriteLine($"\nНайдено пар: {count}\n");
            path = "";
            Console.Write("Если хотите считать массив из файла, то введите имя файла, иначе просто нажмите 'Enter': ");
            path = Console.ReadLine();
            if (path != "")
            {
                if (ArrayStaticClass.LoadArrayFromFile(ref array, path))
                {
                    Console.WriteLine($"Из файла {path} считан массив:");
                    ArrayStaticClass.ShowArray(array);
                    count = ArrayStaticClass.ArrayAnalize(array);
                    Console.WriteLine($"\nНайдено пар: {count}");
                }
                else Console.WriteLine("Указанный файл не найден, массив остался без изменений");
            }
            else Console.WriteLine("Массив остался без изменений");
            Console.WriteLine("Для выхода нажмите любую клавишу");
            Console.ReadKey();
        }
    }
}
