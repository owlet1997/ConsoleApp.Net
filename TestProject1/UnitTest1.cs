using System;
using System.Collections.Generic;
using ConsoleApp1;
using NUnit.Framework;

namespace TestProject1
{
    public class Tests
    {
        [Test]
        public void createFalse1Matrix()
        {
            try
            {
                Matrix matrix = new Matrix(0, 7);
            }
            catch (MyException e)
            {
                Assert.Pass();
            }
        }
        
        [Test]
        public void createFalse2Matrix()
        {
            try
            {
                Matrix matrix = new Matrix(-1, 7);
            }
            catch (MyException e)
            {
                Assert.Pass();
            }
        }
        
        [Test]
        public void createFalse3Matrix()
        {
            try
            {
                Matrix matrix = new Matrix(7, -7);
            }
            catch (MyException e)
            {
                Assert.Pass();
            }
        }
        
        [Test]
        public void createMatrix()
        {
            Matrix matrix = new Matrix(2, 7);
            Assert.Pass();
        }
        
        [Test]
        public void substractionFalseMatrix()
        {
            Matrix matrix1 = Program.getInstanceFromRandom(2, 7);
            Matrix matrix2 = Program.getInstanceFromRandom(3, 7);
            
            try
            {
                Matrix matrix = matrix1.Substraction(matrix2);
            }
            
            catch (MyException e)
            {
                Assert.Pass();
            }
        }
        
        [Test]
        public void summaryFalseMatrix()
        {
            Matrix matrix1 = Program.getInstanceFromRandom(2, 7);
            Matrix matrix2 = Program.getInstanceFromRandom(3, 7);
            
            try
            {
                Matrix matrix = matrix1.Multiply(matrix2);
            }
            
            catch (MyException e)
            {
                Assert.Pass();
            }
        }
        
        [Test]
        public void multiplyFalseMatrix()
        {
            Matrix matrix1 = Program.getInstanceFromRandom(2, 7);
            Matrix matrix2 = Program.getInstanceFromRandom(4, 5);
            
            try
            {
                Matrix matrix = matrix1.Multiply(matrix2);
            }
            
            catch (MyException e)
            {
                Assert.Pass();
            }
        }
        
        [Test]
        public void SummaryMatrix()
        {
            Matrix matrix1 = Program.getInstanceFromRandom(4, 5);
            Matrix matrix2 = Program.getInstanceFromRandom(4, 5);

            Matrix matrix = matrix1.Summary(matrix2);
            Assert.Pass();
        }
        
        [Test]
        public void SubstractionMatrix()
        {
            Matrix matrix1 = Program.getInstanceFromRandom(4, 5);
            Matrix matrix2 = Program.getInstanceFromRandom(4, 5);

            Matrix matrix = matrix1.Substraction(matrix2);
            Assert.Pass();
        }

        [Test]
        public void MultiplyMatrix()
        {
            Matrix matrix1 = Program.getInstanceFromRandom(4, 5);
            Matrix matrix2 = Program.getInstanceFromRandom(5, 6);

            Matrix matrix = matrix1.Multiply(matrix2);
            Assert.Pass();
        }
    }
}