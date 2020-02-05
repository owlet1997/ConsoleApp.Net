using System;
using System.Collections;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
           ArrayList list = new ArrayList();
           string str = Console.ReadLine();

            while (str != null && !str.Equals(""))
            {
                str = Console.ReadLine();
                if (str!="")
                list.Add(str);
            }
            
            foreach (string v in list)
                Console.WriteLine(v);
            
            Console.WriteLine("Координаты Х и У:");
            try
            {
                foreach (string v in list)
                {
                    string[] numbers =  v.Split(new char[] {','},StringSplitOptions.RemoveEmptyEntries);
                    decimal x = System.Convert.ToDecimal(numbers[0].TrimStart(' ').Replace('.',','));
                    decimal y = System.Convert.ToDecimal(numbers[1].TrimStart(' ').Replace('.',','));
                    Console.WriteLine("X:{0}, Y:{1}",x,y);
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}