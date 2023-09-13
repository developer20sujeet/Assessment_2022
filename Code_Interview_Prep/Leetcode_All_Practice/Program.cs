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
        new Program().ThreeSum(new int[] { 0, 0, 0, 0 });



    }
    public int MaxArea(int[] height)
    {
        int left = 0;
        int right = height.Length - 1;

        int maxWater = 0;

        while (left < right)
        {
            int width = right - left;

            int minHeight = Math.Min(height[left], height[right]);

            maxWater = Math.Max(maxWater, width * minHeight);

            if (height[left] < height[right])
                left++;
            else
                right--;
        }

        return maxWater;


    }

}

