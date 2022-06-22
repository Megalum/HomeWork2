using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semenar2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int Input(string str)
                {
                    Console.Write(str);
                    return Convert.ToInt32(Console.ReadLine());
                }

                //Задача 1: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
                int Two(int a)
                {
                    return a / 10 % 10;
                }
                Console.WriteLine("Задание 1:");
                int number = Input("Введите число ");
                if (number / 100 < 10)
                    Console.WriteLine($"Вторая цифра числа {number} --> {Two(number)}");
                else
                    Console.WriteLine("Вы ввели не трёхзначное число");

                //Задача 2: Напишите программу, которая выводит третьюцифру заданного числа или сообщает, что третьей цифры нет.
                int Three(int a)
                {
                    return a / 100 % 10;
                }
                Console.WriteLine();
                Console.WriteLine("Задание 2:");
                number = Input("Введите число ");
                if (number / 100 == 0)
                    Console.WriteLine("Третьей цифры нет");
                else
                    Console.WriteLine($"Третья цифра числа {number} --> {Three(number)}");

                //Задача 3: Напишите программу, которая принимает нa вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
                bool Check(int a)
                {
                    return a < 6;
                }
                Console.WriteLine();
                Console.WriteLine("Задание 3:");
                number = Input("Введите число ");
                if (number < 8)
                    if (Check(number))
                        Console.WriteLine("Рабочий день");
                    else
                        Console.WriteLine("Выходной день");
                else
                    Console.WriteLine("День недели не обнаружен!");

                //Задача 4: Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.
                bool Checks(double a, int b)
                {
                    return a * a == b;
                }
                Console.WriteLine();
                Console.WriteLine("Задание 4:");
                number = Input("Введите первое число ");
                int number2 = Input("Введите второе число ");
                if (Checks(number, number2) || Checks(number2, number))
                    Console.WriteLine("Является");
                else
                    Console.WriteLine("Не является");
            }
            catch (Exception)
            {
                Console.WriteLine("Error!");
            }         

            Console.ReadKey();
        }
    }
}
