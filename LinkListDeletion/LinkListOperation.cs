namespace LinkListDeletion
{
    using System;
    internal class LinkListOperation
    {
        internal Node head;
        internal void CreateALinkList()
        {
            head = new Node(1);
            Node second = new Node(2);
            Node third = new Node(3);
            Node fourth = new Node(4);
            Node fifth = new Node(2);
            head.next = second;
            second.next = third;
            third.next = fourth;
            fourth.next=fifth;
            
        }

        internal void DeleteaNode(int key)
        {
           Node temp = head, prev = null;

           if (temp.next!=null && temp.data==key )
           {
               head = temp.next ;
               return;
           }
         
              while(temp.next!=null &&temp.data !=key )
              {
                prev =temp;
                temp=temp.next;                  
              }

              if(temp==null){
                  return;
              }

              prev.next = temp.next;
        }

        internal void PrintList()
       {
          Node nodetoprint = head;
          while (nodetoprint!= null)
          {
              Console.Write(nodetoprint.data + " \t");
              nodetoprint=nodetoprint.next;
          }

       }
    }
}