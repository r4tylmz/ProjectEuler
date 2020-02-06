using System;

namespace Problem5
{
    internal class Program
    {
        public static bool Checker(int val)
        {
            var flag = true;
            for (var i = 1; i < 20; i++)
                if (val % i != 0)
                {
                    flag = false;
                    break;
                }

            return flag;
        }

        public static void Main(string[] args)
        {
            var i = 1;
            while (true)
                if (Checker(i))
                {
                    Console.WriteLine(i.ToString());
                    break;
                }
        }
    }
}