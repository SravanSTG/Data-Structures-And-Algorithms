using System;

namespace ReverseAString
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "Hi, my name is Sravan";
            string revStr = "";

            for (int i = str.Length - 1; i >= 0; i--)
            {
                revStr += str[i];
            }

            // Another way
            char[] charArray = str.ToCharArray();
            Array.Reverse(charArray);

            Console.WriteLine(str);
            Console.WriteLine(revStr);
            Console.WriteLine(charArray);

            Console.Read();
        }
    }
}
