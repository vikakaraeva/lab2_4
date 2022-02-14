using System;

namespace lab2_4
{
    class lab2_4
    {
        static void Main(string[] args)
        {
            Console.WriteLine("программа Караевой Вика 2-1ИС:");
            Console.WriteLine("Даны два натуральных числа. Определить в каком числе больше цифр, для этого создать метод, определяющий количество цифр в числе.");
            double ch1 = 0;//объявление переменных типа double
            double ch2 = 0;

            bool noError = true; // введём булевую переменную для цикла while

            while (noError) // цикл while для try-catch: если ввели с клавиатуры НЕ число, то возвращаемся обратно
            {
                try
                {
                    Console.WriteLine("введите два натуральных числа: "); //ввод переменных
                    ch1 = double.Parse(Console.ReadLine());
                    ch2 = double.Parse(Console.ReadLine());
                    noError = false;
                }
                catch
                {
                    Console.WriteLine("ошибка, введите число!");// если ввели буквы и тд, то выводим сообщение об ошибке
                }
            }
            if (ch1 < ch2)//проверка условия
            {
                ch1 = ch2;
            }
            else
            {
                ch2 = ch1;
            }
         
        
            Console.WriteLine("наиблльшее число: " + ch2); //вывод результата
            Console.WriteLine("Нажмите enter, чтобы выйти");
            Console.ReadKey(); //выходим из программы
        }
    }
}
