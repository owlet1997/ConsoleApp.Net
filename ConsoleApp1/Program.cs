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
        static Vector GetObject(string str)
        {
            Console.WriteLine("Ввод координат "+ str + " вектора");
            int x = Util.GetNumber("Введите координату x:");
            int y = Util.GetNumber("Введите координату y:");
            int z = Util.GetNumber("Введите координату z:");
            
            Vector vector = new Vector(x,y,z);
            return vector;
        }

        static void Task1()
        {
            Vector vector1 = GetObject("1");
            Vector vector2 = GetObject("2");
            Console.WriteLine(vector1);
            Console.WriteLine(vector2);
            
            while (true)
            {
                int chosen = Util.ShowInnerMenu();
                switch (chosen)
                {
                    case 1: Console.WriteLine(vector1.Summary(vector2));
                        break;
                    case 2: Console.WriteLine(vector1.Substraction(vector2));
                        break;
                    case 3: Console.WriteLine(Math.Round(vector1.ScalarGeometryMultiply(vector2),2));
                        break;
                    case 4: Console.WriteLine(vector1.ScalarMultiply(vector2));
                        break;
                    case 5: Console.WriteLine(vector1.VectorMultiply(vector2));
                        break;
                    case 6: int n = Util.GetNumber("Введите число, на которое нужно умножить вектор");
                        Console.WriteLine(vector1.MultiplyByNumber(n));
                        break;
                    case 7: return;
                  
                }    
            }
        }

        static int ShowStartMenu()
        {
            int number;
            while (true)
            {
                Console.WriteLine("1 - Задание 1, работа с вектором");
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
                }    
            }
        }
    }
}