using System.Formats.Asn1;
using System.Runtime.CompilerServices;

public class Program
{

    public static void Main(string[] args)
    {

       int [] a= TwoSum(new int[] { 3, 2, 4 }, 6);



    }

    public static int[] TwoSum2(int[] nums, int target)
    {

        // Sort the Array 

        List<KeyValuePair<int, int>> kvp = new List<KeyValuePair<int, int>>();

        for (int i = 0; i < nums.Length-1; i++)
        {

            kvp.Add(new KeyValuePair<int, int> { nums[i], i });

        }




    }

        public static int[] TwoSum(int[] nums, int target)
    {

        (int number, int index)[] arr = new (int number, int index)[nums.Length];

        for (int i = 0; i < nums.Length; i++)
        {

            arr[i] = (nums[i], i);

        }

        Array.Sort(arr, (a, b) => a.number.CompareTo(b.number));

        // start two pointer now   now 


        int leftPointer = 0, rightPointer = nums.Length - 1;

        while (leftPointer < rightPointer)
        {

            long sum = arr[leftPointer].number + arr[rightPointer].number;

            if (sum == target)
            {

                return new int[] { arr[leftPointer].index, arr[rightPointer].index };
            }
            else if (sum < target)
            { leftPointer++; }
            else
            { rightPointer--; }


        }

        return new int[] { -1, -1 }; ;

    }
}