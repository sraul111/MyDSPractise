using System;
using System.Collections.Generic;

namespace PriorityQueues
{
    class PriorityQueuesProgram
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"the ascii value is {(int)'d'}");
            Console.WriteLine("Begin Priority Queue demo");
            Console.WriteLine("Creating priority queue of Employee items");

             TestPriorityQueue(8);
            
            // Demo code here 
            
            // PriorityQueue<Data> pq = new PriorityQueue<Data>();
            // pq.Enqueue(new Data("raul",1));
            // pq.Enqueue(new Data("patil",2));
            // pq.Enqueue(new Data("jadeja",3));

            // PriorityQueue<string> pq1 = new PriorityQueue<string>();
            // pq1.Enqueue("Jadeja");
            // pq1.Enqueue("Singh");
            // pq1.Enqueue("Raul");
           
            // Console.WriteLine($"The data in the queue is as follows {pq.ToString()}");
            Console.WriteLine("End Priority Queue demo");
            Console.ReadLine();
        }

        static void TestPriorityQueue(int numOperations)
        {
            // Implementation code here
            Random rand = new Random(0);
            PriorityQueue<Data> pq =
              new PriorityQueue<Data>();
            for (int op = 0; op < numOperations; ++op)
            {
                int opType = rand.Next(0, 2);

                if (opType == 0) // enqueue
                {
                    string lastName = op + "man";
                    double priority =
                      (100.0 - 1.0) * rand.NextDouble() + 1.0;
                    pq.Enqueue(new Data(lastName, priority));
                    if (pq.IsConsistent() == false)
                    {
                        Console.WriteLine(
                          "Test fails after enqueue operation # " + op);
                    }
                }
                else // Dequeue
                {
                    if (pq.Count() > 0)
                    {
                        Data e = pq.Dequeue();
                        if (pq.IsConsistent() == false)
                        {
                            Console.WriteLine(
                              "Test fails after dequeue operation # " + op);
                        }
                    }
                }
            } // for
            Console.WriteLine("\nAll tests passed");
        }

    }

    public class Data : IComparable<Data>
    {
        public string value;
        public double priority;//Smaller values are higher priority

        public Data(string value, double priority)
        {
            this.value = value;
            this.priority = priority;
        }

        public int CompareTo(Data other)
        {
            if (this.priority < other.priority) return -1;
            else if (this.priority > other.priority) return 1;
            else return 0;
        }

        // public int CompareTo(Employeee other)
        // {

        // }
    }

    //public class Type:IComparable<>

    public class PriorityQueue<T> where T : IComparable<T>
    {
        private List<T> data;

        public PriorityQueue()
        {
            this.data = new List<T>();
        }

        public void Enqueue(T item)
        {
            data.Add(item);
            int ci = data.Count - 1;
            while (ci > 0)
            {
                int pi = (ci - 1) / 2;
                if (data[ci].CompareTo(data[pi]) >= 0)
                    break;
                T tmp = data[ci];
                data[ci] = data[pi];
                data[pi] = tmp;
                ci = pi;
            }
        }

        public T Dequeue()
        {

            int li = data.Count - 1;
            T frontItem = data[0];
            data[0] = data[li];
            data.RemoveAt(li);

            --li;
            int pi = 0;
            while (true)
            {
                int ci = pi * 2 + 1;
                if (ci > li) break;
                int rc = ci + 1;
                if (rc <= li && data[rc].CompareTo(data[ci]) < 0)
                    ci = rc;
                if (data[pi].CompareTo(data[ci]) < 0)
                    ci = rc;
                if (data[pi].CompareTo(data[ci]) <= 0) break;
                T tmp = data[pi]; data[pi] = data[ci]; data[ci] = tmp;
                pi = ci;
            }
            return frontItem;
        }

        public override string ToString()
        {
            string s = "";
            for (int i = 0; i < data.Count; i++)
                s += data[i].ToString() + "";
            s += "count =" + data.Count;

            return s;
        }

        public int Count()
        {
            return data.Count;
        }

        public bool IsConsistent()
        {
            if (data.Count == 0) return true;
            int li = data.Count - 1;
            for (int pi = 0; pi < data.Count; ++pi)
            {
                int lci = 2 * pi + 1;
                int rci = 2 * pi + 2;
                if (lci <= li && data[pi].CompareTo(data[lci]) > 0) return false;
                if (rci <= li && data[pi].CompareTo(data[rci]) > 0) return false;
            }
            return true;
        }

        public T Peek()
        {
            T frontItem = data[0];
            return frontItem;
        }
    }
}
