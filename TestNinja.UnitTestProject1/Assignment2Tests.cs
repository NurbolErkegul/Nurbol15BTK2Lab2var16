using System;
using System.Linq;
using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTestProject1
{
    [TestFixture]
    public class Assignment2Tests
    {
        private Assignment2 LoveTest;

        [SetUp]
        public void SetUp()
        {
            LoveTest = new Assignment2();
        }
        [Test]
        [TestCase("Еркын","Аружан")]
        public void LoveDuo_BoyFriendGreaterThanGirlfriend_ReturnLoveDuoUpToLOVEDUOS(string Boy,string Girl)
        {
            //Arrange

            //Act
            var result = LoveTest.LoveDuo(Boy,Girl);

            //Assert
            Assert.That(result, Is.Not.Empty);
            
            Assert.That(result.Count(), Is.EqualTo(2));
            if (Boy.Length >= Girl.Length)
            {
                Assert.That(result, Does.Contain(Boy));
                Assert.That(result, Does.Contain(Girl));
            }
            else
            {
                Assert.That(result, Does.Contain("Do not have Cool Name"));
                Assert.That(result, Does.Contain(Girl));
            }
            Assert.That(result, Is.Unique);
        }
    }
}
