using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstRecurringCharacter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an array");
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(','), int.Parse);

            List<int> list = new List<int>();
            int result = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (!list.Contains(arr[i])) 
                {
                    list.Add(arr[i]);
                }
                else
                {
                    result = arr[i];
                    break;
                }
            }

            if (result == 0)
                Console.WriteLine("No recurring character");
            else
                Console.WriteLine("First recurring character is " + result);

            Console.Read();
        }
    }
}
