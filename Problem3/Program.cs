using System;

namespace Problem3
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var number = 600851475143;
            long i;
            for (i = 2; i < number; i++)
                if (number % i == 0)
                    number /= i;
            Console.WriteLine(i);
        }
    }
}