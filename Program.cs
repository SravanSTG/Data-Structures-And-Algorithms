using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayManipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4, 5 };

            Console.Read();
        }

        //Add value at last position
        static int[] Push(ref int[] arr, int newValue)
        {
            Array.Resize(ref arr, arr.Length + 1);
            arr[arr.GetUpperBound(0)] = newValue;
            return arr;
        }

        //Remove last element
        static int[] Pop(ref int[] arr)
        {
            Array.Resize(ref arr, arr.Length - 1);
            return arr;
        }

        //Add At first position
        static int[] AddAtFirst(ref int[] arr, int newValue)
        {
            Array.Resize(ref arr, arr.Length + 1);
            for (int i = arr.Length - 1; i > 0; i--)
            {
                arr[i] = arr[i - 1];
            }
            arr[arr.GetLowerBound(0)] = newValue;
            return arr;
        }

        //Add At middle position
        static int[] AddinMiddle(ref int[] arr, int postion, int newValue)
        {
            Array.Resize(ref arr, arr.Length + 1);
            for (int i = arr.Length - 1; i > postion; i--)
            {
                arr[i] = arr[i - 1];
            }
            arr[postion] = newValue;
            return arr;
        }
    }
}
