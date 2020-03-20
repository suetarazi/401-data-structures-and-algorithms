using System;
using Xunit;
using BinarySearch;

namespace XUnitTestBinarySearch
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            int[] binaryArray = { 4, 8, 15, 16, 23, 42 };
            int key = 15;
            int actual = Program.BinarySearchIterative(binaryArray, key);
            int expected = 2;
            Assert.Equal(actual, expected);
        }
        
        [Fact]
        public void Test2()
        {
            int[] binaryArray = { 11, 22, 33, 44, 55, 66, 77, 88, 99 };
            int key = 42;
            int actual = Program.BinarySearchIterative(binaryArray, key);
            int expected = -1;
            Assert.Equal(actual, expected);
        }
    }
}
