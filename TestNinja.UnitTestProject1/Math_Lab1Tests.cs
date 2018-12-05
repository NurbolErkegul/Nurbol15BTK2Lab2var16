using System;
using TestNinja.Fundamentals;
using NUnit.Framework;

namespace TestNinja.UnitTestProject1
{
    [TestFixture]
    public class Math_Lab1Tests
    {
        private Math_Lab1 _math;
        [SetUp]
        public void SetUp()
        {
            _math = new Math_Lab1();
        }

        [Test]
        [TestCase(15, 5, true)]
        [TestCase(10, 5, false)]
        [TestCase(10, 5, true)]

        public void IsDifferenceDivisibleBy10_IsDifferenceDivisibleBy10_ReturnsTrue(int a, int b, bool expectedResult)
            {
                
                //Act
                var result = _math.IsDifferenceDivisibleBy10(a,b);
            //Assert
            Assert.That(result == expectedResult);
        }


      
       
    }
}
