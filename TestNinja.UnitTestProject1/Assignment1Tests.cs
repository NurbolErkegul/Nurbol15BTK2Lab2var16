using System;
using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTestProject1
{
    
    [TestFixture]
    public class Assignment1Tests
    {
        private Assignment1 UserW;

        [SetUp]
        public void SetUp()
        {
            UserW = new Assignment1();
        }

        [Test]
        [TestCase("")]
        [TestCase("AbadaKedabra!")]
        public void TestTheWordOfLength_WhenCalled_ShowLengthofWordUserheStringWithEmptyElement(string word)
        {
            var result = UserW.TestTheWordOfLength(word);

            if (word.Length > 0)
            {
                //Specific
                Assert.That(result, Is.EqualTo($"<>{word}</>").IgnoreCase);

                //More General
                Assert.That(result, Does.StartWith("<>").IgnoreCase);
                Assert.That(result, Does.Contain(word).IgnoreCase);
                Assert.That(result, Does.EndWith("</>").IgnoreCase);
            }
            else
            {
                //Specific
                Assert.That(result, Is.EqualTo("<>Введите волшебное слово!</>").IgnoreCase);

                //More General
                Assert.That(result, Does.StartWith("<>").IgnoreCase);
                Assert.That(result, Does.Contain("Введите волшебное слово!").IgnoreCase);
                Assert.That(result, Does.EndWith("</>").IgnoreCase);
            }
        }


    }
}
