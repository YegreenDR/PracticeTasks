using System;
using System.Text.RegularExpressions;

namespace Practice_7.Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку: ");
            string str = Console.ReadLine();
            Regex regex = new Regex(@"(<html>|<form>|<h1>)(\w*)");
            MatchCollection matches = regex.Matches(str);
            if (matches.Count > 0)
            {
                foreach (Match match in matches)
                    Console.WriteLine("Строка содержит код HTML");
            }
            else
            {
                Console.WriteLine("Строка не содержит код HTML");
            }
        }
    }
}
