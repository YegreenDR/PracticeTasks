using System;

namespace Practice_4.Task_1
{
    internal class Program
    {

        static double y1(double x)
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
                Console.WriteLine("Введите значение Х1: ");
                double x1 = double.Parse(Console.ReadLine());
                Console.WriteLine($"Результат формулы y1: " + y1(x1));
                Console.WriteLine("Введите значение Х2: ");
                double x2 = double.Parse(Console.ReadLine());
                Console.WriteLine($"Результат формулы y2: " + y2(x2));
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message, ex.StackTrace);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message,ex.StackTrace);
            }
            Console.ReadLine();
        }
    }
}
