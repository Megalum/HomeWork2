using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semestr2
{
    class Program
    {
        static void Main(string[] args)
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
            int number1 = Input("Введите число ");
            Console.WriteLine($"Вторая цифра числа {number1} --> {Two(number1)}");

            //Задача 2: Напишите программу, которая выводит третьюцифру заданного числа или сообщает, что третьей цифры нет.
            int Three(int a)
            {
                return a / 100 % 10;
            }
            Console.WriteLine();
            Console.WriteLine("Задание 2:");
            int number2 = Input("Введите число ");
            if (number2 / 100 == 0)
                Console.WriteLine("Третьей цифры нет");
            else
                Console.WriteLine($"Третья цифра числа {number2} --> {Three(number2)}");

            //Задача 3: Напишите программу, которая принимает нa вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
            bool Check(int a)
            {
                return a < 6;
            }
            Console.WriteLine();
            Console.WriteLine("Задание 3:");
            int number3 = Input("Введите число ");
            if (number3 < 8)
                if (Check(number3))
                    Console.WriteLine("Рабочий день");
                else
                    Console.WriteLine("Выходной день");
            else
                Console.WriteLine("Error!");

            //Задача 4: Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.
            int Del(int a, int b)
            {
                return a / b;
            }
            bool Checks(int a, int b)
            {
                return a == b;
            }
            Console.WriteLine();
            Console.WriteLine("Задание 4:");
            int number4 = Input("Введите первое число ");
            int number5 = Input("Введите второе число ");
            if (Checks(Del(number4, number5), number5) || Checks(Del(number5, number4), number4))
                Console.WriteLine("Является");
            else
                Console.WriteLine("Не является");

            Console.ReadKey();
        }
    }
}
