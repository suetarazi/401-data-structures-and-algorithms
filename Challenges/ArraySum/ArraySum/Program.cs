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


        }



        //[1,2,3,4,5], 3
        // a,b,c,d,e



        // 1,2,3 = a + b + c = x
        //   2,3,4 = b + c + d = x - a + d
        //     3,4,5 

        //[6,9,12]

        //array index 0-2; 1-3, 2-4

        public static int[] TVWatch(int[] watch, int interval)
        {
            int[] returnArr = new int[watch.Length - (interval - 1)];
            int sum = 0;
            int i = 0;
            int j = 0;

            for(j=0; j<watch.Length-(interval-1); j++)
            //for (j = 0; j < watch.Length - 1; j++)
            {

                for (i = 0; i < 2; i++)
                {
                    sum += watch[i + j];
                    Console.WriteLine($"The sum is {sum}");
                    i++;
                }
                returnArr[j] = sum;
                //Console.WriteLine(returnArr);
                j++;
            }

            return returnArr;
        }

    }
}