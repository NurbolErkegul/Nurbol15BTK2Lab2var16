using System;
using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTestProject1
{
    [TestFixture]
    public class Assignment3Tests
    {
        private Assignment3 SortingHat;

        [SetUp]
        public void SetUp()
        {
            SortingHat = new Assignment3();
        }

        [Test]
        [TestCase("Penelopa")]
        [TestCase("Alexis")]
        public void SORTINGHAT_WizardNameIsInList_ReturnGryffindorOrPufindoyOrKogtevranOrSlyzerin(string WName)
        {
            //Arrange
            
            //Act
            var result = SortingHat.SORTINGHAT(WName);

            //Asset
            if (WName == "Harry")
            {
                Assert.That(result, Is.TypeOf<Gryffindor>());
                Assert.That(result, Is.InstanceOf<Gryffindor>());
            }
            if (WName == "Kandydi")
            {
                Assert.That(result, Is.TypeOf<Kogtevran> ());
                Assert.That(result, Is.InstanceOf<Kogtevran>());
            }

            if (WName == "Penelopa")
            {
                Assert.That(result, Is.TypeOf<Puffenduy>());
                Assert.That(result, Is.InstanceOf<Puffenduy>());
            }

            else
            {
                Assert.That(result, Is.TypeOf<Slyzerin>());
                Assert.That(result, Is.InstanceOf<Slyzerin>());
            }
            
        }

        [Test]
        public void SORTINGHAT_WizardNameIsInList_ReturnGryffindorOrPufindoyOrKogtevranOrSlyzerin()
        {

        }
    }
}

