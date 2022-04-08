using System;
using System.Collections.Generic;
using System.Text;

namespace Assessment.DataStructure.Binary_Tree
{
    // Step 0 - Always think two things in Binary tree - 1. Create a clas on binary tree 2. fill up binary tree. 3. Traversal of it 

    // Step 1 - Create a Node class and it left and right properties of type Node class 
    public class Node
    {
        public Node left, right;

        public int data;
        public Node(int data)
        {
            this.data = data;
        }
    }

    public class Tree
    {
        public static Node createTree()
        {
            Node root = null;

            Console.WriteLine("Enter data: ");

            int data = Convert.ToInt32(Console.ReadLine());

            // -1 means no child 
            if (data == -1) return null;

            //Create Node
            root = new Node(data);

            Console.WriteLine("Enter left for " + data);

            // Keep taking left of Node 
            root.left = createTree();

            Console.WriteLine("Enter right for " + data);

            // Keep taking right of Node 
            root.right = createTree();

            return root;
        }

        public static void inOrder(Node root)
        {
            if (root == null) return;

            inOrder(root.left);
            Console.Write(root.data + " ");
            inOrder(root.right);
        }

        public static void preOrder(Node root)
        {
            if (root == null) return;
            Console.Write(root.data + " ");
            preOrder(root.left);
            preOrder(root.right);
        }

        public static void postOrder(Node root)
        {
            if (root == null) return;

            postOrder(root.left);
            postOrder(root.right);
            Console.Write(root.data + " ");
        }

        public static void Driver()
        {
            // Binary tree created 
            Node root = createTree();


            inOrder(root);
            Console.WriteLine("");
            preOrder(root);
            Console.WriteLine("");
            postOrder(root);
            Console.WriteLine("");
        }
    }


}
