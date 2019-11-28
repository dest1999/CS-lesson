using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace anketa
{
    class Anketa
    {
        static void Main(string[] args)
        {
            string name, surname;
            int age, height, weight;

            Console.Write("Давайте пройдём краткое анкетирование.\nВведите своё имя: ");
            name = Console.ReadLine();
            Console.Write("Введите свою фамилию: ");
            surname = Console.ReadLine();
            Console.Write("Введите свой возраст: ");
            age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите свой рост (в см.): ");
            height = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите свой вес (в кг.): ");
            weight = Convert.ToInt32(Console.ReadLine());

            Console.Clear();
            Console.WriteLine("Вывод информации в форме:");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("конкатенации");
            Console.WriteLine(name + " " + surname + " возраст " + age + " рост " + height + " вес " + weight);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("форматирования");
            Console.WriteLine("{0} {1} возраст {2} рост {3} вес {4}", name, surname, age, height, weight);
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("интерполяции");
            Console.WriteLine($"{name} {surname} возраст {age} рост {height} вес {weight}");

            Console.ResetColor();
            Console.ReadKey();
        }
    }
}
