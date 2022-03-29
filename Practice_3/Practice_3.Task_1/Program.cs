using System;

namespace Practice_3.Task_1
{
    internal class Program
    {

        class Sravnenie
        {
            public static double cos(double a, double b)
            {
                return (a < b) ? a : b;
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введите x: ");
            double x = double.Parse(Console.ReadLine());
            double z = Math.Cos(x * 2) + Math.Cos(x - 3);
            Console.WriteLine("z = " + z);
            var v = Sravnenie.cos(z,x);
            Console.WriteLine("Минимальный элемент: " +  v );
        }
    }
}
