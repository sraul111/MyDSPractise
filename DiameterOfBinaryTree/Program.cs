using System;

namespace LevelOrderTreeTraversal
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
        public Node Root { get; private set; }

        public void AddRoot(int data)
        {
            Root = new Node(data);
        }
        public BinaryTree()
        {
            Root = null;
        }

        public void PrintLevelOrder()
        {
            int h = GetHeightOfTree(Root);
            for (int i = 1; i <= h; i++)
            {
                PrintGivenLevel(Root, i);
            }
        }
        public void PrintGivenLevel(Node root, int level)
        {
            if (root == null)
                return;

            if (level == 1)
            {
                Console.Write(root.key + "\t");
            }
            else if (level > 1)
            {
                PrintGivenLevel(root.left, level - 1);
                PrintGivenLevel(root.right, level - 1);
            }
        }
        public int GetHeightOfTree(Node root)
        {
            if (root == null)
                return 0;

            int leftheight = GetHeightOfTree(root.left);
            int rightheight = GetHeightOfTree(root.right);

            // return the the heighest L
            if (leftheight > rightheight)
            {
                return leftheight + 1;
            }
            else
            { return rightheight + 1; }
        }

        private int GetDiameterOfTree(Node root)
        {
            if (root == null)
                return 0;
            //get height of 
            int lheight = GetHeightOfTree(root.left);
            int rheight = GetHeightOfTree(root.right);

            //get the diameter of left and right subtrees
            int ldiameter = GetDiameterOfTree(root.left);
            int rdiameter = GetDiameterOfTree(root.right);

            return Math.Max(lheight + rheight + 1, Math.Max(ldiameter, rdiameter));
        }

        public int DiameterOfTree() => GetDiameterOfTree(Root);

    }
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            BinaryTree binarytree = new BinaryTree();
            binarytree.AddRoot(1);
            binarytree.Root.left = new Node(2);
            binarytree.Root.right = new Node(3);
            binarytree.Root.left.left = new Node(4);
            binarytree.Root.left.right = new Node(5);
            Console.WriteLine("Level order traversal of binary tree is");
            binarytree.PrintLevelOrder();
            Console.WriteLine("The diameter of given binary tree is:"+binarytree.DiameterOfTree());
        }
    }
}