
using System;

namespace Test
{

    public class Node
    {
        public int data;
        public Node prev;
        public Node next;

        public Node(int d)
        {
            data = d;
            prev= null;
            next = null;
        }

    }

    public class OperationsOnDoublyLL
    {
        public Node head;
        public void AddNodeAtInfrontOfLL(int newdata)
        {
            Node newnode = new Node(newdata);
            newnode.next = head;
            newnode.prev = null;

            if (head != null)
                head.prev = newnode;

            //move head to point new node

            head = newnode;
        }


        public void InsertAfteraGivenNode(Node prevnode, int newdata)
        {
            if (prevnode == null)
            {
                Console.WriteLine("The given previous node cannot be null.");
                return;
            }

            Node newnode = new Node(newdata);
            newnode.next = prevnode.next;
            newnode.prev = prevnode;
            prevnode.next = newnode;

            if (newnode.next != null)
                newnode.next.prev = newnode;
        }

        public void AddNodeAtEndOfThList(int newdata)
        {
            Node newnode = new Node(newdata);
            Node last = head;
            //as  new node will become the last node so  put the next of newnode as null
            newnode.next = null;

            //if head is null set newnode as head and return
            if (head == null)
            {
                head = newnode;
                return;
            }

            //if head is not null, iterate to end of the list and set newnode at last of the Ll
            while (last.next != null)
                last = last.next;

            last.next = newnode;
            newnode.prev = last;

        }

        public void DeleteNode(Node del)
        {
            if (head == null || del == null)
            {
                return;
            }

            // if node to be delete is a head node
            if (del == head)
            {
                head = head.next;
            }
            //if node to be deleted is a last node
            if (del.next == null)
            {
                del.prev.next = null;
            }

            //if the node to be deleted is a in between node
            if (del.next != null && del.prev != null)
            {
                del.prev.next = del.next;
                del.next.prev = del.prev;
            }

        }

        public void ReverseDLL()
        {
            if (head == null)
            { return; }
            Node temp = head;
            Node newhead =new Node(0);
            while(temp.next!=null)
            {
                newhead.data= temp.data;
              newhead.next=temp.prev;
              newhead.prev = temp.next;
              temp= temp.next;
            }
            head = newhead;
        }

        public void PrintList(Node node)
        {
            Node last = null;
            Console.WriteLine();
            Console.WriteLine("Traversal in forward direction");
            while (node != null)
            {
                Console.Write(node.data + " ");
                last = node;
                node = node.next;
            }
            Console.WriteLine();
            Console.WriteLine("Traversal in reverse direction");
            while (last != null)
            {
                Console.Write(last.data + " ");
                last = last.prev;
            }
        }

    }
    public class Program
    {

        public static void Main(string[] args)
        {
            OperationsOnDoublyLL objOperationOnDoublyLL = new OperationsOnDoublyLL();
            objOperationOnDoublyLL.AddNodeAtEndOfThList(6);
            objOperationOnDoublyLL.AddNodeAtInfrontOfLL(5);
            objOperationOnDoublyLL.AddNodeAtInfrontOfLL(4);
            objOperationOnDoublyLL.InsertAfteraGivenNode(objOperationOnDoublyLL.head, 4);
            // objOperationOnDoublyLL.PrintList(objOperationOnDoublyLL.head);
            objOperationOnDoublyLL.DeleteNode(objOperationOnDoublyLL.head.next);
            // objOperationOnDoublyLL.PrintList(objOperationOnDoublyLL.head);
            objOperationOnDoublyLL.ReverseDLL();
            Console.WriteLine("Printing after reversing");
            objOperationOnDoublyLL.PrintList(objOperationOnDoublyLL.head);
        }
    }
}

