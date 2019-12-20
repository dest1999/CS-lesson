using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

/*
 * Переделать программу ​ Пример использования коллекций ​ для решения следующих задач:
 * а) Подсчитать количество студентов учащихся на 5 и 6 курсах;
 * б) подсчитать сколько студентов в возрасте от 18 до 20 лет на каком курсе учатся (*частотный массив);
 * в) отсортировать список по возрасту студента;
 * г) *отсортировать список по курсу и возрасту студента;
 * 
 * coded by Олег Саврик
 */

namespace studentsCollection
{
    class Student
    {
        public string lastName;
        public string firstName;
        public string university;
        public string faculty;
        public int course;
        public string department;
        public int group;
        public string city;
        public int age;

        public Student(string firstName, string lastName, string university, string faculty, string department, int age, int course, int group, string city)
        {
            this.lastName = lastName;
            this.firstName = firstName;
            this.university = university;
            this.faculty = faculty;
            this.department = department;
            this.course = course;
            this.age = age;
            this.group = group;
            this.city = city;
        }
    }

    class Program
    {
        static int Compare(Student a, Student b)
        {
            int ret = a.course.CompareTo(b.course);
            if (ret == 0)
                ret = a.age.CompareTo(b.age);
            return ret;
        }

    static int[] AgeCourseCount(List<Student> list)
    {
        int[] mas = { 0, 0, 0, 0, 0, 0, 0 };
        foreach (var item in list)
        {
            if (item.age == 18) ++mas[item.course];
            else if (item.age == 19) ++mas[item.course];
            else if (item.age == 20) ++mas[item.course];
        }
        return mas;
    }
        static void Main(string[] args)
        {
            int bakalavr = 0, magistr = 0, count5 = 0, count6 = 0, course;
            List<Student> list = new List<Student>();
            StreamReader sr = new StreamReader("stu.csv");
            int[] mas;
            while (!sr.EndOfStream)
            {
                string[] s = sr.ReadLine().Split(';');//             \|/ возраст        \|/ курс
                list.Add(new Student (s[0], s[1], s[2], s[3], s[4], int.Parse(s[5]), int.Parse(s[6]), int.Parse(s[7]), s[8]));
                course = list.Last().course;
                if (course < 5) bakalavr++;
                else
                {
                    _ = course == 5 ? count5++ : count6++;
                    magistr++;
                }
            }
            sr.Close();
            list.Sort(new Comparison<Student>(Compare));
            Console.WriteLine($"Всего студентов {list.Count}");
            Console.WriteLine($"из них бакалавров - {bakalavr}, магистров - {magistr}");
            Console.WriteLine($"На 5 курсе {count5}, на 6 курсе {count6}");
            foreach (var item in list)
            {
                Console.WriteLine(item.firstName + " " + item.lastName + " " + item.course + " " + item.age);
            }
            Console.WriteLine("Количество учеников возрастом от 18 до 20 лет:");
            mas = AgeCourseCount(list);
            for (int i = 0; i < mas.Length; i++)
            {
                if (mas[i] != 0) Console.WriteLine($"на курсе {i} учеников {mas[i]} ");
            }

            Console.ReadKey();
        }
    }
}
