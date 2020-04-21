using System;
using System.Collections.Generic;
using System.Text;
using InsertionSort.Classes;

namespace InsertionSort
{
    class Swap
    {
        /// <summary>
        /// This method swaps the position of two values in the array
        /// </summary>
        /// <param name="initial">the initial value at the current index of the array</param>
        /// <param name="target">the value that needs to be swapped with "initial"</param>
        public static void SwapValues(int initial, int target)
        {
            int[] array;
            int temp = array[initial];
            array[initial] = array[target];
            array[target] = temp;
        }
    }
}
