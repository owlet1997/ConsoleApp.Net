using System;
using System.Collections;
using System.IO;

namespace ConsoleApp1
{
    class NewtonRoot
    {
        private double startNumber;
        const double EPS = Double.Epsilon;
        private int n;
        private double result;

        public NewtonRoot(double startNumber, int n)
        {
            this.startNumber = startNumber;
            this.n = n;
            this.result = CalculateRoot();
        }

        public double StartNumber => startNumber;

        public double Result => result;

        private double CalculateRoot()
        {
            double x = 1;
            while (true)
            {
                double nx = (x + this.n / x) / 2;
                if (Math.Abs(x - nx) < EPS) break;
                x = nx;
            }
            return x;
        }
    }
    class Program
    {
        static int ShowStartMenu()
        {
            double number;
            while (true)
            {
                Console.WriteLine("Enter a number:");
                try
                {
                    number = Double.Parse(Console.ReadLine());
                    if (number < 0)
                    {
                        Console.WriteLine("Number has to be pozitive");
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