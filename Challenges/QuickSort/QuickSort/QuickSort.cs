using System;
using System.Collections.Generic;
using System.Text;

namespace QuickSort
{
    public class QuickSort
    {
        public int[] SortQuick(int[] arr, int start, int end)
        {
            int i;
            if (start < end)
            {
                i = Partition(arr, start, end);

                SortQuick(arr, start, i - 1);
                SortQuick(arr, i + 1, end);

            }

            return Arr;
        }

        public int Partition(int[] arr, int start, int end)
        {
            int temp;
            int p = arr[end];
            int i = start - 1;

            for(int j=start; j <= end -1; j++)
            {
                if (arr[j] <= p)
                {
                    i++;
                    temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
                
            }

            temp = arr[i + 1];
            arr[i + 1] = arr[end];
            arr[end] = temp;
            return i + 1;
        }

    }
}
