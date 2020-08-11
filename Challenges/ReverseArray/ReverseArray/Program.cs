using System;

namespace ReverseArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

        }

        public int[] ArrayReverse1(int[] arr)
        {
            for(int i = arr.Length; i >= 0; i--)
            {
                arr[i] = i;
            }

            return arr;
        }

        public int[] ArrayReverse2(int[] arr)
        {
            Array.Reverse(arr);
            return arr;
        }
    }
}
