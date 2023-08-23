using System.Formats.Asn1;
using System.Globalization;
using System.Runtime.CompilerServices;
public class Program
{
    public static void Main(string[] args)
    {
        TwoSum(new int[] { 3, 2, 4 }, 6);
    }
    public static int[] TwoSum(int[] nums, int target)
    {
        // Two pointer can be applied >> but it need to be sorted >> but question does not confirm that it is sorted >> so need to sort 
        // FOr sorting I have two way Tuples and KeyValuePair 
        // only reason to take in tuples is to sort and hold index number 
        (int number, int index)[] tpls = new (int, int)[nums.Length];
        for (int i = 0; i <= nums.Length - 1; i++)
        {
            tpls[i] = (nums[i], i);
        }
        string a = "";
        Array.Sort(tpls, (a, b) => a.number.CompareTo(b.number));
        int left = 0;
        int right = nums.Length - 1;
        while (left < right)
        {
            if (tpls[left].number + tpls[right].number == target)
            {
                return new int[] { tpls[left].index, tpls[right].index };
            }
            else if (tpls[left].number + tpls[right].number < target)
            {
                left++;
            }
            else
            {
                right--;
            }
        }
        return new int[0];
    }
    public int[] Option1(int[] nums, int target)
    {
        // Create a dictionary to store the numbers and their corresponding indices
        Dictionary<int, int> numIndices = new Dictionary<int, int>();
        // Iterate through the array, looking for the complement of each number
        for (int i = 0; i < nums.Length; i++)
        {
            int complement = target - nums[i];
            // If the complement is found in the dictionary, return its index along with the current index
            if (numIndices.ContainsKey(complement))
            {
                return new int[] { numIndices[complement], i };
            }
            // Otherwise, add the current number and its index to the dictionary
            numIndices[nums[i]] = i;
        }
        // If no solution is found, return an empty array (this should never happen for valid input)
        return new int[0];
    }
}
