using Microsoft.VisualStudio.TestPlatform.TestHost;
using System;
using Xunit;
using BubbleSort;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void TestArrayForSort()
        {
            BubbleSort.Program p = new BubbleSort.Program();
            int[] testArr = new int[] { 5, 1, 2, 8, 4 };
            int[] actual = p.BubbleSortMethod(testArr);
            int[] expected = new int[] { 1, 2, 4, 5, 8 };
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestEvenLengthArrayForSort()
        {
            BubbleSort.Program p = new BubbleSort.Program();
            int[] testArr = new int[] { 5, 1, 2, 8, 4, 7 };
            int[] actual = p.BubbleSortMethod(testArr);
            int[] expected = new int[] { 1, 2, 4, 5, 7, 8 };
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestNegativeIntInArrayForSort()
        {
            BubbleSort.Program p = new BubbleSort.Program();
            int[] testArr = new int[] { 5, -1, 2, 8, 4 };
            int[] actual = p.BubbleSortMethod(testArr);
            int[] expected = new int[] { -1, 2, 4, 5, 8 };
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestEmptyArraySort()
        {
            BubbleSort.Program p = new BubbleSort.Program();
            int[] emptyArray = new int[] { };
            int[] actual = p.BubbleSortMethod(emptyArray);
            int[] expected = new int[] { };
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestNullArray()
        {
            BubbleSort.Program p = new BubbleSort.Program();
            int[] actual = p.BubbleSortMethod(null);
            //int[] expected = new int[] { };
            Assert.Throws<InvalidOperationException>((), actual);
                
        }

        //other things to test:
        //even length array vs odd length array
        //already sorted array
        //array sorted backwards
        //array of length 1
        //negative values
        //int.maxvalue, int.minvalue, powers of 2
        //duplicate values in an array

    }
}
