using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
/*
 * С помощью рефлексии выведите все свойства структуры DateTime
 * 
 * coded by Олег Саврик
 */
namespace reflectionDateTime
{
    class Program
    {
        static void Main(string[] args)
        {
            PropertyInfo[] properties;
            Type type = typeof(DateTime);
            properties = type.GetProperties();
            Console.WriteLine($"Свойства {type}:\n");
            foreach (var item in properties)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
