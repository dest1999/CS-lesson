using System;
/* Реализовать метод проверки логина и пароля. На вход метода подается логин и пароль. На выходе истина, если прошел авторизацию, и ложь, если не прошел
 * (Логин: root, Password: GeekBrains). Используя метод проверки логина и пароля, написать программу: пользователь вводит логин и пароль, программа пропускает его дальше или не пропускает.
 * С помощью цикла do while ограничить ввод пароля тремя попытками
 * 
 * coded by Олег Саврик
 */

namespace loginPassword
{
    class Program
    {
        static Boolean LoginSuccess(string login, string password)
        {
            if (login == "root" && password == "GeekBrains")
            {
                Console.WriteLine("Комбинация принята");
                return true;
            }
            else
            {
                Console.WriteLine("Комбинация неверна");
                System.Threading.Thread.Sleep(1000);
                return false;
            }
        }

        static void Main(string[] args)
        {
            string login, password;
            int count = 0;

            do
            {
                Console.Clear();
                Console.WriteLine($"Попытка входа № {++count}");
                Console.Write("Введите логин: ");
                login = Console.ReadLine();
                Console.Write("Введите пароль: ");
                password = Console.ReadLine();
            } while (!LoginSuccess(login, password) && count < 3);

            Console.ReadKey();
        }
    }
}
