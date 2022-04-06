using System;
using task1;

namespace task1
{
    class IntrefaceClass : Ix, Iy, Iz
    {
        public string xString;
        public IntrefaceClass()
        {
            xString = "Привет, как твои дела?";
        }
        public IntrefaceClass(string key)
        {
            xString = key;
        }
        public void IxF0(string key)
        {
            Console.WriteLine(key);
            key = key.Remove(key.Length - 2);
            Console.WriteLine($"удаление последних двух символов {key}");
        }
        public void IxF1()
        {
            Console.WriteLine(xString);
            xString = xString.Remove(xString.Length - 2);
            Console.WriteLine($"удаление двух последних символов {xString}");
        }
        public void F0(string key)
        {
            Console.WriteLine(key);
            key = key.Substring(2);
            Console.WriteLine($"удаление первых двух символов {key}");
        }
        public void F1()
        {
            Console.WriteLine(xString);
            xString = xString.Substring(2);
            Console.WriteLine($"удаление двух первых символов {xString}");
        }
        void Iz.F0(string key)
        {
            Console.WriteLine(key);
            key = key.Replace(key[0], '-');
            Console.WriteLine($"замена первого символа на - {key}");
        }
        void Iz.F1()
        {
            Console.WriteLine(xString);
            xString = xString.Replace(xString[0], '-');
            Console.WriteLine($"замена первого символа на - {xString}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            IntrefaceClass x0 = new IntrefaceClass();
            IntrefaceClass x1 = new IntrefaceClass();
            Console.WriteLine("введите строку");
            string key = Console.ReadLine();
            x0.IxF1();
            x1.IxF0(key);
            (x0 as Iy).F0(key);
            (x1 as Iz).F1();

            Console.WriteLine("==========Prism test==========");
            Console.WriteLine("==========Ix==========");
            Ix ix = x1;
            ix.IxF0(key);
            ix.IxF1();
            Console.WriteLine("==========Iy==========");
            Iy iy = x1;
            iy.F0(key);
            iy.F1();
            Console.WriteLine("==========Iz==========");
            Iz iz = x1;
            iz.F0(key);
            iz.F1();
        }
    }
}
