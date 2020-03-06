using System;

namespace SwapNodesLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList list = new LinkedList();

            list.Push(7);
            list.Push(6);
            list.Push(5);
            list.Push(4);
            list.Push(3);
            list.Push(2);
            list.Push(1);

             Console.Write("\n LinkList before calling SwapNodes()\n");
            list.Print();

            list.SwapNodes(7,9);
             Console.Write ("\n Linklist after calling Swapnodes()\n");
            list.Print();

        }
    }
}
