using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithmic_Patterns.TwoPointer.Hard
{
    internal class _42_Trapping_Rain_Water
    {


        /// <summary>
        /// Time Complexity: O(n)
        /// Space Complexity: O(1)
        /// Algorithm used: Two Pointers
        /// Algorithmic coding pattern: Two Pointers
        /// Data structure used: Array
        /// Company name: This problem is commonly asked in interviews at Amazon, Google, and many other companies.
        /// Important Tips and Tricks: 
        ///     The water that can be trapped is limited by the shorter height.
        /// Lessons Learned: 
        ///     Be cautious when updating the leftMax and rightMax variables.
        /// Central Idea: 
        ///         0. totally you need to visualize 
        ///         1. First remember if two wall is attched to each other then no water can be stored , it need space to store water - visualize
        ///         2. Second think - you have only two wall - left wall and right wall and space betwwen it then water can be stored in space 
        ///         3. Thnik - left wall or right wall whichever is smaller only that much water can be stored so 
        ///             so if left wall height is 5 and righ wall is 3 and space in beetween then - 5-3 = 2 unit water can be stored
        ///             but if left wall height is 5 and righ wall is 3 and 1 foot height wall in beetween then - min( 5,3)-1= 2 , -1 because water can not be stored upto wall in beetween
        ///         4. so for any index you need left max , right max and space height , second which ever max is shorted that would be limiting and only that match water can be stored and minus wall height which is in beetween so it is limitingMax-indexwallheight
        ///             -- so if left wall height is 5 and righ wall is 3 and 1 foot height wall = 3-1 = 2 
        /// </summary>
        public int Trap(int[] height)
        {
            // Step 1: Initialize pointers and variables
            // Reason: To keep track of the maximum height from both ends and the total trapped water
            int left = 0, right = height.Length - 1;


            int leftMax = 0, rightMax = 0;

            // to save result 
            int trappedWater = 0;

            // Step 2: Traverse the array using two pointers
            // Reason: To find trapping points based on maximum heights
            while (left < right)
            {
                // Step 3: Update maximum heights
                // Reason: The trapping water at any index depends on the maximum height
                // Based on concept you need leftmax and rightmax for very index to calculate trapping water 
                // Here's the thing: When your left and right pointers meet, you have effectively considered every "immediate right maximum" and "immediate left maximum" for each index. 
                leftMax = Math.Max(leftMax, height[left]);
                rightMax = Math.Max(rightMax, height[right]);

                // Step 4: Calculate trapped water
                // Reason: Water trapping is limited by the shorter height
                //          we're sure that leftMax is the limiting factor for water trapping at index left
                if (leftMax < rightMax)
                {
                    // Reason: Water can be trapped here as leftMax is limiting
                    trappedWater += leftMax - height[left];
                    left++;
                }
                else
                {
                    // Reason: Water can be trapped here as rightMax is limiting
                    // then rightMax is the limiting factor for water trapping at index right
                    trappedWater += rightMax - height[right];
                    right--;
                }
            }

            // Step 5: Return the total trapped water
            // Reason: Result of the problem
            return trappedWater;
        }


        /// <summary>
        /// Method to find trapped water using brute-force method
        /// Time Complexity: O(n^2)
        /// Space Complexity: O(1)
        /// Algorithm Used: Brute-force
        /// Data Structure Used: Array
        /// </summary>
        /// <param name="height">Array containing the heights</param>
        /// <returns>Amount of trapped rainwater</returns>
        public static int Trap_BruteForce(int[] height)
        {
            // Step 1: Initialize the total water trapped to 0
            int totalWater = 0;

            // Step 2: Loop through each bar
            for (int i = 0; i < height.Length; i++)
            {
                // Step 3: Find the tallest bar on the left of i
                int leftMax = 0;
                for (int j = 0; j <= i; j++)
                {
                    leftMax = Math.Max(leftMax, height[j]);
                }

                // Step 4: Find the tallest bar on the right of i
                int rightMax = 0;
                for (int j = i; j < height.Length; j++)
                {
                    rightMax = Math.Max(rightMax, height[j]);
                    if (rightMax >= leftMax)
                    {
                        break; // Exit the loop early if rightMax is greater than or equal to leftMax
                    }
                }

                // Step 5: Find the water that can be stored at i
                // We take the minimum of leftMax and rightMax for trapping water and subtract the height at the current bar
                totalWater += Math.Min(leftMax, rightMax) - height[i];
            }

            // Step 6: Return the total trapped water
            return totalWater;
        }

    }
}
