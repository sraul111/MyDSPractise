using System;

namespace QueueThroughArray
{
    internal class Queue
    {
        private int[] ele;
        private int front;
        private int rear;
        private int max;

        internal Queue(int size)
        {
            ele = new int[size];
            front = 0;
            rear = -1;
            max = size;
        }

        //Function to add an item to the queue
        //It changes rear and size
        public void enqueue(int item)
        {
            if (rear == max - 1)
            {
                Console.WriteLine("Queue is overflow");
                return;
            }
            else
            {

                ele[++rear] = item;
                // Console.WriteLine(ele[++rear] + "enqueued to queue");
                Console.WriteLine(item + "enqueued to queue");
            }

        }
        public int dequeue()
        {
            if (front == rear + 1)
            {
                Console.WriteLine("Queue is Empty");
                return -1;
            }
            else
            {
                Console.WriteLine(ele[front] + " dequeued from queue");
                int p = ele[front++];
                Console.WriteLine();
                Console.WriteLine("Front item is {0}", ele[front]);
                Console.WriteLine("Rear item is {0}", ele[rear]);
                return p;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Queue!");

            Queue q = new Queue(4);
            q.enqueue(2);
            q.enqueue(3);
            q.enqueue(5);
            q.enqueue(6);
            q.dequeue();
        }
    }
}
