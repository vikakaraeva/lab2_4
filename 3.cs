using System;

namespace lab2_4using System;

namespace lab2_4
{
    class lab2_4
    {
        static void Main(string[] args)
        {
            Console.WriteLine("программа Караевой Вика 2-1ИС:");
            Console.WriteLine("Даны два натуральных числа. Определить в каком числе больше цифр, для этого создать метод, определяющий количество цифр в числе.");

            int ch1 = 0; //объявление переменных типа int
            int ch2 = 0;

            bool noError = true; // введём булевую переменную для цикла while

            while (noError) // цикл while для try-catch: если ввели с клавиатуры НЕ число, то возвращаемся обратно
            {
                try
                {
                    Console.WriteLine("введите два натуральных числа: "); //ввод переменных
                    ch1 = int.Parse(Console.ReadLine());
                    ch2 = int.Parse(Console.ReadLine());
                    noError = false;
                }
                catch
                {
                    Console.WriteLine("ошибка, введите число!"); // если ввели буквы и тд, то выводим сообщение об ошибке
                }
            }

            if (NumberOfDigits(ch1, ch2)) //проверка условия
            {
                Console.WriteLine("Цифр в первом числе  больше, чем во втором"); //первое условие
            }
            else if (NumberOfDigitsInverse(ch1, ch2))
            {
                Console.WriteLine("Цифр во втором числе  больше, чем в первом"); //второе условие
            }
            else
            {
                Console.WriteLine("Цифр в двух числах одинаково");
            }
        }
        static bool NumberOfDigits(int ch1, int ch2) //объявление метода для первого условия
        {
            while (ch1 > 0 && ch2 > 0)
            {
                ch1 = ch1 / 10;
                ch2 = ch2 / 10;
            }

            if (ch1 > ch2)
            return true;
            return false;
        }
        static bool NumberOfDigitsInverse(int ch1, int ch2) //объявление метода для второго условия
        {
            while (ch1 > 0 && ch2 > 0)
            {
                ch1 = ch1 / 10;
                ch2 = ch2 / 10;
            }

            if (ch1 < ch2)
            return true;
            return false;
        }
         
        }

    }

