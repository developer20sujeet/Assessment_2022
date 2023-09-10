using System.Collections.Generic;
using System.Formats.Asn1;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Text.Json;

public class Program
{
    public static void Main(string[] args)
    {


        new Program().TwoSum(new int[] { 3, 3 }, 6);


    }
    public int[] TwoSum(int[] nums, int target)
    {
        Dictionary<int, int> result = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            if (result.ContainsKey(target- nums[i]))
            {
                return new int[] { i, result[target - nums[i]]};
            }
            else
                result[nums[i]] = i;


        }


        return null;

    }
}

