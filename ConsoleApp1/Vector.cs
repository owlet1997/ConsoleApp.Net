using System;
using System.Text;

namespace ConsoleApp1
{
    public class Vector
    {
        private int x;
        private int y;
        private int z;
        private double length;

        public Vector(int x, int y, int z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
            length = Math.Round(Math.Sqrt(x*x + y*y + z*z));
        }

        public Vector Summary(Vector vector)
        {
            return new Vector(x + vector.x, y + vector.y, z + vector.z);
        }

        public Vector Substraction(Vector vector)
        {
            return new Vector(x - vector.x, y - vector.y, z - vector.z);
        }

        public Vector MultiplyByNumber(int number)
        {
            return new Vector(x*number, y*number, z*number);
        }

        public double ScalarMultiply(Vector vector)
        {
            int mult = x * vector.x + y * vector.y + z * vector.z;
            double cos =  (x * vector.x + y * vector.y + z * vector.z) /
                         (Math.Sqrt(x * x + y * y + z * z) * Math.Sqrt(vector.x * vector.x + vector.y * vector.y +
                                                                       vector.z * vector.z));
            return mult * cos;
        }

        public Vector VectorMultiply(Vector vector)
        {
            return new Vector(y*vector.z - z*vector.y,z*vector.x - x*vector.z, x*vector.y - y*vector.x);
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder("Vector: {");
            builder.Append(x);
            builder.Append(", ");
            builder.Append(y);
            builder.Append(", ");
            builder.Append(z);
            builder.Append("}\n");
            builder.Append("Length = ");
            builder.Append(length);
            return builder.ToString();
        }
    }
}
//academytlt.ru - новая платформа