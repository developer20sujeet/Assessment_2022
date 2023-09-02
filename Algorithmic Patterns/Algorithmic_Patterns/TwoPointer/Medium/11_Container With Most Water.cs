using System.Net;

namespace Algorithmic_Patterns.TwoPointer.Medium
{
    /// <summary>
    /// There are n vertical lines drawn such that the two endpoints of the ith line are (i, 0) and (i, height[i]).
    /// (i, 0) && (i, height[i]) -  (x-axis (horizontal) , y-axis(vertical))- (array index,array value) 
    /// 
    /// let's consider the array height = [1, 8, 6, 2, 5, 4, 8, 3, 7]:
    ///     height[0] = 1 = lower endpoint at (0,0)  and its upper endpoint at (0,1) - (0,0)+ (0,1) draw one line 
    ///         -means on index 0 one line drawn vertically start from 0 to 1(vertically)
    ///     height[1] = 8 = lower endpoint at (1,0)  and its upper endpoint at (1,8)
    ///     height[2] = 6 = lower endpoint at (2,0)  and its upper endpoint at (2,6)
    /// 
    /// In the 2D plane, each vertical line's lower and upper endpoints are represented as coordinates (x,y).
    ///     The x-axis coordinate is the index of the array.
    ///     The y-axis coordinate is the value at that index for the upper endpoint, and it's always 0 for the lower endpoint.
    /// 
    /// So, in a 2D plane:
    ///     The lower endpoint of each line is (array index,0)
    ///     The upper endpoint of each line is (array index,array value)
    /// </summary>
    internal class _11_Container_With_Most_Water
    {
        public int MaxArea(int[] height)
        {
            // Central Idea -
            //  you you know the the max distance between two vertical line +  minium height from that two vertical line because water will be upto miniu
            //  Farmula (j - i) * min(height[i], height[j])
            //      - here i is one index where one vertical index exist and J is another index where 2nd vertical line exist. 
            //      - because water can fill till mimium if vertical line so finding min

            int maxDistanceBetweenTwoVerticaline = 0;
            int minOfTwoVerticalLine = 0;
            int maxArea = int.MinValue;

            int leftIndex = 0;
            int rightIndex = height.Length - 1;

            while (leftIndex < rightIndex)
            {
                maxDistanceBetweenTwoVerticaline =rightIndex-leftIndex;

                minOfTwoVerticalLine = Math.Min(height[leftIndex], height[rightIndex]);

                maxArea = Math.Max((maxDistanceBetweenTwoVerticaline * minOfTwoVerticalLine), maxArea);

                //
                if (height[leftIndex] < height[rightIndex])
                {
                    leftIndex++;
                }
                else
                {
                    rightIndex--;
                }


            }

            return maxArea;

        }
    }
}
