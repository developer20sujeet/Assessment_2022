using System.Formats.Asn1;
using System.Globalization;
using System.Runtime.CompilerServices;
public class Program
{
    public static void Main(string[] args)
    {


    }

    // centrail point - move all non- zero to front and fill up rest array index with 0
    public void MoveZeroes(int[] nums)
    {
        // part of central theme
        int pointer = 0;

        for (int i = 0; i < nums.Length; i++)
        {

            if (nums[i] != 0)
            {

                nums[pointer] = nums[i];

                pointer++;
            }

        }

        while (pointer < nums.Length)
        {
            nums[pointer] = 0;
            pointer++;
        }

    }
}