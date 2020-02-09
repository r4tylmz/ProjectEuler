using System;

namespace Problem14
{
    internal class Program
    {
        private static long step(long num)
        {
            return num % 2 == 0 ? num / 2 : num * 3 + 1;
        }

        private static int collatz(long num)
        {
            var count = 1;
            while (num != 1)
            {
                num = step(num);
                count++;
            }

            return count;
        }

        public static void Main(string[] args)
        {
            int max = 0, start = 0;
            for (int i = 1; i < 1000000; i++)
            {
                var c = collatz(i);
                if (c > max)
                {
                    max = c;
                    start = i;
                }
            }

            Console.WriteLine(start);
        }
    }
}