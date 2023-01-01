using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace General_Programming
{
    internal class MergeTwoSorted_Singly_Linked_Lists
    {
        public static LinkedListNode<int> MergeSortedLinkedLists(LinkedListNode<int> head1, LinkedListNode<int> head2)
        {
            // Create a new empty linked list to store the result
            LinkedList<int> resultList = new LinkedList<int>();

            // Initialize two pointers, one for each of the input linked lists
            LinkedListNode<int> current1 = head1;
            LinkedListNode<int> current2 = head2;

            // Compare the values at the pointers and add the smaller value to the result linked list
            while (current1 != null && current2 != null)
            {
                if (current1.Value <= current2.Value)
                {
                    resultList.AddLast(current1.Value);
                    current1 = current1.Next;
                }
                else
                {
                    resultList.AddLast(current2.Value);
                    current2 = current2.Next;
                }
            }

            // Add the remaining nodes of the non-empty linked list to the result linked list
            if (current1 != null)
            {
                resultList.AddLast(current1);
            }
            else if (current2 != null)
            {
                resultList.AddLast(current2);
            }

            // Return the head of the result linked list
            return resultList.First;
        }


        /// <summary>
        /// tester of MergeSortedLinkedLists
        /// </summary>
        public static void Tester()
        {
            LinkedList<int> list1 = new LinkedList<int>();
            list1.AddLast(1);
            list1.AddLast(3);
            list1.AddLast(5);

            LinkedList<int> list2 = new LinkedList<int>();
            list2.AddLast(2);
            list2.AddLast(4);
            list2.AddLast(6);

            LinkedListNode<int> mergedList = MergeSortedLinkedLists(list1.First, list2.First);


            while (mergedList != null)
            {
                Console.Write(mergedList.Value + " ");

                mergedList = mergedList.Next;
            }

            // Output: 1 2 3 4 5 6

        }
    }
}
