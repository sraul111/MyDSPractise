using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO.MemoryMappedFiles;

namespace CloneBinaryTreeMethod1
{

    public class Node
    {
        public int key;
        public Node right, left, random;

        public Node(int value)
        {
            key = value;
            right = left = random = null;
        }
    }

    public class BinaryTree
    {
        public void  PrintInOrder(Node node)
        {
            if (node == null)
                return;

            PrintInOrder(node.left);
            Console.Write("[" + node.key + " ");
            if(node.random == null)
                Console.Write("null], ");
            else
                Console.Write(node.random.key+"], ");
            PrintInOrder(node.right);
        }

        // Function to print the preorder traversal of a binary tree
        public static void preorder(Node root)
        {
            if (root == null)
            {
                return;
            }

            // print data
            Console.Write(root.key + " -> (");

            // print left child's data
           Console.WriteLine((root.left != null ? root.left.key : "X") + ", ");

            // print right child's data
            System.out.print((root.right != null ? root.right.key : "X") + ", ");

            // print random child's data
            System.out.println((root.random != null ? root.random.data : "X") + ")");

            // recur for the left and right subtree
            preorder(root.left);
            preorder(root.right);
        }
        // Recursive function to clone the data, left and right pointers for
        // each node of a binary tree into a given map
        public Node CloneLeftRightPointers(Node root, Dictionary<Node ,Node > map)
        {
            //base case
            if (root == null)
                return null;
            //clone all fields of the node except the random pointers
            //create a new node with same data as root node
            map.Add(root,new Node(root.key));
            //clone the left and right subtree
            map.GetValueOrDefault(root).left = CloneLeftRightPointers(root.left, map);
            map.GetValueOrDefault(root).right = CloneLeftRightPointers(root.right, map);
            //return cloned root node
            return map.GetValueOrDefault(root);
        }

       //Recursive function to copy random pointers from the original binary tree
        //into the cloned binary using map
        public static void UpdateRandomPointers(Node root, Dictionary<Node, Node> map)
        {
            //base case
            if (map.GetValueOrDefault(root) == null)
                return;
            map.GetValueOrDefault(root).random = map.GetValueOrDefault(root.random);

            //recur for left and right subtree
            UpdateRandomPointers(root.left , map);
            UpdateRandomPointers(root.right ,map );
        }
        public static Node CloneSpecialBinaryTree(Node root)
        {
            Dictionary<Node, Node> map = new Dictionary<Node,Node>();
            return Node;
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
