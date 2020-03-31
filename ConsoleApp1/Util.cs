using System;

namespace ConsoleApp1
{
    public class Util
    {
        public static int GetNumber()
        {
            int a;
           
            while (true)
            {
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
        
        public static int ShowStartMenu()
        {
            int number;
            while (true)
            {
                Console.WriteLine("1 - Ввести данные матрицы из консоли");
                Console.WriteLine("2 - Сгенерировать матрицу рандомно");
                Console.WriteLine("3 - Получить пустую матрицу данного размера");
                Console.WriteLine("4 - Выход");
                try
                {
                    number = Int32.Parse(Console.ReadLine());
                    if (number > 4 || number < 1)
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
        
        public static int ShowInnerMenu()
        {
            int number;
            while (true)
            {
                Console.WriteLine("1 - Сложение матриц");
                Console.WriteLine("2 - Вычитание матриц");
                Console.WriteLine("3 - Умножение матриц");
                Console.WriteLine("4 - Выход");
                try
                {
                    number = Int32.Parse(Console.ReadLine());
                    if (number > 4 || number < 1)
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