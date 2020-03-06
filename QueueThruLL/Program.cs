using System;

namespace QueueThruLL
{

    class QNode
    {
        public int key;
        public QNode next;

        public QNode(int data)
        {
            this.key = data;
            this.next = null;
        }

    }

    class Queue
    {
        QNode front, rear;
        public Queue()
        {
            this.front = this.rear = null;
        }

        public void Enqueue(int key)
        {
            QNode temp = new QNode(key);
            if (this.rear == null)
            {
                this.front = this.rear = temp;
                Console.WriteLine("Enqueued key: {0}", rear.key);
                return;
            }
            // Add the new at the end of the queue and change rear
            this.rear.next = temp;
            this.rear = temp;
            Console.WriteLine("Enqueued key: {0}", rear.key);
        }

        public QNode Dequeue()
        {
            if (this.front == null)
                return null;
            //Store previous front and move front one node ahead
            QNode temp = this.front;
            this.front = this.front.next;
            //if this.front becomes null 
            if (this.front == null)
            {
                this.rear = null;
            }
            Console.WriteLine("Dequeued key {0}", temp.key);

            return temp;
        }

        public void PrintTheFirstandLastKey()
        {
            Console.WriteLine("the first element of Queue {0}", front.key);
            Console.WriteLine("the last element of the Queue {0}", rear.key);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Queue q = new Queue();
            Console.WriteLine("Stack Operation started. ");
            q.Enqueue(3);
            q.Enqueue(4);
            q.Enqueue(6);
            q.Enqueue(8);
            var node = q.Dequeue();
            q.PrintTheFirstandLastKey();
        }
    }
}
