using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 99, 44, 6, 2, 1, 5, 63, 87, 283, 4, 0 };
            int[] resArr = BubbleSort(arr);
            foreach (int item in resArr)
            {
                Console.Write(item + " ");
            }

            Console.Read();
        }

        static int[] BubbleSort(int[] arr)
        {
            int temp;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
            return arr;
        }
    }
}
