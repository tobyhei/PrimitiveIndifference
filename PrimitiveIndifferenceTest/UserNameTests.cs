using System;
using NUnit.Framework;
using PrimitiveIndifferenceTest.Sample;

namespace PrimitiveIndifferenceTest
{
    [TestFixture]
    public class UserNameTests
    {
        [Test]
        public void Test_Username_Minimum_Length_Succeeds()
        {
            //Arrange
            const string usernameValue = "t";

            //Act
            var username = new UserName(usernameValue);

            //Assert
            StringAssert.AreEqualIgnoringCase(usernameValue, username);
        }

        [Test]
        public void Test_Username_Maximum_Length_Succeeds()
        {
            //Arrange
            var usernameValue = new string('t', UserName.MaxUsernameLength);

            //Act
            var username = new UserName(usernameValue);

            //Assert
            StringAssert.AreEqualIgnoringCase(usernameValue, username);
        }

        [Test]
        public void Test_Username_Null_Throws()
        {
            //Arrange
            string usernameValue = null;

            //Act
            TestDelegate testDelegate = () => new UserName(usernameValue);

            // Assert
            Assert.That(testDelegate, Throws.TypeOf<ArgumentNullException>());
    }

        [Test]
        public void Test_Username_Zero_Length_Throws()
        {
            //Arrange
            var usernameValue = string.Empty;

            //Act
            TestDelegate testDelegate = () => new UserName(usernameValue);

            // Assert 
            Assert.That(testDelegate, Throws.TypeOf<ArgumentException>());
        }

        [Test]
        public void Test_Username_Greater_Than_Maximum_Length_Throws()
        {
            //Arrange
            var usernameValue = new string('t', UserName.MaxUsernameLength+1);

            //Act
            TestDelegate testDelegate = () => new UserName(usernameValue);

            // Assert 
            Assert.That(testDelegate, Throws.TypeOf<ArgumentOutOfRangeException>());
        }
    }
}
