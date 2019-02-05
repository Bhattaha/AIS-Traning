using System;

namespace TB.FibonacciSeries
{
    class Program
    {
        static void Main(string[] args)
        {
            //declearing variables
            int firstNumber = 0, secondNumber = 1, result, numberOfElements;
            // Ask for number of elements
            Console.Write("Enter the number of elements: ");        
            numberOfElements = Convert.ToInt32(Console.ReadLine());
            //printing first two elements
            Console.Write(firstNumber + " " + secondNumber + " ");    
            for (int i = 2; i < numberOfElements; i++)     
            {
                result = firstNumber + secondNumber ;
                // check if prime number
               if(IsPrime(result) == true)
               {
                    // if true  write prime
                   Console.Write( " " +"Prime" +" ");
               }
               else
               {
                    //else print number itself
                    Console.Write(" "+ result + " ");
               }
                //storing new first number and second number
                firstNumber = secondNumber;
                secondNumber = result;
            }
            Console.Read();
        }
        
        //check weather no. is prime or not
        static bool IsPrime(int result)
        {
             
            if(result == 1)
            {
                return false;

            }
            for(int i=2; i < result ; i++)
            {
                if(result % i == 0)
                {
                   return false;

                }
                else
                {
                    continue ;
                }
            }
            return true;
        }
    }
}
