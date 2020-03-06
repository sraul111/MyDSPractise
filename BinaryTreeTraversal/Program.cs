using System;

namespace BinaryTreeTraversal
{
    public class Node
    {
        public int key;
        public Node left, right;
        public Node(int data)
        {
            key = data;
            left = right = null;
        }
    }

    public class BinaryTree
    {
        public Node root;
        public BinaryTree()
        {
            root = null;
        }

        void PrintInOrder(Node node)
        {
            if(node == null)
            return;
            PrintInOrder(node.left);
            Console.WriteLine(node.key+" ");
            PrintInOrder(node.right);
        }
        void PrintPreOrder(Node node)
        {
            if(node==null)
            return;
            Console.WriteLine(node.key + " ");
           PrintPreOrder(node.left);
           PrintPreOrder(node.right);
        }
        void PrintPostOrder(Node node)
        {
            if (node == null)
                return;
          PrintPostOrder(node.left);
          PrintPostOrder(node.right);

          Console.Write(node.key+" ");

        }

        public void PrintInOrder() => PrintInOrder(root);
        public void PrintPreOrder() => PrintPreOrder(root);
        public void PrintPostOrder() => PrintPostOrder(root);
    }
    public class Program
    {
        static void Main(string[] args)
        {
            BinaryTree binaryTree = new BinaryTree();
            binaryTree.root = new Node(1);
            binaryTree.root.left = new Node(2);
            binaryTree.root.right = new Node(3);
            binaryTree.root.left.left = new Node(4);
            binaryTree.root.left.right = new Node(5);

            Console.WriteLine("PreOrder traversal of BinaryTree is ");
            binaryTree.PrintPreOrder();

            Console.WriteLine("\n InOrder traversal of BinaryTree is");
            binaryTree.PrintInOrder();

            Console.WriteLine("\n PostOrder traversal of BinaryTree is");
            binaryTree.PrintPostOrder();
        }
    }
}
