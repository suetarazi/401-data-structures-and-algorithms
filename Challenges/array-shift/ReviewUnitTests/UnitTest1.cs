using System;
using Xunit;

namespace ReviewUnitTests
{
    public class UnitTest1
    {
        [Fact]
        public void ArrayIsPopulated()
        {
            // We are going to m ake a call out to the populate method and make sure
            //that the array populated is the same length as the number we sent it.

            // Arrange & Act
            int[] myArray = Program.Populate(6);

            // Assert
            Assert.Equal(6, myArray.Length);

        }
    }
}
