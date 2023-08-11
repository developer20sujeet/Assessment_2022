using System.Runtime.CompilerServices;

class Program
{

    static void Main(string[] args)
    {

        string sentence = "aabdsda";

        HashSet<char> seen = new HashSet<char>();
        Dictionary<char, int> counts = new Dictionary<char, int>(); 

        // Convert sentence to lowercase and iterate over each character
        foreach (char currChar in sentence.ToLower().ToCharArray())
        {
            if (char.IsLetter(currChar))
            {
                // Add the character to set
                seen.Add(currChar);
                counts.Add(currChar, 1);
            }
        }

        // Return true if set size is 26 (total number of alphabets)
        //return seen.Count == 26;


    }

    /// <summary>
    /// two pointer
    /// </summary>
    /// <param name="nums"></param>
    /// <param name="target"></param>
    /// <returns></returns>
    public int[] TwoSum(int[] nums, int target)
    {
        int pointer_one= 0, pointer_two=nums.Length-1;

        while (pointer_one < pointer_two)
        {
            long sum = nums[pointer_one] + nums[pointer_two];

            if (sum == target)
            {
                int[] arr = new int[2];
                arr[0] = pointer_one;
                arr[1] = pointer_two;
                return arr;
            }

            if (sum < target )
                pointer_one++;
            else
                pointer_two--;

        }

        return new int[0];


    }
}