using System;
using Faker;

namespace Practice_3.Task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            var m1 = new WordMatr(3, 4);
            m1.Fill();
            m1.Info();
            Console.WriteLine("=============================================================");
            var m2 =new WordMatr(3, 4);
            m2.Fill();
            m2.Info();
            Console.WriteLine("=============================================================");
            var m3 = m1 + m2;
            m3.Info();
        }
    }
}
