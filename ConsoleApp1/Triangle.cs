using System;

namespace ConsoleApp1
{
    public class Triangle
    {
        private int a;
        private int b;
        private int c;
        private double square;
        private double perimetr;

        public int A => a;

        public int B => b;

        public int C => c;

        public double Square => square;

        public double Perimetr => perimetr;

        public Triangle(int a)
        {
            this.a = a;
            b = a;
            c = a;
            perimetr = A * 3;
            square = Math.Round(Math.Pow(a,2)*Math.Sqrt(3)/4, 2);
        }

        public Triangle(int a, int c)
        {
            if (a*2 < c || a < 0 || c < 0)
            {
              throw new Exception("Неверно указаны стороны треугольника!");
            }
            this.a = a;
            b = a;
            this.c = c;
            perimetr = A * 2 + C;
            square = Math.Round(Math.Sqrt(Perimetr/2 * (Perimetr/2 - A) * (Perimetr/2 - B) * (Perimetr/2 - C)),2);

        }

        public Triangle(int a, int b, int c)
        {
            if ( a + b < c|| a < 0 || c < 0 || b < 0)
            {
                throw new Exception("Неверно указаны стороны треугольника!");
            }
            this.a = a;
            this.b = b;
            this.c = c;
            perimetr = A + B + C;
            square = Math.Round(Math.Sqrt(Perimetr/2 * (Perimetr/2 - A) * (Perimetr/2 - B) * (Perimetr/2 - C)),2);
        }
    }
}