using System;
using System.Collections;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        static void GenerateDecimal(string s)
        {
            string[] numbers =  s.Split(new[] {','},StringSplitOptions.RemoveEmptyEntries);
            decimal x = Convert.ToDecimal(numbers[0].Trim(' '));
            decimal y = Convert.ToDecimal(numbers[1].Trim(' '));
            Console.WriteLine("X:{0}, Y:{1}",x,y); 
        }

        static int ShowStartMenu()
        {
            int number;
            while (true)
            {
                Console.WriteLine("1 - enter data by console");
                Console.WriteLine("2 - enter data by file");
                Console.WriteLine("3 - exit");
                try
                {
                    number = Int32.Parse(Console.ReadLine());
                    if (number > 3 || number < 1)
                    {
                        Console.WriteLine("Wrong input");
                    }
                    else
                    {
                        break;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("You have to enter a number from 1 to 3");
                }
            }
            return number;
        }

        static void GetListFromConsole()
        {
            ArrayList list = new ArrayList();
            while (true)
            {
                string str = Console.ReadLine();
                if (str=="") break;
                list.Add(str);
            }
            
            Console.WriteLine("Координаты Х и У:");
            try
            {
                foreach (string v in list)
                {
                    GenerateDecimal(v);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
        
        static void GetListFromFile()
        {
            ArrayList list = new ArrayList();
            StreamReader sr=new StreamReader("/home/owlet/numbers.txt");
            string line;
            while (!sr.EndOfStream)
            {
                line=sr.ReadLine();
                list.Add(line);
            }
            sr.Close();
            Console.WriteLine("Координаты Х и У:");
            try
            {
                foreach (string v in list)
                {
                    GenerateDecimal(v);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
        
        static void Main(string[] args)
        {
            int action = ShowStartMenu();
            switch (action)
            {
                case 1: GetListFromConsole();
                    break;
                case 2: GetListFromFile();
                    break;
                case 3: Console.WriteLine("Bye");
                    break;
                default: Console.WriteLine("Error");
                    break;
            }
        }
    }
}