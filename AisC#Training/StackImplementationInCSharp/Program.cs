using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackImplementationInCSharp
{

    
    class Program
    {
        static void Main(string[] args)
        {
            Stack myStack = new Stack();
            //add elements to the stack
            myStack.Push(10);
            myStack.Push(20);
            myStack.Push(30);
            myStack.Push(40);
            //print the current elements in the stack
            myStack.PrintStack();
            //check the top most element in the stack
            myStack.Peek();
            //remove an element
            Console.WriteLine("Item popped from Stack : {0}", myStack.Pop());
            //print current stack
            myStack.PrintStack();
            Console.Read();
        }
    }
}

