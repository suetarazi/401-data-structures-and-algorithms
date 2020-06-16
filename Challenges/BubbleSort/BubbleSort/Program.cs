using System;

namespace BubbleSort
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Program p = new Program();
            int[] testArr = new int[] { 5, 1, 4, 2, 8 };
            p.BubbleSortMethod(testArr);
        }

        public int[] BubbleSortMethod(int[] inputArr)
        {
            int[] sortedArr = new int[inputArr.Length];

            for(int i=0; i<inputArr.Length-1; i++)
                for(int j=1; j<inputArr.Length-2; j++)
            {
                if(inputArr[i] > inputArr[j])
                    {
                        inputArr[i] = inputArr[j];
                        inputArr[j] = inputArr[i];
                    }
                else if(inputArr[i] <= inputArr[j])
                    {
                        i++;
                        j++;
                    }
            }

            foreach(int i in inputArr)
            {
                sortedArr[i] = inputArr[i];
                Console.WriteLine(sortedArr[i]);
            }
                return sortedArr;
        }
    }
}
