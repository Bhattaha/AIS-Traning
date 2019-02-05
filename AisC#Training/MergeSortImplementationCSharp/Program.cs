using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeSortImplementationCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 12, 11, 13, 5, 6, 7 };
            int n = array.Length;

            Console.Write("Given array is \n");
            printArray(array, n);

            MergeSort(array,0, array.Length-1);

            Console.Write("\nSorted array is \n");
            printArray(array, n);
            Console.Read();
        }
        //merge sort
        static void MergeSort(int[] array, int startIndex, int endIndex)
        {
            int mid;

            if (endIndex > startIndex)
            {
                mid = (endIndex + startIndex) / 2;
                //recursive call for first half
                MergeSort(array, startIndex, mid);
                //recursive call for second half
                MergeSort(array, (mid + 1), endIndex);
                //merge the sorted array
                Merge(array, startIndex, (mid + 1), endIndex);
            }

        }
        //Merge procedure
        static void Merge(int[] array, int left, int mid, int right)
        {
             //temp array to store sorted array
            int[] temp = new int[array.Length];
            int i, leftEnd, lengthOfInput, tmpPosition;
            leftEnd = mid - 1;
            tmpPosition = left;
            lengthOfInput = right - left + 1;

            //selecting smaller element from left sorted array or right sorted array and placing them in temp array.
            while ((left <= leftEnd) && (mid <= right))
            {
                if (array[left] <= array[mid])
                {
                    temp[tmpPosition++] = array[left++];
                }
                else
                {
                    temp[tmpPosition++] = array[mid++];
                }
            }
            //placing remaining element in temp from left sorted array
            while (left <= leftEnd)
            {
                temp[tmpPosition++] = array[left++];
            }

            //placing remaining element in temp from right sorted array
            while (mid <= right)
            {
                temp[tmpPosition++] = array[mid++];
            }

            //placing sorted array to array
            for (i = 0; i < lengthOfInput; i++)
            {
                array[right] = temp[right];
                right--;
            }
        }
        static void printArray(int[] A, int size)
        {
            int i;
            for (i = 0; i < size; i++)
                Console.Write(A[i] + " ");
            Console.WriteLine("");
        }

    }
}
