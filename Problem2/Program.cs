using System;

namespace Problem2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int first = 1, second = 1, temp = 0, sum = 0;
            while (temp < 4000000)
            {
                if (temp % 2 == 0)
                    sum += temp;

                temp = first + second;
                first = second;
                second = temp;
            }

            Console.WriteLine(sum);
        }
    }
}