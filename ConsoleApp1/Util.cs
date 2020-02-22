using System;

namespace ConsoleApp1
{
    public class Util
    {
        public static int ShowInnerMenu()
        {
            int number;
            while (true)
            {
                Console.WriteLine("1 - Сложение векторов");
                Console.WriteLine("2 - Вычитание векторов");
                Console.WriteLine("3 - Скалярное произведение векторов");
                Console.WriteLine("4 - Векторное произведение векторов");
                Console.WriteLine("5 - Умножение вектора на число");
                Console.WriteLine("6 - Выход");
                try
                {
                    number = Int32.Parse(Console.ReadLine());
                    if (number > 6 || number < 1)
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
        public static int GetNumber(string s)
        {
            int a;
           
            while (true)
            {
                Console.WriteLine(s);
                try
                {
                    a = Int32.Parse(Console.ReadLine());
                    break;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Вы должны ввести число, а не строку");
                }
            }
            return a;
        }
    }
}