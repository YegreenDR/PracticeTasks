using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_8.Task_2
{
    internal class Program
    {
        enum Dolzhnosti
        {
            Управляющий = 90,
            Менеджер = 100,
            Пиццамейкер = 120,
            Кассир = 120,
            Стажер = 50,
        }
        static void Main(string[] args)
        {
            Console.WriteLine(" 1) Управляющий");
            Console.WriteLine(" 2) Менеджер");
            Console.WriteLine(" 3) Кассир");
            Console.WriteLine(" 4) Стажер");
            Console.WriteLine();
            Console.Write("Выберите должность: ");
            int a = Convert.ToInt16(Console.ReadLine());
            Dolzhnosti worker = new Dolzhnosti();
            switch (a)
            {
                case 1:
                    {
                        Console.Write("Количество отработанных часов для получения премии: ");
                        Console.WriteLine(((int)Dolzhnosti.Управляющий)); worker = Dolzhnosti.Управляющий;
                    }
                    break;
                case 2:
                    {
                        Console.Write("Количество отработанных часов для получения премии: ");
                        Console.WriteLine((int)Dolzhnosti.Менеджер); worker = Dolzhnosti.Менеджер;
                    }
                    break;
                case 3:
                    {
                        Console.Write("Количество отработанных часов для получения премии: ");
                        Console.WriteLine((int)Dolzhnosti.Кассир); worker = Dolzhnosti.Кассир;
                    }
                    break;
                case 4:
                    {
                        Console.Write("Количество отработанных часов для получения премии: ");
                        Console.WriteLine((int)Dolzhnosti.Стажер); worker = Dolzhnosti.Стажер;
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
