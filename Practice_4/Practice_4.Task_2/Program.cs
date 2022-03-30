using System;

namespace Practice_4.Task_2
{
    internal class Program
    {
        static double F(double x)
        {
            if ((x > -4) & (x < 1)) { return (3 * x) / (x - 2); }
            else if (1 <= x) { return 3; }
            else { throw new IndexOutOfRangeException("Ошибка: выход за диапазон значения X."); }
        }
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Введите х, где -4<x<1 или 1<=x:");
                var x = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("F(x)= " + F(x));

            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message, ex.StackTrace);
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message, ex.StackTrace);
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }
    }
}
