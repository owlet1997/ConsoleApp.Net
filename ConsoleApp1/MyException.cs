using System;
using System.Runtime.Serialization;

namespace ConsoleApp1
{
    [Serializable()]
    public class MyException : Exception
    {
        private int rows;
        private int cols;
        
        public MyException(int rows, int cols) :
            base(String.Format("Operation with {0} rows and {1} cols can't be resolved.", rows, cols))
        {
            this.rows = rows;
            this.cols = cols;
        }
        
        public MyException(int rows, int cols, string message) :
            base(message)
        {
            this.rows = rows;
            this.cols = cols;
        }
        
        public MyException(int rows, int cols, string message, Exception innerException) :
            base(message, innerException)
        {
            this.rows = rows;
            this.cols = cols;
        }

        protected MyException(SerializationInfo info,
            StreamingContext context)
            : base(info, context){ }

        public int Rows => rows;

        public int Cols => cols;
    }
}