using System;

namespace BinarySearch
{
    public class Program
    {
        /// <summary>
        /// Iterative approach to binary search
        /// </summary>
        /// <param name="binaryArray">binary array to search</param>
        /// <param name="key">key value to search for in array</param>
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] binaryArray = { 4, 8, 15, 16, 23, 42 };
            int key = 15;

            BinarySearchIterative(binaryArray, key);
        }

        public static int BinarySearchIterative(int[] binaryArray, int key)
        {
            int min = 0;
            int max = binaryArray.Length - 1;

            while (min <= max)
            {
                int middle = (min + max) / 2;

                if (key == binaryArray[middle])
                {
                    Console.WriteLine($"The index array is {middle}");
                    return middle;
                }
                else if (key < binaryArray[middle])
                {
                    max = middle - 1;
                }
                else if (key > binaryArray[middle])
                {
                    max = middle - 1;
                }
                                
            }
            Console.WriteLine("The index array is not found: -1");
        return -1;
        }
    }

}