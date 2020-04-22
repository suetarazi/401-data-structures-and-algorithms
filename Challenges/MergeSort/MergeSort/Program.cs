using System;
using MergeSort.Classes;

namespace MergeSort
{
    class Program
    {
        /// <summary>
        /// main method to declare test arrays and call MergeSortMethod to pass test arrays in
        /// </summary>
        /// <param name="args">default</param>
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int[] array1 = { 8, 4, 23, 42, 16, 15 };
            int[] array2 = { 20, 18, 12, 8, 5, -2 };
            int[] array3 = { 5, 12, 7, 5, 5, 7 };
            int[] array4 = { 2, 3, 5, 7, 13, 11 };

            MergeSort.MergeSortMethod(array1);
            MergeSort.MergeSortMethod(array2);
            MergeSort.MergeSortMethod(array3);
            MergeSort.MergeSortMethod(array4);
        }
    }
}
