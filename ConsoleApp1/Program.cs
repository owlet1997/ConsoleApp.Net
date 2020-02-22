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
        static Triangle GetObject()
        {
            int a, b, c;
            bool isEqual = Util.IsEqual("Треугольник равноcторонний?");
            if (isEqual)
            {
                a = Util.GetNumber(null);
                Triangle triangle = new Triangle(a);
                return triangle;
            }
            
            bool isSquare = Util.IsEqual("Треугольник равнобедренный?");

            if (isSquare)
            { 
                a = Util.GetNumber(null);
                c = Util.GetNumber(a + a);
                Triangle triangle1 = new Triangle(a,c);
                return triangle1;
            }
            
            a = Util.GetNumber(null);
            b = Util.GetNumber(null);
            c = Util.GetNumber(a + b);
            
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
        
        static void Main(string[] args)
        {
            while (true)
            {
                int chosen = Util.ShowStartMenu();
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