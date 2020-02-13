using System;

namespace ConsoleApp1
{
    public class NewtonRoot
    {
        private double startNumber;
        const double EPS = 0.0000000001;
        private int n;
        private double calculatedResult;
        private double mathPowResult;
        private double dimension;
        
        public NewtonRoot(double startNumber, int n)
        {
            this.startNumber = startNumber;
            this.n = n;
            calculatedResult = CalculateRoot();
            mathPowResult = Math.Pow(startNumber,(double) 1/n);
            dimension = mathPowResult - calculatedResult;
        }

        public double StartNumber => startNumber;

        public int N => n;

        public double CalculatedResult => calculatedResult;
        
        public double MathPowResult => mathPowResult;

        public double Dimension => dimension;

        private double CalculateRoot()
        {
            double x0 = startNumber / n;
            double xk = 1;
            int count = 0;
            double A = startNumber;
            while (Math.Abs(x0 - xk)>EPS)
            {
                if (count>0) x0 = xk;
                xk = (n - 1) * x0 / n + A / (n * Math.Pow(x0, n - 1)); 
                //Console.WriteLine($"xk = {xk}");
                count++;
            }
            return xk;
        }
    }
}