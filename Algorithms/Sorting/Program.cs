using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 99, 44, 6, 2, 1, 5, 63, 87, 283, 0, 4 };
            int[] resArr = SelectionSort(arr);
            foreach (int item in resArr)
            {
                Console.Write(item + " ");
            }

            Console.Read();
        }

        static int[] SelectionSort(int[] arr)
        {
            int min, index = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                min = arr[i];
                index = i;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] < min)
                    {
                        min = arr[j];
                        index = j;
                    }
                }

                arr[index] = arr[i];
                arr[i] = min;
            }

            return arr;
        }
    }
}
