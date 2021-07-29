using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 99, 44, 6, 2, 1, 5, 63, 87, 283, 0, 4 };
            int[] resArr = InsertionSort(arr);
            foreach (int item in resArr)
            {
                Console.Write(item + " ");
            }

            Console.Read();
        }

        static int[] InsertionSort(int[] arr)
        {
            for (int i = 1; i < arr.Length; i++)
            {
                int temp = arr[i];
                int j = i - 1;
                while (j >= 0 && arr[j] > temp)
                {
                    arr[j + 1] = arr[j];
                    j--;
                }
                arr[j + 1] = temp;
            }
            return arr;
        }
    }
}
