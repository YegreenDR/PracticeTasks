using System;

namespace Practice_5.Task_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            static int Factorial(int n)
            {
                if (n == 1) return n * 1;

                return n * Factorial(n - 1);
            }
            static void Main(string[] args)
            {
                Console.WriteLine("enter n as factorial");
                int n = int.Parse(Console.ReadLine());
                double f = Factorial(n - 1) / Factorial(n - 2);
                Console.WriteLine($"f(n) = {f}");
            }
        }
    }
}
