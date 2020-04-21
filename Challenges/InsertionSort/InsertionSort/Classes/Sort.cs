using System;
using System.Collections.Generic;
using System.Text;
using InsertionSort.Classes;

namespace InsertionSort
{
    class Sort
    {
        /// <summary>
        /// This is a class that will accept an array and sort it from lowest to highest
        /// </summary>
        /// <param name="array">accepts and array and returns the same array sorted</param>
        public static void SortArray(int[] array)
        {
            int lowestValue;
            int i;
            int j;

            for (i = 0; i < array.Length - 1; i++)

                lowestValue = i;
            {
                for(j = i+1; j<array.Length; j++)
                {
                    if (array[j] < array[lowestValue])
                    {
                        lowestValue = j;
                    }
                }
                Swap.SwapValues(i, lowestValue);   
            }
            for (int k = 0; k < array.Length; k++)
            {
                Console.WriteLine(array[k]);
            }
        }
    }
}
