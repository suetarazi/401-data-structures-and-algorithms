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

            for (int i = 0, j = 0; i < 7; i++, j++)
            {

            }

            for (int i = 0; i < inputArr.Length - 1; i++)
            {
                for (int j = 0; j < inputArr.Length - 1 - i; j++)
                {
                    //Console.WriteLine($"input i is {inputArr[i]} and input j is {inputArr[j]}");
                    if (inputArr[i] > inputArr[i+1])
                    {
                        var temp = inputArr[j];
                        inputArr[j] = inputArr[i];
                        inputArr[i] = temp;

                    }
                    else if (inputArr[i] <= inputArr[j])
                    {

                    }
                }
            }

            inputArr.CopyTo(sortedArr, 0);
            foreach(int num in inputArr)
            {
                sortedArr = inputArr;
                Console.WriteLine(num);
            }
                return sortedArr;
        }
    }
}
