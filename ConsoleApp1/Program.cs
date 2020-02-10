using System;
using System.Collections;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static NODEvklid GetInstanceTwo()
        {
            int n = 2;
            int[] numbers = new int[n];
            Random random = new Random();
            for (int i = 0; i < n; i++)
            {
                numbers[i] = random.Next((i+1)*100+1,  100*(i+2));
            }

            NODEvklid evklid = new NODEvklid(numbers[0], numbers[1]);
            return evklid;

        }
        static NODEvklid GetInstanceThreeOrMore()
        {
            int n;
            while (true)
            {
                Console.WriteLine("Введите количество чисел");
                try
                {
                    n = Int32.Parse(Console.ReadLine());
                    if (n < 3 || n > 5)
                    {
                        Console.WriteLine("Мы считаем НОД у чисел от трех до пяти");
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
            int[] numbers = new int[n];
            Random random = new Random();
            for (int i = 0; i < n; i++)
            {
                numbers[i] = random.Next((i+1)*100+1,  100*(i+2));
            }

            NODEvklid evklid = null;
            switch (n)
            { 
              case 3:  evklid = new NODEvklid(numbers[0], numbers[1], numbers[2]);
                  break;
              case 4:  evklid = new NODEvklid(numbers[0], numbers[1], numbers[2], numbers[3]);
                  break;
              case 5:  evklid = new NODEvklid(numbers[0], numbers[1], numbers[2], numbers[3], numbers[4]);
                  break;
              default:
                  Console.WriteLine("Ошибка!");
                  break;
            }
            
            return evklid;
        }
        
        

        static void Task1()
        {
            NODEvklid nodEvklid = GetInstanceTwo();
            nodEvklid.setDivisor(nodEvklid.NODBinaryTime());
            Console.WriteLine($"Наибольший общий делитель чисел {nodEvklid.A} и {nodEvklid.B} : {nodEvklid.Divisor}");
        }
        
        static void Task2()
        {
            NODEvklid nodEvklid = GetInstanceTwo();
            nodEvklid.setDivisor(nodEvklid.NODEvklidTime());
            Console.WriteLine($"Наибольший общий делитель чисел {nodEvklid.A} и {nodEvklid.B} : {nodEvklid.Divisor}");

        }

        static void Task3()
        {
            NODEvklid nodEvklid = GetInstanceThreeOrMore();
            switch (nodEvklid.N)
            {
               case 3: 
                   Console.WriteLine($"Наибольший общий делитель чисел {nodEvklid.A}, {nodEvklid.B} и {nodEvklid.C} : {nodEvklid.Divisor}");
                    break;
               case 4:
                   Console.WriteLine($"Наибольший общий делитель чисел {nodEvklid.A}, {nodEvklid.B}, {nodEvklid.C} и {nodEvklid.D} : {nodEvklid.Divisor}");
                   break;
               case 5:
                   Console.WriteLine($"Наибольший общий делитель чисел {nodEvklid.A}, {nodEvklid.B}, {nodEvklid.C}, {nodEvklid.D} и {nodEvklid.E} : {nodEvklid.Divisor}");
                   break;
               default:
                   Console.WriteLine("oooooooops! smth went wrong!");
                   break;
            }
        }

        static int ShowStartMenu()
        {
            int number;
            while (true)
            {
                Console.WriteLine("");
                Console.WriteLine("1 - Задание 1, вычисление НОД методом Евклида");
                Console.WriteLine("2 - Задание 2, вычисление НОД методом Стейна");
                Console.WriteLine("3 - Задание 3, вычисление НОД методом у 3 - 5 чисел");
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
            Console.WriteLine("");
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
                    case 2:
                        Task2();
                        break;
                    case 3:
                        Task3();
                        break;
                    case 4: Console.WriteLine("Сеанс окончен");
                        return;
                    default:
                        break;
                } 
            }
           
        }
    }
}