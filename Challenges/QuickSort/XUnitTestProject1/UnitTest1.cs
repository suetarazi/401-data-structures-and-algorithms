using System;
using Xunit;
using QuickSort;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        /// <summary>
        /// tests to sort a given array by calling SortQuick method
        /// </summary>
        [Fact]
        public void CanQuickSortArray1()
        {
            int[] arr = { 8, 4, 23, 42, 16, 15 };
            int[] Result = QuickSort.SortQuick(arr, 0, arr.Length-1);
            int[] Expected = { 4, 8, 15, 16, 23, 42 };
            Assert.Equal(Result, Expected);

        }

        [Fact]
        public void CanQuickSortArray2()
        {
            int[] arr = { 20, 18, 12, 8, 5, -2 };
            int[] Result = QuickSort.SortQuick(arr, 0, arr.Length - 1);
            int[] Expected = { -2, 5, 8, 12, 18, 20 };
            Assert.Equal(Result, Expected);

        }


        [Fact]
        public void CanQuickSortArray3()
        {
            int[] arr = { 5, 12, 7, 5, 5, 7 };
            int[] Result = QuickSort.SortQuick(arr, 0, arr.Length - 1);
            int[] Expected = { 5, 5, 5, 7, 7, 12 };
            Assert.Equal(Result, Expected);

        }

        [Fact]
        public void CanQuickSortArray4()
        {
            int[] arr = { 2, 3, 5, 7, 13, 11 };
            int[] Result = QuickSort.SortQuick(arr, 0, arr.Length - 1);
            int[] Expected = { 2, 3, 5, 7, 11, 13 };
            Assert.Equal(Result, Expected);

        }

    }
}
