using System;
using System.Collections.Generic;

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
        public void PrintInOrder(Node node)
        {
            if (node == null)
                return;

            PrintInOrder(node.left);
            Console.Write("[" + node.key + " ");
            if (node.random == null)
                Console.Write("null], ");
            else
                Console.Write(node.random.key + "], ");
            PrintInOrder(node.right);
        }

        // Function to print the preorder traversal of a binary tree
        public static void Preorder(Node root)
        {
            if (root == null)
            {
                return;
            }

            // print data
            Console.WriteLine(root.key + " -> (");

            // print left child's data
            Console.WriteLine((root.left != null ? Convert.ToString(root.left.key) : "X") + ", ");

            // print right child's data
            Console.WriteLine((root.right != null ? Convert.ToString(root.right.key) : "X") + ", ");

            // print random child's data
            Console.WriteLine((root.random != null ? Convert.ToString(root.random.key) : "X") + ")");

            // recur for the left and right subtree
            Preorder(root.left);
            Preorder(root.right);
        }

        //Recursive function to copy random pointers from the original binary tree
        //into the cloned binary using map
        public void UpdateRandomPointers(Node root, Dictionary<Node, Node> map)
        {
            //base case
            if (map.GetValueOrDefault(root) == null)
                return;
            map.GetValueOrDefault(root).random = map.GetValueOrDefault(root.random);

            //recur for left and right subtree
            UpdateRandomPointers(root.left, map);
            UpdateRandomPointers(root.right, map);
        }

        // Recursive function to clone the data, left and right pointers for
        // each node of a binary tree into a given map
        public Node CloneLeftRightPointers(Node root, Dictionary<Node, Node> map)
        {
            //base case
            if (root == null)
                return null;
            //clone all fields of the node except the random pointers
            //create a new node with same data as root node
            map.Add(root, new Node(root.key));
            //clone the left and right subtree
            map.GetValueOrDefault(root).left = CloneLeftRightPointers(root.left, map);
            map.GetValueOrDefault(root).right = CloneLeftRightPointers(root.right, map);
            //return cloned root node
            return map.GetValueOrDefault(root);
        }

        //Main function to clone special binary tree with random pointers 
        public Node CloneSpecialBinaryTree(Node root)
        {
            // create a map to store mappings from a node to its clone
            Dictionary<Node, Node> map = new Dictionary<Node, Node>();

            //clone data left and right pointers for each node of the original
            //binary tree and put references into the map
            CloneLeftRightPointers(root, map);

            //update random pointers from  the original binary tree into the map
            UpdateRandomPointers(root, map);

            //return the cloned root node 
            return map.GetValueOrDefault(root);
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Node root = new Node(1);
            root.left = new Node(2);
            root.right = new Node(3);
            root.left.left = new Node(4);
            root.left.right = new Node(5);
            root.right.left = new Node(6);
            root.right.right = new Node(7);

            root.random = root.right.left.random;
            root.left.left.random = root.right;
            root.left.right.random = root;
            root.right.left.random = root.left.left;
            root.random = root.left;

            BinaryTree binaryTree = new BinaryTree();
            Console.Write("Preorder traversal of the original tree:");
            //BinaryTree.Preorder(root);
            binaryTree.PrintInOrder(root);

            //Node clone = binaryTree.CloneSpecialBinaryTree(root);

            //Console.Write("\nPreorder traversal of the cloned tree:");
            //BinaryTree.Preorder(clone);
        }
    }
}
