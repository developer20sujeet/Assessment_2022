using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
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
    public partial class SingleLinkedLists
    {
        public SinglyListNode? head = null;
        public SinglyListNode? tail = null;
        int linkedListSize = 0;
        // Adds a head at the beginning of the list
        public void AddFirst(int data)
        {
            SinglyListNode newSinglyListNode = new SinglyListNode(data);
            if (head == null)
            {
                head = newSinglyListNode;
                tail = newSinglyListNode;
                return;
            }
            newSinglyListNode.next = head;
            head = newSinglyListNode;
            linkedListSize++;
        }
        // Adds a head at the end of the list
        public void AddLast(int data)
        {
            SinglyListNode newSinglyListNode = new SinglyListNode(data);
            if (head == null)
            {
                head = newSinglyListNode;
                tail = newSinglyListNode;
                return;
            }
            tail.next = newSinglyListNode;
            tail = newSinglyListNode;
            linkedListSize++;
        }
        public void AddMiddle(int index, int data)
        {
            SinglyListNode newSinglyListNode = new SinglyListNode(data);
            // in case linked list is null
            if (head == null)
            {
                AddFirst(data);
                return;
            }
            // start from begining 
            SinglyListNode tempNode = head;
            int _index = 0;
            // why index-1 = LinkedList is zero index based , 
            while (_index < index - 1) // index 2 // -1 because linked list is 0 index based
            {
                tempNode = head.next;
                _index++;
            }
            newSinglyListNode.next = tempNode.next;
            tempNode.next = newSinglyListNode;
            linkedListSize++;
        }
        public int RemoveFirst()
        {
            // Special case
            if (linkedListSize == 0)
            {
                Console.WriteLine("Linked List not have any head");
                return int.MinValue;
            }
            else if (linkedListSize == 1) // find by count // 
            {
                int val1 = head.data;
                head = null;
                tail = null;
                linkedListSize = 0;
                return val1;
            }
            int val = head.data;
            // Just point next head to head 
            head = head.next;
            linkedListSize--;
            return val;
        }
        public int RemoveLast()
        {
            // Special case
            if (linkedListSize == 0)
            {
                Console.WriteLine("Linked List not have any head");
                return int.MinValue;
            }
            else if (linkedListSize == 1) // find by count // 
            {
                int val1 = head.data;
                head = null;
                tail = null;
                linkedListSize = 0;
                return val1;
            }
            SinglyListNode Node = head;
            // Why -2 = Normally if we have to reach till last element of array/linked list we do size -1 but we have to reach second last then -2
            for (int i = 0; i < linkedListSize - 2; i++)
            {
                Node = head.next;
            }
            int val = Node.next.data;// getting second last from last side
            Node.next = null;
            tail = Node;
            linkedListSize--;
            return val;
        }
        public int IterativeSearch(int data) // o(n) 
        {
            int returnVal = 0;
            SinglyListNode node = head;
            while (node != null)
            {
                if (node.data == data)
                {
                    return returnVal;
                }
                node = node.next;
                returnVal++;
            }
            return -1;
        }
        public int RecursiveSearch(int data) // o(n) 
        {
            return RcurHelper(head, data);
        }
        public int RcurHelper(SinglyListNode head, int data)
        {
            //If the head node is null, the function returns -1, indicating that the value of data is not found in the linked list.
            if (head == null)
            {
                return -1;
            }
            if (head.data == data)
            {
                return 0;
            }
            int index = RcurHelper(head.next, data);

            //If the index variable is -1, the function returns -1, indicating that the value of data is not found in the linked list.
            if (index == -1)
            {
                //If the index variable is -1, the function returns -1, indicating that the value of data is not found in the linked list.
                return -1;
            }
            // why +1 . Because Head.data always return 0 because head is always at 0 index 
            // Now back/previous nod know that previous nod called next node and next node return 0 so previous node need to 1 
            // Tricks and tips - All code after recursive method - always think that it will be executed by previos method/call
            // Tricks and tips - All code after recursive method - Visisualize stackoverflow or stack space 

            //the function returns index + 1, which is the index of the node that contains the value of data. The +1 is added because the current node is not the node(current node is not the node - it means that previous call executing (index + 1) but actual value was found in next - one node ahead  ) that contains the value of data, so the index needs to be incremented by 1
            return index + 1;
        }
        public void printAll(SingleLinkedLists singleLinkedLists)
        {
            if (singleLinkedLists.head == null)
            {
                Console.WriteLine("LL is null");
                return;
            }
            SinglyListNode temp = singleLinkedLists.head;
            while (temp != null)
            {
                Console.Write(temp.data + "-->");
                temp = temp.next;
            }
            Console.WriteLine("null");
        }
    }
}