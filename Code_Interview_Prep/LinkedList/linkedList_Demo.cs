using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    internal class linkedList_Demo
    {
        public static void SinglyLinkList()

        {
            // Create a new linked list
            LinkedList<int> linkedList = new LinkedList<int>();

            // Add some nodes to the linked list
            linkedList.AddLast(1);
            linkedList.AddLast(2);
            linkedList.AddLast(3);

            // Access the head and tail nodes of the linked list
            LinkedListNode<int> head = linkedList.First;
            LinkedListNode<int> tail = linkedList.Last;

            // Insert a new node after the head node
            linkedList.AddAfter(head, 4);

            // Insert a new node before the tail node
            linkedList.AddBefore(tail, 5);

            // Iterate over the linked list and print the values of the nodes
            foreach (int value in linkedList)
            {
                Console.WriteLine(value);
            }

            // Output: 1 2 3 4 5

        }
        public static void LinkList()
        {
            // Create a new linked list of strings
            LinkedList<string> list = new LinkedList<string>();

            // Add some elements to the list
            list.AddLast("apple");
            list.AddLast("banana");
            list.AddLast("cherry");

            // Iterate through the list and print the elements
            foreach (string s in list)
            {
                Console.WriteLine(s);
            }

            // Insert a new element at the beginning of the list
            list.AddFirst("mango");

            // Remove the last element from the list
            list.RemoveLast();

            // Find the node with the value "banana"
            LinkedListNode<string> node = list.Find("banana");

            // Insert a new element after the node with the value "banana"
            list.AddAfter(node, "grape");

            // Insert a new element before the node with the value "banana"
            list.AddBefore(node, "orange");

            // Clear the list
            list.Clear();

        }
    }
}
