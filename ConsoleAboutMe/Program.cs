using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleAboutMe
{
    class MyClass
    {
        public static void Pause()
        {
            Console.CursorVisible = false;
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("\n ...ждём действий пользователя");
            Console.ReadKey();
            Console.CursorVisible = true;
            Console.ResetColor();
        }
    }

    class Program
    {

        static void PrintAtPosition (string str1, string str2, int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine(str1);
            Console.SetCursorPosition(x, ++y);
            Console.WriteLine(str2);
            Console.CursorVisible = false;
        }


        static void Main(string[] args)
        {
            int left = 25, top = 10;
            string string1 = "Добрый день, меня зовут Олег Саврик";
            string string2 = "Я проживаю в городе Анапа";

            PrintAtPosition(string1, string2, left, top);



            MyClass.Pause();
            
        }
    }
}
