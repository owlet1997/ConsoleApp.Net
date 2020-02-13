using System;
using System.Text;

namespace ConsoleApp1
{
    public class ConvertToBinary
    {
        private int startNumber;
        private string calcResult;
        private string functionResult;

        public string FunctionResult => functionResult;

        public ConvertToBinary(int startNumber)
        {
            this.startNumber = startNumber;
            calcResult = ConvertBinary();
            functionResult = Convert.ToString(startNumber, 2);
        }

        public int StartNumber => startNumber;

        public string CalcResult => calcResult;

        private string ConvertBinary()
        {
            string str = "";
            StringBuilder builder = new StringBuilder(str);
            int x = startNumber;
            while (x > 0)
            {
                int temp = x % 2;
                x/=2;
                builder.Append(temp);
            }

            char[] array = builder.ToString().ToCharArray();
            Array.Reverse(array);
            return new string(array);
        }
    }
}