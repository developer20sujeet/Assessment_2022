using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Formats.Asn1;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Text.Json;

public class Program
{
    public static void Main(string[] args)
    {
        new Program().Trap(new int[] { 0, 1, 0, 2, 1, 0, 1, 3, 2, 1, 2, 1 });
       // new Program().Trap(new int[] { 4, 2, 0, 3, 2, 5 });



    }
    public int Trap(int[] height)
    {
        // we need left max and right max of very index 

        int leftMax = 0;

        int rightMax = 0;

        int result = 0;

        for (int i = 0; i < height.Length-1; i++)
        {
             leftMax = 0;

             rightMax = 0;

            for (int j = 0; j < i; j++)
            {

                leftMax = Math.Max(leftMax, height[j]);
            }


            for (int j = i+1; j < height.Length; j++)
            {

                rightMax = Math.Max(rightMax, height[j]);

                if (rightMax >= leftMax && height[i] !>= leftMax)
                    break;
            }


            if (leftMax != 0)
            {
                result += Math.Min(leftMax, rightMax) - height[i];
            }





        }
        return result;


    }

}

