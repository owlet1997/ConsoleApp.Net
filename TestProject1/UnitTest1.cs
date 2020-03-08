using System;
using System.Collections.Generic;
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
        
        /// <summary>
        /// //////////////////////////////////
        /// 
        /// </summary>
        [Test]
        public void TestCreatePolynom()
        {
            Polynom polynom1 = new Polynom(3,6);
            Polynom polynom2 = new Polynom(6,6);
            
            Assert.AreEqual(polynom1.P.Count,polynom2.P.Count);
            Assert.Pass();
        }
        
        [Test]
        public void TestSummaryPolynom()
        {
            Polynom polynom1 = new Polynom(3,6);
            Polynom polynom2 = new Polynom(6,6);

            Polynom polynom = polynom1.Summary(polynom2, "+");
            Assert.AreEqual("10x^1 + 20x^2 + 30x^3 + 20x^4 + 25x^5 + 30x^6",polynom.ToString());
            Assert.Pass();
        }
        
        [Test]
        public void TestSubstractionPolynom()
        {
            Polynom polynom1 = new Polynom(3,6);
            Polynom polynom2 = new Polynom(6,6);

            Polynom polynom = polynom1.Summary(polynom2, "-");

            Assert.AreEqual("-20x^4 + -25x^5 + -30x^6",polynom.ToString());
            Assert.Pass();
        }
        
        [Test]
        public void TestMultiplyByPolynom()
        {
            Polynom polynom1 = new Polynom(3,6);
            Polynom polynom2 = new Polynom(6,6);

            Polynom polynom = polynom1.MultiplyByPolynom(polynom2);

            Assert.AreEqual("25x^2 + 100x^3 + 250x^4 + 400x^5 + 550x^6 + 700x^7 + 675x^8 + 450x^9",polynom.ToString());
            Assert.Pass();
        }
        
        [Test]
        public void TestMultiplyBySingle()
        {
            Polynom polynom1 = new Polynom(3,6);

            Polynom polynom = polynom1.MultiplyBySingle(4,6);

            Assert.AreEqual("30x^5 + 60x^6 + 90x^7",polynom.ToString());
            Assert.Pass();
        }
    }
}