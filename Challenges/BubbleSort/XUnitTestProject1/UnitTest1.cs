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
        public void TestEmptyArraySort()
        {
            BubbleSort.Program p = new BubbleSort.Program();
            int[] emptyArray = new int[] { };
            int[] actual = p.BubbleSortMethod(emptyArray);
            int[] expected = new int[] { };
            Assert.Equal(expected, actual);
        }

        public void TestCharArray()
        {
            BubbleSort.Program p = new BubbleSort.Program();
            char[] charArray = new char[] { 'c', 'a', 't' };
            int[] actual = p.BubbleSortMethod(charArray);
            int[] expected = new int[] { };
            Assert.Equal(expected, actual);

        }

    }
}
