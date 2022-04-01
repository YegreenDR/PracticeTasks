using System;

namespace Practice_6.Task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите текст");
            string text = Console.ReadLine();
            string charInverse;
            string textInverse = "";
            for (int i = 0; i < text.Length; i++)
            {
                charInverse = text[i].ToString().ToLower() == text[i].ToString() ? 
                text[i].ToString().ToUpper() : text[i].ToString().ToLower();
                textInverse += charInverse;
            }
            Console.WriteLine(textInverse);
        }
    }
}
