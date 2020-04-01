using System;

namespace array_shift
{
    class Program
    {
        static void Main(string[] args)
        {
         
            InsertShiftArray();
        }

        static void InsertShiftArray()
        {
            Console.WriteLine("How big would you like your array? ");
            string answer = Console.ReadLine();
            int[] userArray = new int[Convert.ToInt32(answer)];
            Console.WriteLine("What number would you like to add to the middle of the array? ");
            string answer2 = Console.ReadLine();
            int value = Convert.ToInt32(answer2);

            int midpoint = userArray.Length / 2;

            int newLength = Convert.ToInt32(answer) + 1;
            for (int i = 0; i < userArray.Length; i++)
            {
                Console.WriteLine($"Please select {userArray} numbers, pressing enter after each");
                string userNum = Console.ReadLine();
                int arrNum = Convert.ToInt32(userNum);
                userArray[i] = arrNum;

                BuildNewArray(midpoint, newLength, userArray, value);
            }
        }
            static int[] BuildNewArray(int midpoint, int newLength, int[] userArray, int value )
        { 
            int[] newArray = new int[newLength];
                for (int j = 0; j < newArray.Length; j++)
                {
                    if (j < (midpoint - 1))
                    {
                        newArray[j] = userArray[j];
                    }
                    if (j == midpoint - 1)
                    {
                        newArray[j] = value;
                    }
                    if (j > (midpoint - 1))
                    {
                        newArray[j] = userArray[j - 1];
                    }
                 }
            return newArray;
            
        }
    }
    }

