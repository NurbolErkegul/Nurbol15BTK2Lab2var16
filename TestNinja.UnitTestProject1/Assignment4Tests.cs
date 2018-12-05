using System;
using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTestProject1
{
    [TestFixture]
    public class Assignment4Tests
    {
        private Assignment4 LNumbers;

        [SetUp]
        public void SetUp()
        {
            LNumbers = new Assignment4();
        }

        [Test]
        [TestCase(8)]
        public void LUCKYNUMBERS_WhenCalled_SetTheLuckyNumberProperty(double LRN)
        {
            //Arrange


            //Act
            LNumbers.LUCKYNUMBERS(LRN);

            //Assert
            Assert.That(LNumbers.LuckyNumber, Is.EqualTo(LRN));
        }

        
    }
}
