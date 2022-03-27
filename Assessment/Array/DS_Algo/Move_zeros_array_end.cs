using System;
using System.Collections.Generic;
using System.Text;

namespace Assessment.Array.DS_Algo
{
    //Move all zeros present in an array to the end
    //https://logicmojo.com/cracking_interview/#SampleLecture
    public class Move_zeros_array_end
    {
        public static void Move_zero_array_end_Library_Myway(int [] arr) //[1300409]
        {
            System.Array.Sort(arr);

            System.Array.Reverse(arr);
        }
        public static void Move_zero_array_end_Library_Myway_2(int[] arr) //[1300409]
        {
            // int[] arr = { 1, 3, 0, 0, 4, 0, 9 };
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] ==0)
                {
                    for (int j = i+1; j < arr.Length; j++)
                    {
                        if(arr[j] != 0)
                        {
                            int temp = arr[i];
                            arr[i] = arr[j];
                            arr[j] = temp;
                            break;
                        }

                    }
                }


            }
        }

        //https://logicmojo.com/cracking_interview/#SampleLecture
        public static void Move_zero_array_logicmojo_M3(int[] arr) //[1300409]
        {
            // int[] arr = { 1, 3, 0, 0, 4, 0, 9 };
            int cntr = 0;

            // counter will hold the position at 0 and i will keep shifting toward non zero value
            for (int i = 0; i < arr.Length; i++)
            {
                if(arr[i] !=0)
                {
                    arr[cntr++] = arr[i];
                }
            }

            while(cntr < arr.Length)
            {
                arr[cntr++] = 0;

            }
        }
    }
}
