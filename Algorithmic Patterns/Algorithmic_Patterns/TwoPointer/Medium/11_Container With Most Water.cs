using System.Net;

namespace Algorithmic_Patterns.TwoPointer.Medium
{
    /// <summary>
    /// There are n vertical lines drawn such that the two endpoints of the ith line are (i, 0) and (i, height[i]).
    /// (i, 0) && (i, height[i]) ==  (x-axis (horizontal) , y-axis(vertical))== (array index,array value) 
    /// 
    /// let's consider the array height = [1, 8, 6, 2, 5, 4, 8, 3, 7]:
    ///     height[0] = 1 = lower endpoint at (0,0)  and its upper endpoint at (0,1) so  (0,0) + (0,1) draw one line 
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
    ///     
    /// Central Idea 
    ///     1. Remember farmula  of rectangle = Width * hight 
    ///     2. In Array index , Width is difference of two index = right index - left index ( Two pointer)
    ///     3. take minium height because you can fill water upto minium height - so take minium height from value at array two index
    ///     4. Important - move pointer but whihc one ?-  whichever pointer value is less because you need next max height value to find max water you can fill 
    ///     
    /// </summary>
    internal class _11_Container_With_Most_Water
    {
        public int MaxArea(int[] height)
        {
            // max width between two array index 
            int width = 0;

            // Minimum height between two array value at two index (Left and right)
            int minHeight = 0;

            int maxWaterArea = int.MinValue;


            int leftIndex = 0;
            int rightIndex = height.Length - 1;

            while (leftIndex < rightIndex)
            {
                // max width between two array index 
                width = rightIndex-leftIndex;

                // Minimum height between two array value at two index (Left and right)
                minHeight = Math.Min(height[leftIndex], height[rightIndex]);

                // Max water that can hold 
                maxWaterArea = Math.Max((width * minHeight), maxWaterArea);

                // idea is to move toward max vertical line - so compare which vertical line is shorter 
                // which ever is shorter move that pointer 
                if (height[leftIndex] < height[rightIndex])
                {
                    leftIndex++;
                }
                else
                {
                    rightIndex--;
                }
            }
            return maxWaterArea;

        }
    }
}
