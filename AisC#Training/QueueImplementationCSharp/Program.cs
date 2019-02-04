using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueImplementationCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            // creating Queue object of SampleQueue class
            SampleQueue Queue = new SampleQueue(5);
            //insert elements in Queue
            Queue.Insert(10);
            Queue.Insert(20);
            Queue.Insert(30);
            Queue.Insert(40);
            Queue.Insert(50);
            // print the Queue
            Console.WriteLine("Items in the queue are : ");
            Queue.PrintQueue();
            // delete elements of the queue
            Queue.Delete();
            Queue.Delete();

            Console.WriteLine("Items in the queue  are : ");
            Queue.PrintQueue();
            Console.Read();
        }
    }
}
