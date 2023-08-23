using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Algorithmic_Patterns.TwoPointer.Easy
{
    internal class _21_Merge_Two_Sorted_Lists
    {

        /// <summary>
        ///  time complexity is O(n+m) and space complexity is  O(1).
        /// </summary>
        /// <param name="l1"></param>
        /// <param name="l2"></param>
        /// <returns></returns>
        public ListNode MergeTwoListsy(ListNode l1, ListNode l2)
        {
            if (l1 == null) return l2;
            if (l2 == null) return l1;

            // Determine the head of the merged list.
            ListNode head;
            if (l1.val < l2.val)
            {
                head = l1;
                l1 = l1.next;
            }
            else
            {
                head = l2;
                l2 = l2.next;
            }

            // Current pointer to build the merged list.
            ListNode current = head;

            while (l1 != null && l2 != null)
            {
                if (l1.val < l2.val)
                {
                    current.next = l1;
                    l1 = l1.next;
                }
                else
                {
                    current.next = l2;
                    l2 = l2.next;
                }
                current = current.next;
            }

            // If any nodes are left in l1 or l2, append them to the merged list.
            current.next = l1 != null ? l1 : l2;

            return head;
        }

        /// <summary>
        /// Create a Dummy Node: 
        ///     We'll use a dummy node to keep track of the start of our new merged list.
        /// Create a Current Node: 
        ///     This node will move through our new merged list, appending the smaller of the two values at the head of the two lists we're merging.
        /// Compare and Append: 
        ///     We'll loop through both lists, comparing the values at the head of each list, and appending the smaller to our new list. We'll continue doing this until we've reached the end of both lists.
        /// Append Remaining Elements: 
        ///     If there are any remaining elements in one of the two lists after one has been entirely appended to our new list, we'll append all the remaining elements to our new list.
        /// </summary>
        /// <param name="list1"></param>
        /// <param name="list2"></param>
        /// <returns></returns>
        public ListNode MergeTwoLists_way2(ListNode l1, ListNode l2)
        {
            // Step 1: Create a dummy node to simplify the process of building the merged list.
            ListNode dummy = new ListNode(0);

            // Step 2: Use the 'current' pointer to iterate through and build the merged list.
            ListNode current = dummy;

            // Step 3: Iterate through both lists as long as neither is null.
            while (l1 != null && l2 != null)
            {
                // Step 4: Compare the current values of l1 and l2.
                if (l1.val < l2.val)
                {
                    // Step 5: If l1's value is smaller, link 'current' to this node.
                    current.next = l1;
                    // Step 6: Move l1 to its next node.
                    l1 = l1.next;
                }
                else
                {
                    // Step 7: If l2's value is smaller or equal, link 'current' to this node.
                    current.next = l2;
                    // Step 8: Move l2 to its next node.
                    l2 = l2.next;
                }
                // Step 9: Move 'current' to the next node in the merged list.
                current = current.next;
            }

            // Step 10: If there are any remaining nodes in l1, append them to the merged list.
            if (l1 != null)
            {
                current.next = l1;
            }

            // Step 11: If there are any remaining nodes in l2, append them to the merged list.
            if (l2 != null)
            {
                current.next = l2;
            }

            // Step 12: Return the merged list, starting after the dummy node.
            return dummy.next; //dummy.next is pointing to the head of the merged list.;///  ListNode current = dummy;
        }




    }
}

//Definition for singly-linked list.
public class ListNode
{
    public int val;
    public ListNode next;
    public ListNode(int val = 0, ListNode next = null)
    {
        this.val = val;
        this.next = next;
    }
}
}
