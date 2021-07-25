using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
    class Program
    {
        static long FactorialLoop(int n)
        {
            long fact = 1;
            while (n > 0)
            {
                fact *= n;
                n--;
            }

            return fact;
        }

        static long FactorialRecursive(int n)
        {
            if (n == 1)
                return n;
            else
                return n * FactorialRecursive(n - 1);
        }

        static void Main(string[] args)
        {
            long res, rec;
            res = FactorialLoop(5);
            rec = FactorialRecursive(6);
            Console.WriteLine(res);
            Console.WriteLine(rec);

            Console.Read();
        }
    }
}
