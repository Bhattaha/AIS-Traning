using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueImplementationCSharp
{
    class SampleQueue
    {
        //Declearing variables 
        private int[] queue;
        private int front;
        private int rear;
        private int max;

        public SampleQueue(int size)
        {
            //initlize queue
            queue = new int[size];
            //initlizing front
            front = 0;
            //initlizing rear as -1 as of now queue is empty
            rear = -1;
            // initlizing max as limit of queue ie size 
            max = size;
        }
        // insert an element in queue
        public void Insert(int item)
        {
            //check if queue is already full
            if (rear == max - 1)
            {
                Console.WriteLine("Queue Overflow");
                return;
            }
            //add an element in queue
            else
            {
                queue[++rear] = item;
            }
        }
        //Delete element
        public int Delete()
        {
            //check if queue is empty or not
            if (front == rear + 1)
            {
                Console.WriteLine("Queue is Empty");
                return -1;
            }
            else
            {
                Console.WriteLine("deleted element is: " + queue[front]);
                //returns the next adress in queue
                return queue[front++];
            }
        }
        //print queue
        public void PrintQueue()
        {
            //check if front and rear are at same position ie if queue is empty
            if (front == rear + 1)
            {
                Console.WriteLine("Queue is Empty");
                return;
            }
            else
            {
                for (int i = front; i <= rear; i++)
                {
                    Console.WriteLine("Item[" + (i + 1) + "]: " + queue[i]);
                }
            }
        }
    }


}
