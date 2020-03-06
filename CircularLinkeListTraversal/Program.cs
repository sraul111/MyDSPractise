
using System;
class GFG
{


    class Node
    {
        public int data;
        public Node next;
    }

    static Node push(Node head_ref, int data)
    {
        Node ptr1 = new Node();
        Node temp = head_ref;
        ptr1.data = data;
        ptr1.next = head_ref;
        if (head_ref != null)
        {
            while (temp.next != head_ref)
                temp = temp.next;
            temp.next = ptr1;
        }
        else
            ptr1.next = ptr1;

        head_ref = ptr1;
        return head_ref;
    }

    static void printList(Node head)
    {
        Node temp = head;
        if (head != null)
        {
            do
            {
                Console.Write(temp.data + "");
                temp = temp.next;
            }
            while (temp != head);

        }
    }

    static public void Main(String[] args)
    {
        /* Initialize lists as empty */
        Node head = null;

        /* Created linked list will  
        be 11.2.56.12 */
        head = push(head, 12);
        head = push(head, 56);
        head = push(head, 2);
       // head=push(head,11);
        head = push(head, 11);

        Console.WriteLine("Contents of Circular " +
                                    "Linked List:");
        printList(head);
    }
}
