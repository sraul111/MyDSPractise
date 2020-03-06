using System;

namespace ReverseLinkList
{
    class Node
    {
      internal     int data;
        internal Node next;
       internal Node(int d)
        {
            data = d;
            next=null;
        }
    }

 class LinkedList
 {
     internal Node head;
    internal   void Push(int data)
    {
      //Node newnode = new Node(data);
      //newnode.next = head;
     // head = newnode;
       //Node temp ;
    Node newnode = new Node(data);
            if(head==null)
            {
                head = newnode;
                return;   
            }

            newnode.next=null;
            Node last =head;
            while(last.next!=null)
            last =last.next;

            last.next =newnode;
          //  return;


        
    }

    internal void ReverseList()
    {
       Node prev = null, current =head, next=null;
       while(current!=null)
       {
           next=current.next;
           current.next=prev;
           prev=current;
           current=next;
       }
     head =prev;

    }

    internal void PrintList()
    {
        while(head!=null)
        {
         Console.Write(head.data +"\t");
         head = head.next;
        }
    }
 }
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList ll = new LinkedList();
            ll.Push(1);
            ll.Push(2);
            ll.Push(3);
            Console.WriteLine("\n print the node \n");
           // ll.PrintList();
            ll.ReverseList();
             Console.WriteLine("\n print the node after reversing  \n");
             ll.PrintList();
        }
    }
}
