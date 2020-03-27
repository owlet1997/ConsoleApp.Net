using ConsoleApp1;
using NUnit.Framework;

namespace TestProject1
{
    public class TestClass
    {

        [Test]
        public void CheckCreateObject()
        {
            MaxCommonDivisor max = new MaxCommonDivisor(1,2);
            MaxCommonDivisor max1 = new MaxCommonDivisor(1,2, 3);
            MaxCommonDivisor max2 = new MaxCommonDivisor(1,2,3,4);
            MaxCommonDivisor max3 = new MaxCommonDivisor(1,2,3,4,5);
            
            Assert.Pass();
        }
        
        [Test]
        public void CheckNODEvklid()
        {
            MaxCommonDivisor max = new MaxCommonDivisor(14,7);

            Assert.AreEqual(7, max.NODEvklid());
            Assert.Pass();

        }
        
        [Test]
        public void CheckNODBinary()
        {
            MaxCommonDivisor max = new MaxCommonDivisor(225,15);

            Assert.AreEqual(15, max.NODBinary());
            Assert.Pass();
        }
        
        [Test]
        public void CheckNODThreeNumbers()
        {
            MaxCommonDivisor max = new MaxCommonDivisor(225,15, 25);
            Assert.AreEqual(5, max.Divisor);
            Assert.Pass();
        }
        
        [Test]
        public void CheckNODFourNumber()
        {
            MaxCommonDivisor max = new MaxCommonDivisor(8,16, 48, 64);
            Assert.AreEqual(8, max.Divisor);
            Assert.Pass();
        }
        
        [Test]
        public void CheckNODFiveNumber()
        {
            MaxCommonDivisor max = new MaxCommonDivisor(8,16,32, 48, 64);
            Assert.AreEqual(8, max.Divisor);
            Assert.Pass();
        }
    }
}