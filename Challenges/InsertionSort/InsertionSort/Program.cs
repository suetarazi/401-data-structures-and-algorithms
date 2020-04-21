using System;
using InsertionSort.Classes;

namespace InsertionSort
{
    class Program
    {
        /// <summary>
        /// No test cases were required for this challenge, so arrays were created in this method and then passed to the SortArray method 
        /// </summary>
        /// <param name="args">default</param>
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int[] array1 = { 8, 4, 23, 42, 16, 15 };
            int[] array2 = { 20, 18, 12, 8, 5, -2 };
            int[] array3 = { 5, 12, 7, 5, 5, 7 };
            int[] array4 = { 2, 3, 5, 7, 13, 11 };

            Sort.SortArray(array1);
            Sort.SortArray(array2);
            Sort.SortArray(array3);
            Sort.SortArray(array4);
        }
    }
}
