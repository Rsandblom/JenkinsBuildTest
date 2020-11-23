using System;
using Xunit;
using JenkinsBuildTest;

namespace JenkinsBuildTest.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            //Arrange
            int i = 3;

            //Act
            int j = Program.AddTwoNumbers(1, 2);

            //Assert
            Assert.Equal(i, j);

        }
    }
}
