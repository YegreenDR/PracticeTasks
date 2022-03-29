using System;

namespace Practice_3.Task_2
{
    internal class Program
    {

        static double f (double x)
        {
            double y = 0;
            double a = 0;
            double b = 0;
            if ((Math.Pow(x, 2) - 5 * x) < 0) y = a + b;
            else if ((Math.Pow(x, 2) - (5 * x)) <= 0  & (Math.Pow(x, 2) - (5 * x)) < 10) y = a - b;
            else if (Math.Pow(x, 2) - 5 * x >= 10) y = a * b;
            return y;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введите число а: ");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите число b: ");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите шаг h: ");
            double h = double.Parse(Console.ReadLine());
            for (double i =a;i<=b;i+=h)
                Console.WriteLine("f({0:f2})={1:f4}", i, f(i));
        }
    }
}
