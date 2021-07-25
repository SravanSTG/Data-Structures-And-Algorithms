using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    class Program
    {
        static int FibonacciIterative(int n)
        {
            int a = 0, b = 1, c = 0;
            if (n == 0)
                return a;
            else if (n == 1)
                return b;
            else
            {
                for (int i = 2; i <= n; i++)
                {
                    c = a + b;
                    a = b;
                    b = c;
                }
                return c;
            }           
        }

        static int FibonacciRecursive(int n)
        {
            if (n == 0)
                return 0;
            else if (n == 1)
                return 1;
            else
                return FibonacciRecursive(n - 1) + FibonacciRecursive(n - 2);
        }

        static void Main(string[] args)
        {
            int res = FibonacciIterative(10);
            int rec = FibonacciRecursive(5);
            Console.WriteLine(res);
            Console.WriteLine(rec);

            Console.Read();
        }
    }
}
