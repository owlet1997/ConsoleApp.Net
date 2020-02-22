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
        private static bool IsEqual(string str)
        {
            while (true)
            {
                Console.WriteLine(str + " Введите Y/N:");
                try
                {
                    var a = Console.ReadLine();
                    switch (a.ToLower())
                    {
                        case "n":
                            return false;
                        case "y":
                            return true;
                        default: throw new Exception();
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Вы должны ввести N или Y");
                }
            }
        }
        
        private static int GetNumber(int? sum)
        {
            int a;
           
            while (true)
            {
                Console.WriteLine("Введите сторону a:");
                try
                {
                    a = Int32.Parse(Console.ReadLine());
                    if (a <= 0)
                    {
                        Console.WriteLine("Число должно быть положительным");
                    }
                    else if (sum!=null && a >=sum)
                    {
                        Console.WriteLine("Сумма двух сторон должна быть меньше третьей");
                    }
                        
                    else break;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Вы должны ввести число, а не строку");
                }
            }

            return a;
        }
        static Triangle GetObject()
        {
            int a, b, c;
            bool isEqual = IsEqual("Треугольник равноcторонний?");
            if (isEqual)
            {
                a = GetNumber(null);
                Triangle triangle = new Triangle(a);
                return triangle;
            }
            
            bool isSquare = IsEqual("Треугольник равнобедренный?");

            if (isSquare)
            { 
                a = GetNumber(null);
                c = GetNumber(a + a);
                Triangle triangle1 = new Triangle(a,c);
                return triangle1;
            }
            
            a = GetNumber(null);
            b = GetNumber(null);
            c = GetNumber(a + b);
            
            Triangle triangle2 = new Triangle(a,b,c);
            return triangle2;
        }

        static void Task1()
        {
            Triangle triangle = GetObject();
            Console.WriteLine($"Задан треугольник со сторонами {triangle.A}, {triangle.B}, {triangle.C}");
            Console.WriteLine($"Площадь треугольника: {triangle.Square}");
            Console.WriteLine($"Периметр треугольника: {triangle.Perimetr}");
        }

        static int ShowStartMenu()
        {
            int number;
            while (true)
            {
                Console.WriteLine("1 - Задание 1, работа с треугольником");
                Console.WriteLine("2 - Выход");
                try
                {
                    number = Int32.Parse(Console.ReadLine());
                    if (number > 2 || number < 1)
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
                    case 1: Task1();
                        break;
                    case 2: Console.WriteLine("Сеанс окончен");
                        return;
                    default: 
                        break;
                }    
            }
            
        }
    }
}