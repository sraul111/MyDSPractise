using System;

namespace LinkListIntro
{
    
    public class Program
    {  
       public  static void Main(string[] args)
        {
            //start with the empty list
            LinkedList list = new LinkedList();
             list.InitialLinkedList();
            list.ChangeTheHeadOfLinkedList(0);
            list.AddNodeToTheEnd(4);
               list.PrintList();
            Console.WriteLine("\n program finished..");
        }
        
    }
}
