using System;
using System.Reflection.Metadata;

namespace ConsoleApp1
{
    public class Program
    {
        static Matrix getInstanceFromConsole(int rows, int cols)
        {
            Matrix matrix = new Matrix(rows,cols);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = Util.GetNumber();
                }
            }

            return matrix;
        }
        
        public static Matrix getInstanceFromRandom(int rows, int cols)
        {
            Matrix matrix = new Matrix(rows,cols);
            Random random = new Random();
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = random.Next(0,50);
                }
            }

            return matrix;
        }

        static Matrix getMatrix(string number)
        {
            Console.WriteLine("Введите размеры {0} матрицы",number);
            int rows1 = Util.GetNumber();
            int cols1 = Util.GetNumber();
            
            Matrix matrix;
            
            while (true)
            {
                int chosen = Util.ShowStartMenu();
                switch (chosen)
                {
                    case 1: 
                        matrix = getInstanceFromConsole(rows1,cols1);
                        return matrix;
                    case 2: 
                        matrix = getInstanceFromRandom(rows1,cols1);
                        return matrix;
                    case 3: 
                        matrix = Matrix.GetEmpty(rows1,cols1);
                        return matrix;
                    case 4: Console.WriteLine("Сеанс окончен");
                        return null;
                }    
            }
        }

        static void Task()
        {
            Matrix matrix1 = getMatrix("1");
            Matrix matrix2 = getMatrix("2");
            
            Console.WriteLine("Первая матрица");
            Console.WriteLine(matrix1);
            Console.WriteLine("Вторая матрица");
            Console.WriteLine(matrix2);
            
            while (true)
            {
                int chosen = Util.ShowInnerMenu();
                switch (chosen)
                {
                    case 1: Console.WriteLine(matrix1.Summary(matrix2));
                        break;
                    case 2: Console.WriteLine(matrix1.Substraction(matrix2));
                        break;
                    case 3: Console.WriteLine(matrix1.Multiply(matrix2));
                        break;
                    case 4: return;
                }    
            }
        }

        public static void Main(string[] args)
        {
            Task();
        }
    }
}