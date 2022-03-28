using System;

namespace Practice_2.Task_1
{
    internal class Program
    {

        class A
        {
            public int a;
            public int b;

            public double FirstCalculate(int a, int b)
            {
                return (a + b) / 2;
            }

            public double SecondCalculate(int a, int b)
            {
                return (Math.Pow(b, 3) + Math.Sqrt(a));
            }

            public A(int a, int b)
            {
                this.a = a;
                this.b = b;
            }
        }
           
        

        static void Main(string[] args)
        {
            A a = new A(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));
            Console.WriteLine($"Средне арифметическое = {a.FirstCalculate(a.a,a.b)}");
            Console.WriteLine($"Подсчёт функции: {a.SecondCalculate(a.a,a.b)}");
        }
    }
}
