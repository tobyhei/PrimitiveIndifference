using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PrimitiveIndifferenceTest.Sample;

namespace PrimitiveIndifferenceTest
{
    [TestClass]
    public class UserNameTests
    {
        private const bool ShouldIgnoreCase = true;

        [TestMethod]
        public void Test_Username_Minimum_Length_Succeeds()
        {
            //Arrange
            const string usernameValue = "t";

            //Act
            var username = new UserName(usernameValue);

            //Assert
            Assert.AreEqual(usernameValue, username.ToString(), ShouldIgnoreCase);
        }

        [TestMethod]
        public void Test_Username_Maximum_Length_Succeeds()
        {
            //Arrange
            var usernameValue = new string('t', UserName.MaxUsernameLength);

            //Act
            var username = new UserName(usernameValue);

            //Assert
            Assert.AreEqual(usernameValue, username.ToString(), ShouldIgnoreCase);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Test_Username_Null_Throws()
        {
            //Arrange
            string usernameValue = null;

            //Act
            var disallowedUsername = new UserName(usernameValue);

            // Assert - Expects exception
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Test_Username_Zero_Length_Throws()
        {
            //Arrange
            var usernameValue = string.Empty;

            //Act
            var disallowedUsername = new UserName(usernameValue);

            // Assert - Expects exception
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Test_Username_Greater_Than_Maximum_Length_Throws()
        {
            //Arrange
            var usernameValue = new string('t', UserName.MaxUsernameLength+1);

            //Act
            var disallowedUsername = new UserName(usernameValue);

            // Assert - Expects exception
        }
    }
}
