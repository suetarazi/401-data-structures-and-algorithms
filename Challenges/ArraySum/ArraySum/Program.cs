using System;
using System.Collections.Generic;

namespace ArraySum
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] watch = new int[] { 1, 2, 3, 4, 5 };
            TVWatch(watch, 3);
            TVWatch2(watch, 3);

        }



        //[1,2,3,4,5], 3
        // a,b,c,d,e



        // 1,2,3 = a + b + c = x
        //   2,3,4 = b + c + d = x - a + d
        //     3,4,5 

        //[6,9,12]

        //array index 0-2; 1-3, 2-4

        /// <summary>
        /// Method using a single for loop
        /// </summary>
        /// <param name="watch">input array</param>
        /// <param name="interval">step size for array</param>
        /// <returns>results array of summed integer values</returns>
        public static int[] TVWatch2(int[] watch, int interval)
        {
            int[] resultsArr = new int[watch.Length - (interval-1)];
            
            int initialSum = watch[0] + watch[1] + watch[2];
            Console.WriteLine($"The initial sum is {initialSum}");

            for(int i=0; i<watch.Length - (interval-1); i++)
            {
                resultsArr[i] += initialSum - i + (i + 3);
                Console.WriteLine($"results array is now {resultsArr[i]}");
                initialSum = resultsArr[i];
                i++;
            }

            return resultsArr;
        }



        public static int[] TVWatch(int[] watch, int interval)
        {
            int[] returnArr = new int[watch.Length - (interval - 1)];
            int sum = 0;
            int i = 0;
            int j = 0;

            for(j=0; j<watch.Length-(interval-1); j++)
            //for (j = 0; j < watch.Length - 1; j++)
            {

                for (i = 0; i <= 2; i++)
                {
                    sum += watch[i + j];
                    Console.WriteLine($"The sum is {sum}");
                    i++;
                }
                returnArr[j] = sum;
                Console.WriteLine($"The return array at j is now {returnArr[j]}");
                j++;
            }

            return returnArr;
        }

    }
}