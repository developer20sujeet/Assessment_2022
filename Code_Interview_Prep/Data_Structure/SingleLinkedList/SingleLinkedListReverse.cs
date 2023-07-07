using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace SingleLinkedList
{
    public partial class SingleLinkedLists
    {
        /// <summary>
        /// This code represents an iterative approach to reverse a singly linked list. 
        /// This algorithm has a time complexity of O(n),
        /// It has a space complexity of O(1)
        /// Initial Linked List:
            //1 -> 2 -> 3 -> 4 -> null
            //head -> 1 -> 2 -> 3 -> 4 -> null
            //previous = null
            //next = null
            //current = head

            //Iteration 1:
            //head -> 2 -> 3 -> 4 -> null
            //previous = 1 -> null
            //current = 2 -> 3 -> 4 -> null
            //next = 3 -> 4 -> null
            //2 -> 1 -> null

            //Iteration 2:
            //head -> 3 -> 4 -> null
            //previous = 2 -> 1 -> null
            //current = 3 -> 4 -> null
            //next = 4 -> null
            //3 -> 2 -> 1 -> null

            //Iteration 3:
            //head -> 4 -> null
            //previous = 3 -> 2 -> 1 -> null
            //current = 4 -> null
            //next = null
            //4 -> 3 -> 2 -> 1 -> null

            //After the loop:
            //head -> null
            //previous = 4 -> 3 -> 2 -> 1 -> null

            //Reversed Linked List:
            //4 -> 3 -> 2 -> 1 -> null
        /// </summary>
        /// <returns></returns>
        public SinglyListNode IterativeReverseSinglyLinkedLIst(SinglyListNode head)
        {
            if (head == null) return head;

            //Three pointers are initialized: previous, next, and current.
            SinglyListNode previous = null;           
            SinglyListNode next = null;

            //The current pointer is set to the head of the linked list.
            SinglyListNode current = head;


            while (current != null)
            {

                next = current.next; // took and kep separare so that current can poin to it later 
                current.next = previous; //Point current to null at very begining 

                previous = current;// 
                current = next;;
            }

            return previous;

        }



    }
}
