using System;

namespace Problem12
{
    internal class Program
    {
        private static int GetDivisors(int number)
        {
            int count = 0;

            for (int i = 1; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    if (i * i < number)
                        count += 2;
                    else
                        count++;
                }
            }

            return count;
        }

        public static void Main(string[] args)
        {
            int i = 2, number = 1;
            while (GetDivisors(number) < 500)
            {
                number += i;
                i++;
            }

            Console.WriteLine(number);
        }
    }
}