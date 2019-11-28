using System;

namespace myclass
{

    public static class ClassForLesson1
    {
        public Pause()
        {
            Console.WriteLine("ждём нажатия любой клавиши пользователем");
            Console.CursorVisible = false;
            Console.ReadKey();
            Console.CursorVisible = true;
        }
    }

}