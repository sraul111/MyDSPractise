namespace SwapNodesLinkedList
{
    using System;

    internal class LinkedList
    {

        Node head;

        public void SwapNodes(int x, int y)
        {
            if (x == y) return;

            //find prev node of x
            Node prevX = null, currX = head;
            while (currX != null  && currX.data != x)
            {
                prevX = currX;
                currX = prevX.next;
            }
            // Search for y (keep track of prevY and CurrY)
            Node prevY = null, currY = head;
            while (currY != null && currY.data != y)
            {
                prevY = currY;
                currY = prevY.next;
            }
            // If either x or  y is not present nothing to do
            if (currX == null || currY == null)
                return;

            //if x is not head of the linkedList.
            if (prevX != null)
                prevX.next = currY;
            else
                head = currY;

            //if y is not head of the LinkedList
            if (prevY != null)
                prevY.next = currX;
            else // make CurrX head of LinkedList
                head = currX;

            // Swap next pointers
            Node temp = currX.next;
            currX.next = currY.next;
            currY.next = temp;



        }


        internal void Push(int data)
        {
            Node newnode = new Node(data);
         //   if (head != null)
         //   {
         //       newnode.next = head;
         //       head.next = newnode;
         //   }
        //    else
        //    {
        //        head = newnode;
        //    }
            newnode.next = head;
            head = newnode;
        }

        internal void Print()
        {
            Node tNode = head;
            while (tNode != null)
            {
                Console.Write(tNode.data + "\t");
                tNode = tNode.next;
            }


        }

    }
 }