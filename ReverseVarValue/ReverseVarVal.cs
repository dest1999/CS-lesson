using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ReverseVarValue
{
    class ReverseVarVal
    {
        static void Main(string[] args)
        {
            int x, y, tmp;
            Console.Write("Введите целочисленное значение для переменной x: ");
            x = Int32.Parse(Console.ReadLine());
            Console.Write("Введите целочисленное значение для переменной y: ");
            y = Int32.Parse(Console.ReadLine());

            Console.WriteLine("\nМеняем значения через временную переменную");
            tmp = x;
            x = y;
            y = tmp;
            Console.WriteLine($"переменная x = {x}, а переменная y = {y}");
            Console.WriteLine("\nМеняем с помощью XOR без использования дополнительной переменной");
            x = x ^ y;
            y = x ^ y;
            x = x ^ y;
            Console.WriteLine($"переменная x = {x}, а переменная y = {y}");

            
            Console.ReadKey();
        }
    }
}
