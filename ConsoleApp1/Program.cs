using System;
using System.Collections;

namespace ConsoleApp1
{
    class Program
    {
        static void GenerateDecimal(string s)
        {
            string[] numbers =  s.Split(new char[] {','},StringSplitOptions.RemoveEmptyEntries);
            decimal x = System.Convert.ToDecimal(numbers[0].Trim(' '));
            decimal y = System.Convert.ToDecimal(numbers[1].Trim(' '));
            Console.WriteLine("X:{0}, Y:{1}",x,y); 
        }
        
        static void Main(string[] args)
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
    }
}