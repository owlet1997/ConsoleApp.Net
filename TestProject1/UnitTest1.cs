using System;
using ConsoleApp1;
using NUnit.Framework;

namespace TestProject1
{
    public class Tests
    {
        [Test]
        public void TestCreateVector()
        {
            Vector vector = new Vector(1, 7, -7);
            
            Assert.AreEqual(9.95,vector.Length);
            Assert.Pass();

        }
        
        [Test]
        public void TestVectorsSummary()
        {
            Vector vector = new Vector(1, 10, 9);
            Vector vector1 = new Vector(6, 5, 6);
            Vector result = vector.Summary(vector1);
            
            Assert.AreEqual(22.34,result.Length);
            Assert.Pass();
        }
        
        [Test]
        public void TestVectorsSubstraction()
        {
            Vector vector = new Vector(5, 6, 9);
            Vector vector1 = new Vector(2, 10, 9);
            Vector result = vector.Substraction(vector1);
            
            Assert.AreEqual(5,result.Length);
            Assert.Pass();
        }
        
        [Test]
        public void TestVectorMultiplyByNumber()
        {
            Vector vector = new Vector(5, 6, 9);
            Vector result = vector.MultiplyByNumber(5);
            
            Assert.AreEqual(59.58,result.Length);
            Assert.Pass();
        }
        
        [Test]
        public void TestVectorsScalarGeometryMultiply()
        {
            Vector vector = new Vector(5, 6, 9);
            Vector vector1 = new Vector(2, 10, 9);
            var result = vector.ScalarGeometryMultiply(vector1);
            
            Assert.AreEqual(140.68,result);
            Assert.Pass();
        }
        
        [Test]
        public void TestVectorsScalarMultiply()
        {
            Vector vector = new Vector(5, 6, 9);
            Vector vector1 = new Vector(2, 10, 9);
            var result = vector.ScalarMultiply(vector1);
            
            Assert.AreEqual(151,result);
            Assert.Pass();
        }
        
        [Test]
        public void TestVectorMultiplyByVector()
        {
            Vector vector = new Vector(5, 6, 9);
            Vector vector1 = new Vector(2, 10, 9);
            Vector result = vector.VectorMultiply(vector1);
            Vector expectedResult = new Vector(-36,-27,38);
            
            Assert.AreEqual(expectedResult.Length,result.Length);
            Assert.Pass();
        }
        
        
        
    }
}