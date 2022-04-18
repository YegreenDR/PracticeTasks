using System.Diagnostics;
using Task_1;

namespace Task_1
{

    class Program
    {
        static void Main(string[] args)
        {
            var consoleListener = new ConsoleTraceListener();
            var fileListener = new TextWriterTraceListener("log.txt");
            Trace.Listeners.Add(consoleListener);
            Trace.Listeners.Add(fileListener);
            Trace.AutoFlush = true;

            Console.Write("Введите радиус- ");
            double rad = Convert.ToDouble(Console.ReadLine());
            CalcFigure CF = new CalcFigure(Get_Length);
            CF += Get_Area;
            CF += Get_Volume;
            CF(rad, (s) => Trace.WriteLine(s));
        }
    }
}