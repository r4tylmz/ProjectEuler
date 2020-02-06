using System;

namespace Problem6
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var sumofsquares = (100 * 101 * 201) / 6;
            var squareofsum = Math.Pow(100 * 101 / 2, 2);
            Console.WriteLine(squareofsum - sumofsquares);
        }
    }
}