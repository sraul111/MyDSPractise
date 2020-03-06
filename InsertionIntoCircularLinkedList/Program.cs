using System;

namespace InsertionIntoCircularLinkedList
{
    public class Node
    {
        public int data;
        public Node next;
    }

    public class CircularLLInsertion
    {
        public static Node AddNodeToEmptyLinkedList(Node last, int data)
        {
            //This function is only for empty  list
            if (last != null)
                return last;
            //creating a node dynamically
            Node temp = new Node();
            //Assigning the data
            temp.data = data;
            last = temp;
            last.next =last;
            return last;
        }

        public static Node AddAtBegining(Node last, int data)
        {
            if (last == null)
            {
                return AddNodeToEmptyLinkedList(last, data);
            }
            Node temp = new Node();
            temp.data = data;
            temp.next = last.next;
            last.next = temp;

           return last;
        }
         
        public static Node AddAtEnd(Node last,int data)
        {
            if(last==null)
            {
                return AddNodeToEmptyLinkedList(last,data);
            }
            
            Node temp = new Node();
            temp.data = data;
            temp.next = last.next;
            last.next =temp;
             
            last= temp;
            return last;

        }

        public static Node AddAfterAExistingNode(Node last, int data, int item)
        {
            if (last == null)
                return null;

            Node temp, firstNode;
            firstNode = last.next;
            do
            {
                if (firstNode.data == item)
                {
                    temp = new Node();
                    temp.data = data;
                    temp.next = firstNode.next;
                    firstNode.next = temp;
                    if (firstNode == last)
                        last = temp;
                    return last;
                }
                firstNode = firstNode.next;
            } while (firstNode != last.next);
            Console.WriteLine(item + "not present in the list");

            return last;
        }
        public static void Traverse(Node last)
        {
            Node firstNode;
            if (last == null)
            {
                Console.WriteLine("List is empty.");
                return;
            }
            firstNode = last.next;

            do
            {
                Console.Write(firstNode.data + " ");
                firstNode = firstNode.next;
            } while (firstNode != last.next);

        }
    }
    class Program
    {
            CircularLLInsertion cli  = new CircularLLInsertion();
        static void Main(string[] args)
        {
            Node last = null;
            last = CircularLLInsertion.AddNodeToEmptyLinkedList(last,20);
            last = CircularLLInsertion.AddAtBegining(last,19);
            last = CircularLLInsertion.AddAtBegining(last,18);
            last = CircularLLInsertion.AddAtEnd(last,21);
            last = CircularLLInsertion.AddAtEnd(last,23);
            last = CircularLLInsertion.AddAfterAExistingNode(last,22,26);

          CircularLLInsertion.Traverse(last); 
        }
    }
}

