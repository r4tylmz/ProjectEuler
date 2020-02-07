using System;

namespace Problem9
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int c;
            for (int a = 3; a < 333; a++)
            {
                for (int b = a + 1; b < 500; b++)
                {
                    c = 1000 - a - b;
                    if (Math.Pow(a, 2) + Math.Pow(b, 2) == Math.Pow(c, 2))
                        Console.WriteLine(a * b * c);
                }
            }
        }
    }
}