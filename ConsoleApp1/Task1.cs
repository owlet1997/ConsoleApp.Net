using System;

namespace ConsoleApp1
{
    public class Task1
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
        
        public static void task1()
        {
            Vector vector1 = GetObject("1");
            Vector vector2 = GetObject("2");
            Console.WriteLine(vector1);
            Console.WriteLine(vector2);
            
            while (true)
            {
                int chosen = Util.ShowVectorInnerMenu();
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
    }
}