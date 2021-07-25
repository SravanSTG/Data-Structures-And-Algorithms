using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseString
{
    class Program
    {
        static string ReverseIterative(string str)
        {
            string rev = "";
            for (int i = str.Length - 1; i >= 0; i--)
            {
                rev += str[i];
            }
            return rev;
        }

        static string ReverseRecursive(string str)
        {
            if (str.Length <= 1)
                return str;
            else
                return ReverseRecursive(str.Substring(1)) + str[0];
        }

        static void Main(string[] args)
        {
            string str = ReverseIterative("Hello");
            string srec = ReverseRecursive("World");
            Console.WriteLine(str);
            Console.WriteLine(srec);

            Console.Read();
        }
    }
}
