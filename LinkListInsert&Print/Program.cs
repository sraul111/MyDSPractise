using System;

namespace LinkListInsert_Print
{
    internal class Node
    {
        public Node next;
        public int value;
        internal Node(int data)
        {
            value = data;
            next = null;
        }
    }

    internal class LinkedList
    {
        internal Node head;

        internal void AddElementsToLL(int data)
        {
            Node newnode = new Node(data);

            newnode.next = head;
            head = newnode;

        }

        internal void PrintLinkedList()
        {
            Node n = head;
            while (n != null)
            {
                Console.Write(n.value + " \t");
                n = n.next;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            LinkedList llist = new LinkedList();
            llist.AddElementsToLL(5);
            llist.AddElementsToLL(4);
            llist.AddElementsToLL(1);

            llist.PrintLinkedList();
        }
    }
}
