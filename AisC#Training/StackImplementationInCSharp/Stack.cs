using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackImplementationInCSharp
{
    class Stack
    {
        //declearing maximum length of stack 
        static int MAX = 1000;
        //current top position of stack
        int top;
        //declearing stack array
        int[] stack = new int[MAX];
        //check weather the stack is empty
        public bool IsEmpty()
        {
            //return the loctaion which is before top  
            return (top < 0);
        }

        //push an element
        public bool Push(int data)
        {
            //check weather stack is already full
            if (top >= MAX)
            {
                Console.WriteLine("Stack Overflow");
                return false;
            }
            //if stack is not full then add the element
            else
            {
                //add element to the stack 
                stack[++top] = data;
                return true;
            }
        }

        //remove element from stack
        public int Pop()
        {
            //check if sack is already empty
            if (top < 0)
            {
                Console.WriteLine("Stack Underflow");
                return 0;
            }
            //remove the element from stack (top most element)
            else
            {
                int value = stack[top--];
                return value;
            }
        }

        //check the top most element in the stack
        public void Peek()
        {
            if (top < 0)
            {
                Console.WriteLine("Stack Underflow");
                return;
            }
            else
                Console.WriteLine("The topmost element of Stack is : {0}", stack[top]);
        }
        //print the elements of the stack
        public void PrintStack()
        {
            if (top < 0)
            {
                Console.WriteLine("Stack Underflow");
                return;
            }
            else
            {
                Console.WriteLine("Items in the Stack are :");
                for (int i = top; i >= 0; i--)
                {
                    Console.WriteLine(stack[i]);
                }
            }
        }
    }

}
