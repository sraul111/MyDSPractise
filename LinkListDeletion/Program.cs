using System;

namespace LinkListDeletion
{
    class Program
    {
        
        static void Main(string[] args)
        {
            LinkListOperation lListOperation = new LinkListOperation();
            lListOperation.CreateALinkList();
            Console.Write("\n Printing after creating LinkList\n");
             lListOperation.PrintList();
             lListOperation.DeleteaNode(2);
             Console.Write("\n Printing after deleting node with key 2\n");
             lListOperation.PrintList();


            Console.WriteLine("\n program ends!!");
        }
        
    }
}


