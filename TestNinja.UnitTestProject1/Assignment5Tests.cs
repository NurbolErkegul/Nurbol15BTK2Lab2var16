using System;
using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTestProject1
{
    [TestFixture]
    public class Assignment5Tests
    {
        private Assignment5 SystemStatus;

        [SetUp]
        public void SetUp()
        {
            SystemStatus = new Assignment5();
        }
        [Test]
        [TestCase("РыбаМечь")]
        public void Log_WhenCalled_SetTheLastErrorProperty(string status)
        {
            //Arrange

            //Act
            SystemStatus.SystemRUN(status);

            //Assert
            Assert.That(SystemStatus.SystemName, Is.EqualTo(status));
        }

        [Test]
        [TestCase(null)]
        [TestCase("")]
        [TestCase(" ")]
        public void Log_InvalidError_ThrowArgumentNullExeption(string WordForOutSystem)
        {
            //Arrange
            
            //Act
            //loger.log(error)

            //Assert
            Assert.That(() => SystemStatus.SystemRUN(WordForOutSystem), Throws.ArgumentNullException);
            //Assert.That(() => logger.Log(error), Throws.ArgumentNullException);

        }
    }
}
