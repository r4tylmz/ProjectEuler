using System;

namespace Problem7
{
    internal class Program
    {
        private static bool IsPrime(int number)
        {
            var control = true;
            for (var i = 2; i < number; i++)
                if (number % i == 0)
                {
                    control = false;
                    break;
                }

            return control;
        }

        public static void Main(string[] args)
        {
            int count = 1, i = 2;
            while (count <= 10001)
            {
                if (IsPrime(i)) count++;
                i++;
            }

            Console.WriteLine(i - 1);
        }
    }
}