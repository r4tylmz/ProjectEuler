using System;

namespace Problem10
{
    internal class Program
    {
        private static bool IsPrime(int number)
        {
            var control = true;
            if (number == 1)
                return false;

            // sayinin bolenleri 1 <=  i  <=  root(number) olmak zorundadir
            for (var i = 3; i <= Math.Sqrt(number); i += 2)
                if (number % i == 0)
                {
                    control = false;
                    break;
                }

            return control;
        }

        public static void Main(string[] args)
        {
            var sum = 2;
            for (var i = 1; i < 2000000; i += 2)
            {
                if (IsPrime(i))
                    sum += i;
            }

            Console.WriteLine(sum);
        }
    }
}