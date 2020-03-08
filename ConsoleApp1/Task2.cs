using System;

namespace ConsoleApp1
{
    public class Task2
    {
        static Polynom GetObject(int n, int maxGrade)
        {
            Polynom p = new Polynom();
            int grade;
            int value;
            for (int i = 0; i < n; i++)
            {
                grade = Util.GetNumberForPolynom($"Введите степень {i+1} члена многочлена",maxGrade);
                while (p.P.ContainsKey(grade)) 
                    grade = Util.GetNumberForPolynom("Степень уже используется, введите другую", maxGrade);
                value = Util.GetNumber($"Введите коэффициент {i+1} члена многочлена");
                p.addNom(grade,value);
            }

            for (int i = 0; i <= maxGrade; i++)
            {
                if (!p.P.ContainsKey(i))
                    p.addNom(i,0);
            }

            return p;
        }

        
        public static void task2()
        {
            var maxGrade = Util.GetNumber("Введите наивысшую степень, используемую в многочленах");
            var n1 = Util.GetNumberForPolynom("Введите размерность первого многочлена",maxGrade);
            Polynom polynom1 = GetObject(n1,maxGrade);
            var n2 = Util.GetNumberForPolynom("Введите размерность второго многочлена",maxGrade);
            Polynom polynom2 = GetObject(n2,maxGrade);
        
            Console.WriteLine(polynom1);
            Console.WriteLine(polynom2);
            
            while (true)
            {
                int chosen = Util.ShowPolynomInnerMenu();
                switch (chosen)
                {
                    case 1: 
                        Console.WriteLine(polynom1.Summary(polynom2,"+"));
                        break;
                    case 2: 
                        Console.WriteLine(polynom1.Summary(polynom2,"-"));
                        break;
                    case 3:  
                        int grade = Util.GetNumber("Введите степень одночлена");
                        int value = Util.GetNumber("Введите коэффициент одночлена");
                        Console.WriteLine(polynom1.MultiplyBySingle(grade,value));
                        break;
                    case 4: 
                        Console.WriteLine(polynom1.MultiplyByPolynom(polynom2));
                        break;
                    case 5: return;
                  
                }    
            }
        }

    }
}