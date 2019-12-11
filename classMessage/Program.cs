using System;
/*
 * Разработать статический класс ​ Message​, содержащий следующие статические методы для обработки текста:
 * а) Вывести только те слова сообщения, которые содержат не более n букв
 * б) Удалить из сообщения все слова, которые заканчиваются на заданный символ
 * в) Найти самое длинное слово сообщения
 * г) Сформировать строку с помощью StringBuilder из самых длинных слов сообщения
 * д) ***Создать метод, который производит частотный анализ текста. В качестве параметра в него передается массив слов и текст,
 * в качестве результата метод возвращает сколько раз каждое из слов массива входит в этот текст. Здесь требуется использовать класс Dictionary.
 * 
 * coded by Олег Саврик
 */

namespace classMessage
{
    static class Message
    {

        public static void Words(string inputMessage, int lenght)
        {
            string[] words = inputMessage.Split(' ');

            foreach (var word in words)
            {
                if (word.Length <= lenght)
                {
                    Console.WriteLine(word);
                }

            }

        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите сообщение: ");
            string messageIs = Console.ReadLine();
            Console.Write("Максимальное количество букв: ");
            int length = int.Parse(Console.ReadLine());
            Message.Words(messageIs, length);

            Console.ReadKey();
        }
    }
}
