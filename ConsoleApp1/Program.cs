using System;
using System.Collections;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    class Program
    {
        static int ShowStartMenu()
        {
            int number;
            while (true)
            {
                Console.WriteLine("1 - Задание 1, работа с вектором");
                Console.WriteLine("2 - Задание 2, работа с многочленом");
                Console.WriteLine("3 - Выход");
                try
                {
                    number = Int32.Parse(Console.ReadLine());
                    if (number > 3 || number < 1)
                    {
                        Console.WriteLine("Число не предусмотрено");
                    }
                    else
                    {
                        break;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Ошибка ввода");
                }
            }
            return number;
        }

        static void Main(string[] args)
        {
            while (true)
            {
                int chosen = ShowStartMenu();
                switch (chosen)
                {
                    case 1: Task1.task1();
                        break;
                    case 2: Task2.task2();
                        break;
                    case 3: Console.WriteLine("Сеанс окончен");
                        return;
                }    
            }
        }
    }
}