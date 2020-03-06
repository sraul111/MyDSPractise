using System;
namespace LinkListIntro
{
 
 public class LinkedList
    {   
      internal Node head;

    internal void InsertAfterNode(Node prevnode, int newdata)
    {
        if (prevnode==null)
        {
            Console.WriteLine("The previous node cannot be null");
            return;
        }
    Node newnode = new Node(newdata);
    newnode.next = prevnode.next;
    prevnode.next = newnode;

    }

        internal void AddNodeToTheEnd(int value)
        {
            Node newnode = new Node(value);
            if(head==null)
            {
                head = new Node(value);
                return;   
            }

            newnode.next=null;
            Node last =head;
            while(last.next!=null)
            last =last.next;

            last.next =newnode;
            return;
        }

        internal void ChangeTheHeadOfLinkedList(int newdata)
      {
          Node newnode = new Node(newdata);
          newnode.next = head;
          head =newnode;

      }

       internal void PrintList()
       {
          Node n = head;
          while (n!= null)
          {
              Console.Write(n.data + " \t");
              n=n.next;
          }

       }

       internal void InitialLinkedList()
       {
                     
            head = new Node(1);
            Node second = new Node(2);
            Node third = new Node(3);

            head.next = second;
            second.next=third;            

       }

    }
}