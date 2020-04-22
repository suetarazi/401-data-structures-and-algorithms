using System;
using System.Collections.Generic;
using System.Text;

namespace MergeSort
{
    class MergeSort
    {
        /// <summary>
        /// Method to rebuild the array into one
        /// </summary>
        /// <param name="input">input array</param>
        /// <param name="left">int value to the left</param>
        /// <param name="middle">int value in the middle</param>
        /// <param name="right">int value to the right</param>
        public void Merge(int[] input, int left, int middle, int right)
        {
            int[] leftArr = new int[middle - left + 1];
            int[] rightArr = new int[right - middle];

            Array.Copy(input, left, leftArr, 0, middle - left + 1);
            Array.Copy(input, middle + 1, rightArr, 0, right - middle);

            int i;
            int j;
            

            for(int k=left, k < (right+1); k++)
            {
                if(i == leftArr.Length)
                {
                    input[k] = rightArr[j];
                    j++;
                }
                else if (j == rightArr.Length)
                {
                    input[k] = leftArr[i];
                    i++;
                }
                else if (leftArr[i] <= rightArr[j])
                {
                    input[k] = leftArr[i];
                    i++;
                }
                else
                {
                    input[k] = rightArr[j];
                    j++;
                }

            }
        }
        /// <summary>
        /// Method to call itself recursively to sort the array
        /// </summary>
        /// <param name="input">array to be inputted</param>
        /// <param name="left">int to the left</param>
        /// <param name="right">int to teh right</param>
        public void MergeSortMethod(int[] input, int left, int right)
        {
            if(left<right)
            {
                int middle = (left + right)/ 2;

                MergeSortMethod(input, left, middle);
                MergeSortMethod(input, middle + 1, right);

                Merge(input, left, middle, right);
            }
            

        }
    }
}
