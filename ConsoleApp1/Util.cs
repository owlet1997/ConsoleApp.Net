using System;

namespace ConsoleApp1
{
    public class Util
    {
        public static bool IsEqual(string str)
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

        public static int GetNumber(int? sum)
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
                    else if (sum != null && a >= sum)
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
        
        public static int ShowStartMenu()
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
    }
}