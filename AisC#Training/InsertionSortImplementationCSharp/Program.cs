using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertionSortImplementationCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //declearing array w
            int[] numbers = new int[10] { 2, 5, 4, 11, 0, 18, 22, 67, 51, 6 };
            //print the orignal elements
            Console.WriteLine("\nOriginal Array Elements :");
            foreach (int number in numbers)
            {
                Console.Write(" " + number + " ");
            }
            //store sorted array 
            int[] sortedArray = InsertionSort(numbers);
            //print the sorted array
            Console.WriteLine(" \nThe Sorted Array Is");
            foreach (int number in sortedArray)
            {
                
                Console.Write(" " + number + " ");
            }
            Console.Read();

        }
        // main sorting logic
        static int[] InsertionSort(int[] inputArray)
        {
            for (int i = 0; i < inputArray.Length - 1; i++)
            {
                for (int j = i + 1; j > 0; j--)
                {
                    //if element at position i is greater than i+1  
                    if (inputArray[j - 1] > inputArray[j])
                    {
                        // swap the values at i and i+1
                        //store value at positioni i in temp variable
                        int temp = inputArray[j - 1];
                        //store value at i+1 at i
                        inputArray[j - 1] = inputArray[j];
                        //store value from temp into i
                        inputArray[j] = temp;
                    }
                }
            }
            return inputArray;
        }
    }
}
