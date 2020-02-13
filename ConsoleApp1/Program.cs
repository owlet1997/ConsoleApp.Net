using System;
using System.Collections;
using System.IO;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    class Program
    {
        static NewtonRoot GetObject()
        {
            double number;
            while (true)
            {
                Console.WriteLine("Введите число х:");
                try
                {
                    number = Double.Parse(Console.ReadLine());
                    if (number < 0)
                    {
                        Console.WriteLine("Число должно быть положительным");
                    }
                    else break;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Вы должны ввести число, а не строку");
                }
            }

            int n;
            while (true)
            {
                Console.WriteLine("Введите n - корень какой степени хотите извлечь:");
                try
                {
                    n = Int32.Parse(Console.ReadLine());
                    if (n < 0)
                    {
                        Console.WriteLine("Степень должна быть положительной");
                    }
                    else break;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Вы должны ввести число, а не строку");
                }
            }
            NewtonRoot root = new NewtonRoot(number,n);
            return root;
        }

        static void Task1()
        {
            NewtonRoot root = GetObject();
            Console.WriteLine($"Вычисление корня {root.N}-й степени из числа {root.StartNumber}");
            Console.WriteLine($"Значение, полученное при помощи метода Ньютона: {root.CalculatedResult}");
            Console.WriteLine($"Значение, полученное при помощи метода Math.Pow: {root.MathPowResult}");
            Console.WriteLine($"Разница в значениях: {root.Dimension}");
        }

        static ConvertToBinary GetInstance()
        {
            int n;
            while (true)
            {
                Console.WriteLine("Введите число n:");
                try
                {
                    n = Int32.Parse(Console.ReadLine());
                    if (n < 0)
                    {
                        Console.WriteLine("Число должно быть положительным");
                    }
                    else break;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Вы должны ввести число, а не строку");
                }
            } 
            ConvertToBinary obj = new ConvertToBinary(n);
            return obj;
        }

        static void Task2()
        {
            ConvertToBinary binary = GetInstance();
            Console.WriteLine($"Вычисленное двоичное представление числа {binary.StartNumber} по написанному алгоритму: {binary.CalcResult}");
            Console.WriteLine($"Вычисленное двоичное представление числа {binary.StartNumber} по встроенной функции: {binary.FunctionResult}");
        }
        
        static int ShowStartMenu()
        {
            int number;
            while (true)
            {
                Console.WriteLine("1 - Задание 1, вычисление корня числа методом Ньютона");
                Console.WriteLine("2 - Задание 2, разработка алгоритма конвертации десятичного числа в строку, содержащую двоичное представление");
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
            int chosen = ShowStartMenu();
            switch (chosen)
            {
                case 1: Task1();
                    break;
                case 2: Task2();
                    break;
                case 3: Console.WriteLine("Сеанс окончен");
                    break;
                default:
                    break;
            }
        }
    }
}