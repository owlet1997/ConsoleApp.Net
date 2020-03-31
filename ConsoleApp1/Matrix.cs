using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    public class Matrix
    {
        int[,] arr;
        // Размерность двухмерного массива

        public int rows, cols;

        public Matrix(int rows, int cols)
        {
            if (rows <= 0 || cols <= 0) throw new MyException(rows, cols);
            this.rows = rows;
            this.cols = cols;
            arr = new int[this.rows, this.cols];
        }

        public int Rows => rows;

        public int Cols => cols;

        // Индексатор
        public int this[int index1, int index2]
        {
            get
            {
                return arr[index1, index2];
            }

            set
            {
                arr[index1, index2] = value;
            }
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder("");
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Cols; j++)
                {
                    builder.Append(this[i, j]);
                    builder.Append(" ");
                }
                builder.Append("\n");
            }
            return builder.ToString();
        }
        
        public Matrix Summary(Matrix matrix)
        {
            if (Rows!=matrix.Rows || Cols != matrix.Cols) throw new MyException(Rows, matrix.Rows);
            
            Matrix newMatrix = new Matrix(Rows,Cols);

            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Cols; j++)
                {
                    newMatrix[i, j] = this[i,j] + matrix[i,j];
                }
            }

            return newMatrix;
        }
        
        public Matrix Substraction(Matrix matrix)
        {
            if (Rows!=matrix.Rows || Cols != matrix.Cols) throw new MyException(Rows, matrix.Rows);
            
            Matrix newMatrix = new Matrix(Rows,Cols);

            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Cols; j++)
                {
                    newMatrix[i, j] = this[i,j] - matrix[i,j];
                }
            }

            return newMatrix;
        }
        
        public Matrix Multiply(Matrix matrix)
        {
            if (Cols!=matrix.Rows) throw new MyException(Cols, matrix.Rows);
            
            Matrix newMatrix = new Matrix(Rows,matrix.Cols);

            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < matrix.Cols; j++)
                {
                    for (int k = 0; k < Rows; k++)
                    {
                        newMatrix[i, j] += this[i, k] * matrix[k, j];
                    }
                }
            }
            return newMatrix;
        }

        public static Matrix GetEmpty(int row, int col)
        {
            Matrix emptyMatrix = new Matrix(row,col);

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    emptyMatrix[i, j] = 0;
                }
            }

            return emptyMatrix;
        }
    }
    
    

}