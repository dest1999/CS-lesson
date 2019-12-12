using System;
using System.Text;
/*
 * Разработать статический класс Message​, содержащий следующие статические методы для обработки текста:
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

        public static void ShowWords(string inputMessage, int lenght)   //если выбрано ограничение длины слова ноль или менее - показываем без изменений
        {
            string[] words = inputMessage.Split(' ');

            if (lenght <= 0)
            {
                Console.WriteLine(inputMessage);
            } else foreach (var word in words)
                {
                    if (word.Length <= lenght)
                    {
                        Console.Write(word + " ");
                    }
                }
            Console.WriteLine();
        }

        public static void DeleteWords(ref string inputMessage, char ch)
        {
            string[] words = inputMessage.Split(' ');
            inputMessage = "";

            foreach (var word in words)
            {
                if (!word.EndsWith(ch.ToString()))
                {
                    inputMessage += word + " ";
                }
            }
        }

        public static string LongestWord (string inputMessage)
        {
            string[] words = inputMessage.Split(' ');
            string findWord = words[0];
            foreach (var word in words)
            {
                if (word.Length > findWord.Length)
                {
                    findWord = word;
                }
            }
            return findWord;
        }

        public static StringBuilder CollectLongestWords(string inputMessage)
        {
            string[] words = inputMessage.Split(' ');
            StringBuilder strB = new StringBuilder(words[0]);
            int lenghtFound = words[0].Length;

            foreach (var word in words)
            {
                if (word.Length > lenghtFound)
                {
                    lenghtFound = word.Length;
                    strB.Clear();
                    strB.Append(word);
                }
                else if (word.Length == lenghtFound)
                {
                    strB.Append(" " + word);
                }
                    
                    
            }
            return strB;
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите сообщение: ");
            string messageIs = Console.ReadLine();
            /*Console.Write("Максимальное количество букв: ");
            int length = int.Parse(Console.ReadLine());
            Message.ShowWords(messageIs, length);
            */


            Console.WriteLine("Самое длинное слово: " + Message.LongestWord(messageIs));
            Console.WriteLine("StringBuilder выбрал самые длинные слова и сформировал строку :" + Message.CollectLongestWords(messageIs));



            Console.Write("Введите последний символ в удаляемых словах: ");
            char ch = Console.ReadKey().KeyChar;
            Console.WriteLine();
            Message.DeleteWords(ref messageIs, ch);

            Message.ShowWords(messageIs, 0);
            Console.ReadKey();
        }
    }
}
