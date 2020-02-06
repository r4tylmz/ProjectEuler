using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem4
{
    internal class Program
    {
        private static bool CheckPalindrome(string str)
        {
            var arr = str.ToCharArray();
            Array.Reverse(arr);
            return str.Equals(new string(arr));
        }

        public static void Main(string[] args)
        {
            var list = new List<int>();
            for (int i = 1000 - 1; i >= 100; i--)
            {
                for (int j = 1000 - 1; j >= 100; j--)
                {
                    var mul = i * j;
                    if (CheckPalindrome(mul.ToString()))
                    {
                        list.Add(mul);
                    }
                }
            }

            Console.WriteLine(list.Max().ToString());
        }
    }
}