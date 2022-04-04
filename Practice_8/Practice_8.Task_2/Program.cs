using System;

namespace Practice_8.Task_2
{

    enum Dolznosti
    {
        Менеджер = 120,
        Стажер = 45,
        Кассир = 90,
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ДОЛЖНОСТИ");
            Console.WriteLine();
            Console.WriteLine(" 1. Менеджер");
            Console.WriteLine(" 2. Кассир");
            Console.WriteLine(" 3. Стажер");
            Console.WriteLine();
            Console.Write("Выберите должность: ");
            int a = Convert.ToInt16(Console.ReadLine());
            Dolznosti worker = new Dolznosti();
            switch (a)
            {
                case 1:
                    {
                        Console.Write("Количество отработанных часов для получения премии: ");
                        Console.WriteLine((int)Dolznosti.Менеджер); worker = Dolznosti.Менеджер;
                    }
                    break;
                case 2:
                    {
                        Console.Write("Количество отработанных часов для получения премии: ");
                        Console.WriteLine((int)Dolznosti.Кассир); worker = Dolznosti.Кассир;
                    }
                    break;
                case 3:
                    {
                        Console.Write("Количество отработанных часов для получения премии: ");
                        Console.WriteLine((int)Dolznosti.Стажер); worker = Dolznosti.Стажер;
                    }
                    break;
                default: Console.WriteLine("Введённое число не опознано."); break;
            }
            Console.WriteLine();
            Console.WriteLine("Введите количество отработанных часов за месяц: ");
            int h = Convert.ToInt16(Console.ReadLine());
            Accauntant d = new Accauntant();
            Console.WriteLine("Наличие премии: ");
            Console.WriteLine(d.AskForBonus(worker, h));
            Console.ReadLine();
        }
    }
}