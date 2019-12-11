using System;
using System.Text.RegularExpressions;

/*
 * Создать программу, которая будет проверять корректность ввода логина.
 * Корректным логином будет строка от 2 до 10 символов, содержащая только буквы латинского алфавита или цифры, при этом цифра не может быть первой:
 * а) без использования регулярных выражений
 * б) **с использованием регулярных выражений. 
 * 
 * coded by Олег Саврик
 */

namespace CheckLogin
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите логин для проверки: ");
            string login = Console.ReadLine();
            Regex regex = new Regex(@"(^[a-z]|^[A-Z]){1}(\d|[a-z]|[A-Z]){1,9}$");
            bool isLoginValid = false;

            #region simplecheck
            if (login.Length >= 2 && login.Length <= 10 &&  ((login[0] >= 'A' && login[0] <= 'Z') || (login[0] >= 'a' && login[0] <= 'z'))) //Проверка длинны и первого символа
            {
                foreach (var ch in login)
                {
                    if ((ch >= 'A' && ch <= 'Z') || (ch >= 'a' && ch <= 'z') || (ch >= '0' && ch <= '9'))
                    {
                        isLoginValid = true;
                    }
                    else
                    {
                        isLoginValid = false;
                        break;
                    }
                }
            }
            Console.WriteLine("Введенный логин " + (isLoginValid ? "корректен" : "некорректен"));
            #endregion
            Console.WriteLine("regex говорит, что логин " + (regex.IsMatch(login) ? "корректен" : "некорректен"));

            Console.ReadKey();
        }
    }
}
