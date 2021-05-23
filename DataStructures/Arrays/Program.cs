using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeSortedArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = { 0, 3, 4, 31 };
            int[] arr2 = { 4, 6, 30 };

            ArrayMerge(arr1, arr2);

            Console.Read();
        }

        static void ArrayMerge(int[] arr1, int[] arr2)
        {
            int length = arr1.Length + arr2.Length;
            int[] arrSorted = new int[length];
            
            for (int i = 0; i < length; i++)
            {
                if (i < arr1.Length)
                {
                    arrSorted[i] = arr1[i];
                }
                else
                {
                    arrSorted[i] = arr2[i - arr1.Length];
                }
            }

            Array.Sort(arrSorted);

            for (int i = 0; i < length; i++)
            {
                Console.Write(arrSorted[i] + " ");
            }
        }
    }
}
