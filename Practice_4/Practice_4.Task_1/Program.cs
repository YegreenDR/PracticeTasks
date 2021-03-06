using System;

namespace Practice_4.Task_1
{
    internal class Program
    {

        static int y1(int x)
        {
            return ((5 * x - 7) / (4 * x + 8));
        }

        static double y2(double x)
        {
            return ((Math.Tan(x)) + (Math.Cos(x)) / x - 1);
        }

        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Введите значение Х2: ");
                int x2 = int.Parse(Console.ReadLine());
                Console.WriteLine($"Результат формулы y2: " + y2(x2));
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message, ex.StackTrace);
            }
            try
            {

                Console.WriteLine("Введите значение Х1: ");
                int x1 = int.Parse(Console.ReadLine());
                Console.WriteLine($"Результат формулы y1: " + y1(x1));
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message, ex.StackTrace);
            }
            Console.ReadLine();
        }
    }
}
