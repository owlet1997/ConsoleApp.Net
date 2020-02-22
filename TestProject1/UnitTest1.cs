using System;
using ConsoleApp1;
using NUnit.Framework;

namespace TestProject1
{
    public class Tests
    {
        [Test]
        public void TestCreateEqualTriangle()
        {
            Triangle triangle = new Triangle(3);
            Assert.AreEqual(3.9, triangle.Square);
            Assert.AreEqual(9, triangle.Perimetr);
            
            Assert.Pass();
        }
        
        [Test]
        public void TestCreateSquareTriangle()
        {
            Triangle triangle = new Triangle(4,7);
            Assert.AreEqual(6.78, triangle.Square);
            Assert.AreEqual(15, triangle.Perimetr);
            
            Assert.Pass();
        }
        
        [Test]
        public void TestCreateFirstFalseTriangles()
        {
            try
            {
                Triangle triangle1 = new Triangle(4, 3, 9);
                Assert.Fail(); 
            }
            catch (Exception e)
            {
                Assert.Pass();
            }
            
            
        }
        
        [Test]
        public void TestCreateSecondFalseTriangles()
        {
            try
            {
                Triangle triangle1 = new Triangle(-4, 9);
                Assert.Fail();
            }
            catch (Exception e)
            {
                Assert.Pass();
            }
            
        }
        
        [Test]
        public void TestCreateFalseTriangles()
        {
            try
            {
                Triangle triangle1 = new Triangle(2, 9);
                Assert.Fail();
            }
            catch (Exception e)
            {
                Assert.Pass();
            }

        }
        
        [Test]
        public void TestCreateThreeOrMore()
        {
            Triangle triangle = new Triangle(3,4,5);
            Assert.AreEqual(6, triangle.Square);
            Assert.AreEqual(12, triangle.Perimetr);

            Assert.Pass();
        }
        
    }
}