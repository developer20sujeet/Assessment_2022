using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleLinkedList
{
    public class SinglyListNode
    {
        public int data;
        public SinglyListNode next;
        public SinglyListNode(int data)
        {
            this.data = data;
            this.next = null;
        }
    }

    internal class SingleLinkedList
    {
        public SinglyListNode head= null;
        public SinglyListNode tail = null;
        public void AddNext(int data)
        {
            SinglyListNode singlyListNode = new SinglyListNode(data);

            if(head== null)
            {
                head = singlyListNode;
                tail = singlyListNode;
            }

            // Normally tail refresent the last node of linkedList so next of last node point to new node
            tail.next = singlyListNode;

            // now tail will be the last node just added above
            tail = singlyListNode;

        }
        public void AddFirst(int data)
        {
            SinglyListNode newSinglyListNode = new SinglyListNode(data);

            if (head == null)
            {
                head = newSinglyListNode;
                tail = newSinglyListNode;
            }

            newSinglyListNode.next = head;
            head = newSinglyListNode;
        }

        public void AddLast(int data)
        {


        }

    }


}
