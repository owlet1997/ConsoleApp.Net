using System;
using System.Diagnostics;

namespace ConsoleApp1
{
    public class NODEvklid
    {
        private int a;
        private int b;
        private int c;
        private int d;
        private int e;
        private int n;
        private int divisor;

        public NODEvklid(int a, int b)
        {
            this.a = a;
            this.b = b;
            this.n = 2;
        }

        public NODEvklid(int a, int b, int c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            this.n = 3;
            divisor = Calculate(a, b, c);
        }

        public NODEvklid(int a, int b, int c, int d)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            this.d = d;
            this.n = 4;
            divisor = Calculate(a, b, c, d);
        }

        public NODEvklid(int a, int b, int c, int d, int e)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            this.d = d;
            this.e = e;
            this.n = 5;
            divisor = Calculate(a, b, c, d, e);
        }

        private int Calculate(int a, int b)
        {
            int temp;
            do
            {
                temp = a % b;
                a = b;
                b = temp;
            } 
            while (temp != 0);

            return a;
        }

        private int CalculateBinary(int a, int b)
        {
            int k = 1;
            while (a != 0 && b != 0)
            {
                while (a % 2 == 0 && b % 2 == 0)
                {
                    a >>= 1;
                    b >>= 1;
                    k <<= 1;
                }

                while (a % 2 == 0)  a >>= 1;
                while (b % 2 == 0)  b >>= 1;

                if (a >= b) a -= b;
                else b -= a;
            }
            return b * k;
        }

        public int NODBinaryTime()
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            var result = CalculateBinary(A, B);
            sw.Stop();
            var time = sw.ElapsedMilliseconds;
            Console.WriteLine("НОД рассчитывается алгоритмом Стейна");
            Console.WriteLine($"Время подсчета {(double)time/1000} microseconds");
            return result;
        }
        
        public int NODEvklidTime()
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            var result = Calculate(A, B);
            sw.Stop();
            var time = sw.ElapsedMilliseconds;
            Console.WriteLine("НОД рассчитывается алгоритмом Евклида");
            Console.WriteLine($"Время подсчета {(double)time/1000} microseconds");
            return result;
        }
        
        private int Calculate(int a, int b, int c)
        {
            return  Calculate(Calculate(a, b),c);
        }
        
        private int Calculate(int a, int b, int c, int d)
        {
            return  Calculate(Calculate(a, b, c),d);
        }
        
        private int Calculate(int a, int b, int c, int d, int e)
        {
            return  Calculate(Calculate(a, b, c, d),e);
        }

        public int A => a;

        public int B => b;

        public int C => c;

        public int D => d;

        public int E => e;

        public int N => n;

        public void setDivisor(int value)
        {
            this.divisor = value;
        }

        public int Divisor => divisor;
    }
}