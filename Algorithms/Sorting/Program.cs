using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSort
{
    class Program
    {
        static void Swap(int[] arr, int i, int j)
        {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }

        /* This function takes last element as pivot, places the pivot element at its correct position in sorted array, 
           and places all smaller (than pivot) to left of pivot and all greater elements to right of pivot */
        static int Partition(int[] arr, int low, int high)
        {
            // Pivot 
            int pivot = arr[high];

            // Index of smaller element and indicates the right position of pivot found so far
            int i = (low - 1);

            for (int j = low; j <= high - 1; j++)
            {
                // If current element is smaller than the pivot
                if (arr[j] < pivot)
                {
                    // Increment index of smaller element
                    i++;
                    Swap(arr, i, j);
                }
            }

            Swap(arr, i + 1, high);
            return (i + 1);
        }

        static void QuickSort(int[] arr, int low, int high)
        {
            if (low < high)
            {
                // pi is partitioning index, arr[p] is now at right place
                int pi = Partition(arr, low, high);

                // Separately sort elements before partition and after partition
                QuickSort(arr, low, pi - 1);
                QuickSort(arr, pi + 1, high);
            }
        }

        static void Main(string[] args)
        {
            int[] arr = { 3, 27, 23, 9, 69, 48, 6, 10, 18 };
            QuickSort(arr, 0, arr.Length - 1);
            foreach (int item in arr)
            {
                Console.Write(item + " ");
            }

            Console.Read();
        }
    }
}
