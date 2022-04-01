﻿using System;
using System.Linq;

namespace Practice_6.Task_3
{
    internal class Program
    {
        public static void Replace(string[] s)
        {
            Console.WriteLine("Замена 1 слова последним: ");
            string buf = "";
            buf = s[0];
            s[0] = s[s.Length - 1];
            s[s.Length - 1] = buf;
            for (int i = 0; i < s.Length; i++)
            {
                Console.Write(s[i] + " ");
            }
        }
        public static void Combine(string[] s)
        {
            string buf = "";
            buf = s[1] + s[2];
            s[1] = buf;
            for (int i = 2; i < s.Length - 1; i++)
            {
                s[i] = s[i + 1];
            }
            Array.Resize(ref s, s.Length - 1);
            Console.WriteLine("Склеивание 2 и 3 слова:");
            for (int i = 0; i < s.Length; i++)
            {
                Console.Write(s[i] + " ");
            }
        }
        public static void Print(string[] s)
        {
            Console.WriteLine("3 слово в обратном порядке:");
            char[] ca = s[2].ToArray();
            Array.Reverse(ca);
            Console.Write(ca);
        }
        public static void Dell(string[] s)
        {
            Console.WriteLine("Удалить 2 буквы 1 слова:");
            s[0] = s[0].Substring(2);
            Array.Resize(ref s, s.Length - 1);
            for (int i = 0; i < s.Length; i++)
            {
                Console.Write(s[i] + " ");
            }
        }
        static void Main(string[] args)
        {
            Console.Write("Введите текст: ");
            string text = Console.ReadLine();
            text = text.ToLower();
            string[] str = text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine("Изначальный текст: " + text);
            Console.Write("1) - ");
            Replace(str);
            Console.WriteLine();
            Console.Write("2) - ");
            Combine(str);
            Console.WriteLine();
            Console.Write("3) - ");
            Print(str);
            Console.WriteLine();
            Console.Write("4) - ");
            Dell(str);
            Console.ReadKey();
        }
    }
}
