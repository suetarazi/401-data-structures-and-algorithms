using Microsoft.VisualStudio.TestPlatform.TestHost;
using System;
using Xunit;
using Xunit.Sdk;
using array_shift;
using Program = array_shift.Program;

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
            //int[] myArray = Program.Populate(6);

            // Assert
            //Assert.Equal(6, myArray.Length);

        }

        [Fact]
        public void TestArrayShift_test1()
        {
            int[] testArr = new int[] { 2, 4, 6, 8 };
            int value = 5;
            Program p = new Program();
            int[] actual = p.BuildNewArray2(testArr, value);
            int[] expected = new int[] { 2, 4, 5, 6, 8 };
            Assert.Equal(expected.ToString(), actual.ToString());
        }

        [Fact]
        public void TestArrayShift_test2()
        {
            int[] testArr = new int[] { 4, 8, 15, 23, 42 };
            int value = 16;
            Program p = new Program();
            int[] actual = p.BuildNewArray2(testArr, value);
            int[] expected = new int[] { 4, 8, 15, 16, 23, 42 };
            Assert.Equal(expected.ToString(), actual.ToString());

        }
    }
}
