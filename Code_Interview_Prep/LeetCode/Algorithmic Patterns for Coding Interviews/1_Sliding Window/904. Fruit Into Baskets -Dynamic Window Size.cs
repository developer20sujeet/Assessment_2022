using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Algorithmic_Patterns_for_Coding_Interviews._1_Sliding_Window
{
    /// <summary>
    /// https://leetcode.com/problems/fruit-into-baskets/
    /// </summary>
    public class FruitIntoBaskets
    {

        /// <summary>
        /// https://www.youtube.com/watch?v=wey1yZdkUNE&list=PL7g1jYj15RUOjoeZAJsWjwV8XUo9r0hwc&index=3
        /// Runtime: 337 ms, faster than 36.16% of C# online submissions for Fruit Into Baskets.
        /// Memory Usage: 45 MB, less than 60.17% of C# online submissions for Fruit Into Baskets.
        /// Tips :
        ///     1. Only two type of Item can  be kept so declare a dictionary to keep Item type
        ///     2. Add Array item in dictinary - provided dictionary count is less than 2 and dictionary does not contain that workitem
        ///     3. If step 2 invalid then take max current winodw 
        ///     4. if step 3 fail means new kinds of work item we found 
        ///         4.1 so we need to emppty basket 
        ///         4.2 add current array index -1 in basket - as we need two item in basket 
        ///         4.3 add current array index - new work item in array 
        ///         4.4 move start to 4.2 
        ///         4.5 move start to all previous item which is same  item type
        /// </summary>
        /// <returns></returns>
        public int FruitsInBasket(int[] tree)
        {
            int start = 0;
            int max = 0;

            // to hold two basket and its count value
            Dictionary<int, bool> basket = new Dictionary<int, bool>();

            for (int end = 0; end < tree.Length; end++)
            {
                if (basket.Count < 2 && !basket.ContainsKey(tree[end]))
                {
                    basket.Add(tree[end], true);

                    //end - start + 1 = Length of current window 
                    max = Math.Max(max, end - start + 1);

                }
                // If same item type already in bucket then we are increasing the window and storing current window 
                else if (basket.ContainsKey(tree[end]))
                {
                    //end - start + 1 = Length of current window 
                    max = Math.Max(max, end - start + 1);
                }
                // If we encounter different item type then we have to make basket(dictinary) empty 
                else
                {
                    // empty the basket so that new work Item can be kept 
                    basket = new Dictionary<int, bool>();

                    //Put existing item type in basket as we need two item in basket so we are keeping one item type from last work item
                    basket.Add(tree[end - 1], true);

                    //Put new item type in basket 
                    basket.Add(tree[end], false);

                    // basket.add(arr[end-1], true)- This and below line should be same for window  
                    start = end - 1;

                    // it make current window go backword to inlcude previous work item in current window 
                    while (tree[start] == tree[start - 1])
                    {
                        start--;
                    }

                    //end - start + 1 = Length of current window 
                    max = Math.Max(max, end - start + 1);

                }

            }
            return max;

        }

    }
}
